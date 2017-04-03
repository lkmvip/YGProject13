using System;

namespace ns11
{
	internal class ThreadParameter
	{
		private int int_0;

		private int int_1;

		private string string_0;

		private string string_1;

		public string id
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

		public string name
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

		public int 类型
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		public int 全局ID
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

		public ThreadParameter(int 全局ID, string id, string name, int 类型)
		{
		}
	}
}