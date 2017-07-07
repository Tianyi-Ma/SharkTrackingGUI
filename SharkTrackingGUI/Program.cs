using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SharkTrackingGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GUIFormView());
            GUIFormView myview = new GUIFormView();
            FormModel mymodel = new FormModel();
            FormController mycontroller = new FormController(myview, mymodel);
            Application.Run(myview);
        }
    }
}
