using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mvp_mini_total_commander
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
            Models.ModelTC model = new Models.ModelTC();
            Views.ViewTC view = new Views.ViewTC();
            Presenters.PresenterTC presenter = new Presenters.PresenterTC(model, view);
            Application.Run(view);
        }
    }
}
