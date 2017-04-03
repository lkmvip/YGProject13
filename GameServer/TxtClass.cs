using System;

namespace ns12
{
	internal class TxtClass : IDisposable
	{
		private int int_0;

		private string string_0;

		public string Txt
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		public int type
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public TxtClass(int type, string txtt)
		{
			this.int_0 = type;
			this.string_0 = txtt;
		}

		void System.IDisposable.Dispose()
		{
			this.string_0 = null;
		}
	}
}