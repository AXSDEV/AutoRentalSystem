using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRentalSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var ptPT = new CultureInfo("pt-PT");
            Thread.CurrentThread.CurrentCulture = ptPT;
            Thread.CurrentThread.CurrentUICulture = ptPT;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_home());
        }
    }
}
