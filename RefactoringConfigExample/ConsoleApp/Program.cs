namespace ConsoleApp
{
    using System;
    using System.Configuration;
    using log4net;
    using log4net.Config;

    internal class Program
    {
        private static void Main()
        {
            XmlConfigurator.Configure();

            ILog logger = LogManager.GetLogger("logger");

            logger.WarnFormat("Some warn {0}", 109);

            Console.WriteLine();
            Console.WriteLine("SmtpHost: {0}", ConfigurationManager.AppSettings["SmtpHost"]);
            Console.WriteLine("SmtpUserName: {0}", ConfigurationManager.AppSettings["SmtpUserName"]);
            Console.WriteLine("Profile: {0}", ConfigurationManager.AppSettings["Profile"]);
        }
    }
}