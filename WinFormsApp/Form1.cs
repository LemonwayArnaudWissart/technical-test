using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.ServiceReference;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        private readonly WebServiceSoap _service = new WebServiceSoapClient();
        public MainForm()
        {
            InitializeComponent();
        }
        private async void btnComputeFib_Click(object sender, EventArgs e)
        {
            int.TryParse(numericUpDownFibonacci.Value.ToString(CultureInfo.InvariantCulture), out var input);
            var task2Wait = Task.Run(() => _service.Fibonacci(input));
            using (var dialog = new LoadingForm(this, task2Wait))
            {
                dialog.ShowDialog(this);
                var result = await task2Wait;
                MessageBox.Show(result.ToString());
            }
        }
        private async void btnComputeXML2JSON_Click(object sender, EventArgs e)
        {
            var xmlString = tbXmlString.Text.Trim();
            var req = new XmlToJsonRequest { Body = new XmlToJsonRequestBody { xml = xmlString } };
            var task2Wait = Task.Run(() => _service.XmlToJsonAsync(req));
            using (var dialog = new LoadingForm(this, task2Wait))
            {
                dialog.ShowDialog(this);
                var result = await task2Wait;
                MessageBox.Show(result.Body.XmlToJsonResult);
            }
        }
    }
}
