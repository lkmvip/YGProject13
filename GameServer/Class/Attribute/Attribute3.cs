using System;

namespace ns12
{
	internal sealed class Attribute3 : Attribute
	{
		private bool bool_0 = true;

		private bool bool_1 = true;

		private bool bool_2 = true;

		private string string_0 = "all";

		public bool ApplyToMembers
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		public bool Exclude
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
			}
		}

		public string Feature
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

		public bool StripAfterObfuscation
		{
			get
			{
				return this.bool_2;
			}
			set
			{
				this.bool_2 = value;
			}
		}

		public Attribute3()
		{
		}
	}
}