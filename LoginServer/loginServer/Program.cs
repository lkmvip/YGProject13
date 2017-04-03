namespace LoginServer
{
    using System;
    using System.Windows.Forms;

    internal static class Program
    {
        static Program()
        {
            ZYXDNGuarder.Startup();
        }

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

