using System.Threading;
using System.Web.Services;
using log4net;
using ServiceCore;

namespace SoapService
{
    /// <summary>
    /// Description résumée de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(WebService));
        [WebMethod]
        public int Fibonacci(int n)
        {
            // For Winform loading animation
            log.Info("Entering Fibonacci.");
            Thread.Sleep(1000);
            if (n <= 1 || n >= 100) { return -1; }
            return Core.Fibonacci(n);
        }
        [WebMethod]
        public string XmlToJson(string xml)
        {
            log.Info("Entering XmlToJson.");
            // For Winform loading animation
            Thread.Sleep(1000);
            return Core.ConvertXmlToJson(xml);
        }
    }
}