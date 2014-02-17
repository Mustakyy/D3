using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace D3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlLibrary.XmlHandling.createXMLDB("Products.xml");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //create settings xml file
            XmlLibrary.XmlHandling.createSettingsXML("Settings.xml");

            //EULA check and new form if not accepted yet
            if (!XmlLibrary.XmlHandling.EULAaccepted("Settings.xml", "0.1"))
            {
                Application.Run(new EULA());
            }
            if (XmlLibrary.XmlHandling.EULAaccepted("Settings.xml", "0.1"))
            {
                //after 1 month from today build will expire
                DateTime buildExpirationDay = new DateTime(2009, 12, 4);
                DateTime today = DateTime.Now;
                int daysLeft = (buildExpirationDay - today).Days + 1;
                if (daysLeft < 0)
                {
                    daysLeft = 0;
                }
                Application.Run(new WelcomingForm(daysLeft));
                if (daysLeft != 0 || XmlLibrary.XmlHandling.registeredUser("Settings.xml"))
                {
                    Application.Run(new D3());
                }
            }

        }
    }
}
