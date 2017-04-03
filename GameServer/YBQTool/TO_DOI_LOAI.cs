using ns13;
using ns3;
using ns9;
using System;
using System.Collections.Generic;

namespace ns10
{
	internal class TO_DOI_LOAI : IDisposable
	{
		public Players class15_0;

		public Dictionary<int, Players> dictionary_0;

		public int int_0;

		public List<Players> list_0 = new List<Players>();

		public List<Players> list_1 = new List<Players>();

		public string string_0;

		public TO_DOI_LOAI(Players TRUONG_NHOM_)
		{
			this.string_0 = TRUONG_NHOM_.UserName;
			this.dictionary_0 = new Dictionary<int, Players>()
			{
				{ TRUONG_NHOM_.UserSessionID, TRUONG_NHOM_ }
			};
			this.list_1.Add(TRUONG_NHOM_);
		}

		public void Dispose()
		{
			try
			{
				try
				{
					this.dictionary_0.Clear();
					this.list_1.Clear();
					World.dictionary_24.Remove(this.int_0);
					this.class15_0 = null;
					this.list_0 = null;
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					Form1.WriteLine(1, string.Concat("组队类 Dispose 出错!", exception.Message));
				}
			}
			finally
			{
				this.list_0 = null;
				this.list_1 = null;
				this.dictionary_0 = null;
				World.dictionary_24.Remove(this.int_0);
			}
		}

		~TO_DOI_LOAI()
		{
		}

		public void method_0(Players class15_1)
		{
			try
			{
				this.dictionary_0.Remove(class15_1.UserSessionID);
				this.list_1.Remove(class15_1);
				this.Dispose();
				class15_1.TO_DOI_ID = 0;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("组队类 退出 出错!", exception.Message));
			}
		}
	}
}