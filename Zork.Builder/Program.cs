using System;
using System.Windows.Forms;

namespace Zork.Builder
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Zork_Builder());
        }
    }
}
