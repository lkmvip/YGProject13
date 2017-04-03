namespace LoginServer
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    public class FlickerFreePanel : Panel
    {
        private IContainer components;

        static FlickerFreePanel()
        {
            ZYXDNGuarder.Startup();
        }

        public FlickerFreePanel()
        {
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.DoubleBuffer, true);
            base.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void method_0()
        {
            this.components = new Container();
        }
    }
}

