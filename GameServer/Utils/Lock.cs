using ns13;
using ns3;
using System;
using System.Threading;

namespace ns12
{
	internal class Lock : IDisposable
	{
		public static int int_0;

		private object object_0;

		public bool IsTimeout
		{
			get
			{
				return this.object_0 == null;
			}
		}

		static Lock()
		{
			Lock.ZYDNGuard();
		}

		public Lock(object obj)
		{
			this.method_0(obj, 1000, true, "");
		}

		public Lock(object obj, string lei)
		{
			this.method_0(obj, 1000, true, lei);
		}

		public Lock(object obj, int millisecondsTimeout, bool throwTimeoutException, string lei)
		{
			this.method_0(obj, millisecondsTimeout, throwTimeoutException, lei);
		}

		private void method_0(object object_1, int int_1, bool bool_0, string string_0)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "TryGet");
			}
			if (Monitor.TryEnter(object_1, int_1))
			{
				this.object_0 = object_1;
				return;
			}
			if (bool_0)
			{
				Form1.WriteLine(100, string.Concat(new object[] { "锁定对象超时:", string_0, " ", object_1.GetType() }));
			}
		}

		void System.IDisposable.Dispose()
		{
			if (this.object_0 != null)
			{
				Monitor.Exit(this.object_0);
				this.object_0 = null;
			}
		}

		private static void ZYDNGuard()
		{
			Lock.int_0 = 1000;
		}
	}
}