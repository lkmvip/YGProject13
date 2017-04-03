using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ns6
{
	internal class FlickerFreePanel : Panel
	{
		private IContainer icontainer_0;

		public FlickerFreePanel()
		{
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.DoubleBuffer, true);
			base.SetStyle(ControlStyles.UserPaint, true);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_0()
		{
			this.icontainer_0 = new System.ComponentModel.Container();
		}
	}
}