using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using log4net;
using log4net.Config;

namespace SoapService
{
    public class Global : System.Web.HttpApplication
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Global));
        protected void Application_Start(object sender, EventArgs e)
        {

            var configFile = Server.MapPath("~/log4net.config");
            var test = File.Exists(configFile);
            XmlConfigurator.Configure(new FileInfo(configFile));

            log.Info("Démarrage des services");

        }
    }
}