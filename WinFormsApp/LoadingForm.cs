using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class LoadingForm : Form
    {
        public LoadingForm(Form parent, Task task2Wait)
        {
            InitializeComponent();
            if (parent != null)
            {
                StartPosition = FormStartPosition.Manual;
                Location = new Point(parent.Location.X + parent.Width / 2 - this.Width / 2, parent.Location.Y + parent.Height / 2 - this.Height / 2);
            }
            TopMost = true;
            task2Wait.ContinueWith(t =>
            {
                DialogResult = DialogResult.OK;
            });
        }
    }
}