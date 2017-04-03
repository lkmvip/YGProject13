using System;
using System.IO;

namespace ns4
{
	internal class WriteLogClass
	{
		public WriteLogClass()
		{
		}

		public static void smethod_0(string string_0)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				DateTime now = DateTime.Now;
				using (StreamWriter streamWriter = new StreamWriter(new FileStream(string.Concat("logs\\错误日志_", now.ToString("yyyy_MM_dd"), ".log"), FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(string.Concat(new object[] { DateTime.Now, " ", string_0, "\r\n" }));
				}
			}
			catch
			{
			}
		}

		public static void smethod_1(string string_0)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				DateTime now = DateTime.Now;
				using (StreamWriter streamWriter = new StreamWriter(new FileStream(string.Concat("logs\\帮战日志_", now.ToString("yyyy_MM_dd"), ".log"), FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(string.Concat(new object[] { DateTime.Now, " ", string_0, "\r\n" }));
				}
			}
			catch
			{
			}
		}

		public static void smethod_10(string string_0)
		{
		}

		public static void smethod_2(string string_0)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				DateTime now = DateTime.Now;
				using (StreamWriter streamWriter = new StreamWriter(new FileStream(string.Concat("logs\\非法VAT_PHAM日志_", now.ToString("yyyy_MM_dd"), ".log"), FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(string.Concat(new object[] { DateTime.Now, " ", string_0, "\r\n" }));
				}
			}
			catch
			{
			}
		}

		public static void smethod_3(string string_0)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				DateTime now = DateTime.Now;
				using (StreamWriter streamWriter = new StreamWriter(new FileStream(string.Concat("logs\\CQLog_", now.ToString("yyyy_MM_dd"), ".log"), FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(string.Concat(new object[] { DateTime.Now, " ", string_0, "\r\n" }));
				}
			}
			catch
			{
			}
		}

		public static void smethod_4(string string_0)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				DateTime now = DateTime.Now;
				using (StreamWriter streamWriter = new StreamWriter(new FileStream(string.Concat("logs\\登陆日志_", now.ToString("yyyy_MM_dd"), ".log"), FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(string.Concat(new object[] { DateTime.Now, " ", string_0, "\r\n" }));
				}
			}
			catch
			{
			}
		}

		public static void smethod_5(string string_0)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				DateTime now = DateTime.Now;
				using (StreamWriter streamWriter = new StreamWriter(new FileStream(string.Concat("logs\\DropItme_", now.ToString("yyyy_MM_dd"), ".log"), FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(string.Concat(new object[] { DateTime.Now, " ", string_0, "\r\n" }));
				}
			}
			catch
			{
			}
		}

		public static void smethod_6(string string_0)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				DateTime now = DateTime.Now;
				using (StreamWriter streamWriter = new StreamWriter(new FileStream(string.Concat("logs\\ItmeLog_", now.ToString("yyyy_MM_dd"), ".log"), FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(string.Concat(new object[] { DateTime.Now, " ", string_0, "\r\n" }));
				}
			}
			catch
			{
			}
		}

		public static void smethod_7(string string_0)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				DateTime now = DateTime.Now;
				using (StreamWriter streamWriter = new StreamWriter(new FileStream(string.Concat("logs\\BugLog_", now.ToString("yyyy_MM_dd"), ".txt"), FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(string.Concat(new object[] { DateTime.Now, " ", string_0, "\r\n" }));
				}
			}
			catch
			{
			}
		}

		public static void smethod_8(string string_0)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				DateTime now = DateTime.Now;
				using (StreamWriter streamWriter = new StreamWriter(new FileStream(string.Concat("logs\\封包_", now.ToString("yyyy_MM_dd"), ".txt"), FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(string.Concat(new object[] { DateTime.Now, " ", string_0, "\r\n" }));
				}
			}
			catch
			{
			}
		}

		public static void smethod_9(string string_0)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				DateTime now = DateTime.Now;
				using (StreamWriter streamWriter = new StreamWriter(new FileStream(string.Concat("logs\\存档_", now.ToString("yyyy_MM_dd"), ".txt"), FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(string.Concat(new object[] { DateTime.Now, " ", string_0, "\r\n" }));
				}
			}
			catch
			{
			}
		}

		public static void System_Log(string string_0)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			DateTime now = DateTime.Now;
			using (StreamWriter streamWriter = new StreamWriter(new FileStream(string.Concat("logs\\SystemLog_", now.ToString("yyyy_MM_dd"), ".txt"), FileMode.Append, FileAccess.Write, FileShare.Read)))
			{
				streamWriter.Write(string.Concat(new object[] { DateTime.Now, " ", string_0, "\r\n" }));
			}
		}
	}
}