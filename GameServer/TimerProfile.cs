using System;

namespace ns9
{
	internal class TimerProfile
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private TimeSpan timeSpan_0;

		private TimeSpan timeSpan_1;

		public TimerProfile()
		{
		}

		public void method_0()
		{
			this.int_0 = this.int_0 + 1;
		}

		public void method_1()
		{
			this.int_1 = this.int_1 + 1;
		}

		public void method_2()
		{
			this.int_2 = this.int_2 + 1;
		}

		public void method_3(TimeSpan timeSpan_2)
		{
			this.int_3 = this.int_3 + 1;
			this.timeSpan_0 = this.timeSpan_0 + timeSpan_2;
			if (timeSpan_2 > this.timeSpan_1)
			{
				this.timeSpan_1 = timeSpan_2;
			}
		}
	}
}