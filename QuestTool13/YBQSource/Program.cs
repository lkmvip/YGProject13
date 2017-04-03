using RxjhTool;
using System;
using System.Windows.Forms;
namespace YbqTool_Standalone
{
      internal static class Program
      {
            [STAThread]
            private static void Main()
            {
                  Application.EnableVisualStyles();
                  Application.SetCompatibleTextRenderingDefault(false);
                  Application.Run(new YbQForm());
            }
      }
}
