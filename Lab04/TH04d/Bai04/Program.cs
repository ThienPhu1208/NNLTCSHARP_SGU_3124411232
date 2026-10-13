
using System;
using System.Windows.Forms;

namespace TH04d
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Bai04());
        }
    }
}
