using System;

namespace ns11
{
	internal class SeveClass
	{
		private string string_0;

		private string string_1;

		public string ServerDb
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

		public string SqlConnect
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		public SeveClass()
		{
		}
	}
}