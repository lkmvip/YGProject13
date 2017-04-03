using System;

namespace ns11
{
	internal class ClientIpAddress
	{
		private string string_0;

		private string string_1;

		private string string_2;

		private string string_3;

		public string ID
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

		public string MAC地址
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

		public string 内网IP地址
		{
			get
			{
				return this.string_2;
			}
			set
			{
				this.string_2 = value;
			}
		}

		public string 外网IP地址
		{
			get
			{
				return this.string_3;
			}
			set
			{
				this.string_3 = value;
			}
		}

		public ClientIpAddress(string id, string Nip, string Wip, string MAC)
		{
			this.ID = id;
			this.内网IP地址 = Nip;
			this.外网IP地址 = Wip;
			this.MAC地址 = MAC;
		}
	}
}