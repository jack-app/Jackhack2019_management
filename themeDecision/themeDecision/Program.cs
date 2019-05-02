using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace themeDecision
{
    static class Program
    {
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
