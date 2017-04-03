using ns13;
using ns3;
using ns9;
using RxjhServer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Timers;

namespace ns2
{
	public class MAT_DAT_ITEM_LOAI : IDisposable
	{
		private byte[] byte_0;

		private Players class15_0;

		private VAT_PHAM_LOAI class23_0;

		private DateTime dateTime_0;

		private float float_0;

		private float float_1;

		private float float_2;

		private int int_0;

		private int int_1;

		public long long_0;

		private object object_0;

		private object object_1;

		public ThreadSafeDictionary<int, Players> threadSafeDictionary_0;

		private Timer timer_0;

		public int Rxjh_Map
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

		public float Rxjh_X
		{
			get
			{
				return this.float_0;
			}
			set
			{
				this.float_0 = value;
			}
		}

		public float Rxjh_Y
		{
			get
			{
				return this.float_1;
			}
			set
			{
				this.float_1 = value;
			}
		}

		public float Rxjh_Z
		{
			get
			{
				return this.float_2;
			}
			set
			{
				this.float_2 = value;
			}
		}

		public DateTime time
		{
			get
			{
				return this.dateTime_0;
			}
			set
			{
				this.dateTime_0 = value;
			}
		}

		public VAT_PHAM_LOAI VAT_PHAM
		{
			get
			{
				return this.class23_0;
			}
			set
			{
				this.class23_0 = value;
			}
		}

		public int VAT_PHAM_PHAT_SINH
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

		public Players VAT_PHAM_QUYEN_UU_TIEN
		{
			get
			{
				return this.class15_0;
			}
			set
			{
				this.class15_0 = value;
			}
		}

		public byte[] VATPHAM_byte
		{
			get
			{
				return this.byte_0;
			}
			set
			{
				this.byte_0 = value;
			}
		}

		public MAT_DAT_ITEM_LOAI()
		{
			this.object_0 = new object();
			this.object_1 = new object();
			this.threadSafeDictionary_0 = new ThreadSafeDictionary<int, Players>();
		}

		public MAT_DAT_ITEM_LOAI(byte[] VATPHAM_byte_, float x, float y, float z, int map, int VAT_PHAM_PHAT_SINH)
		{
			this.object_0 = new object();
			this.object_1 = new object();
			if (this.timer_0 != null)
			{
				Form1.WriteLine(1, "Ground_items_category-NEW1");
			}
			this.threadSafeDictionary_0 = new ThreadSafeDictionary<int, Players>();
			this.time = DateTime.Now;
			this.VAT_PHAM = new VAT_PHAM_LOAI(VATPHAM_byte_);
			this.VATPHAM_byte = VATPHAM_byte_;
			this.long_0 = BitConverter.ToInt64(this.VAT_PHAM.method_5(), 0);
			this.Rxjh_X = x;
			this.Rxjh_Y = y;
			this.Rxjh_Z = z;
			this.Rxjh_Map = map;
			this.VAT_PHAM_PHAT_SINH = VAT_PHAM_PHAT_SINH;
			this.timer_0 = new Timer(30000);
			this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
			this.timer_0.Enabled = true;
			this.timer_0.AutoReset = false;
		}

		public MAT_DAT_ITEM_LOAI(byte[] VATPHAM_byte_, float x, float y, float z, int map, Players name, int VAT_PHAM_PHAT_SINH)
		{
			this.object_0 = new object();
			this.object_1 = new object();
			if (this.timer_0 != null)
			{
				Form1.WriteLine(0, "Ground items class-NEW1");
			}
			this.threadSafeDictionary_0 = new ThreadSafeDictionary<int, Players>();
			this.VAT_PHAM_QUYEN_UU_TIEN = name;
			this.time = DateTime.Now;
			this.VAT_PHAM = new VAT_PHAM_LOAI(VATPHAM_byte_);
			this.VATPHAM_byte = VATPHAM_byte_;
			this.long_0 = BitConverter.ToInt64(this.VAT_PHAM.method_5(), 0);
			this.Rxjh_X = x;
			this.Rxjh_Y = y;
			this.Rxjh_Z = z;
			this.Rxjh_Map = map;
			this.VAT_PHAM_PHAT_SINH = VAT_PHAM_PHAT_SINH;
			this.timer_0 = new Timer(30000);
			this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
			this.timer_0.Enabled = true;
			this.timer_0.AutoReset = false;
		}

		public void Dispose()
		{
			try
			{
				if (this.timer_0 != null)
				{
					this.timer_0.Enabled = false;
					this.timer_0.Close();
					this.timer_0.Dispose();
					this.timer_0 = null;
				}
				if (this.threadSafeDictionary_0 != null)
				{
					this.threadSafeDictionary_0.Clear();
					this.threadSafeDictionary_0.Dispose();
				}
				this.threadSafeDictionary_0 = null;
				this.VAT_PHAM = null;
				this.VAT_PHAM_QUYEN_UU_TIEN = null;
				this.object_0 = null;
				this.object_1 = null;
			}
			catch (Exception exception)
			{
			}
		}

		~MAT_DAT_ITEM_LOAI()
		{
		}

		public void method_0()
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "npcydtheout");
			}
			try
			{
				try
				{
					if (this.timer_0 != null)
					{
						this.timer_0.Enabled = false;
						this.timer_0.Close();
						this.timer_0.Dispose();
						this.timer_0 = null;
					}
					World.threadSafeDictionary_3.Remove(this.long_0);
					this.method_2();
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					object[] str = new object[] { "items disappear Error npcydtheout ：", null, null, null, null, null };
					int num = BitConverter.ToInt32(this.VAT_PHAM.method_5(), 0);
					str[1] = num.ToString();
					str[2] = " [";
					str[3] = this.VAT_PHAM.method_13();
					str[4] = "]";
					str[5] = exception;
					Form1.WriteLine(1, string.Concat(str));
				}
			}
			finally
			{
				World.threadSafeDictionary_3.Remove(this.long_0);
				this.Dispose();
			}
		}

		public void method_1()
		{
			try
			{
				Queue queues = Queue.Synchronized(new Queue());
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (!this.method_3(400, value))
					{
						continue;
					}
					queues.Enqueue(value);
				}
				while (queues.Count > 0)
				{
					if (World.jlMsg == 1)
					{
						Form1.WriteLine(0, "Get a range of players to send ground increase item data pack");
					}
					((Players)queues.Dequeue()).BAT_GIU_KIEM_TRA_LAI_PHAM_VI_MAT_DAT_VAT_PHAM();
				}
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, string.Concat("Get a range of players to send ground increase item Packet Error：", exception));
			}
		}

		public void method_2()
		{
			try
			{
				if (this.threadSafeDictionary_0 != null)
				{
					try
					{
						Queue queues = Queue.Synchronized(new Queue());
						foreach (Players value in this.threadSafeDictionary_0.Values)
						{
							queues.Enqueue(value);
						}
						while (queues.Count > 0)
						{
							if (World.jlMsg == 1)
							{
								Form1.WriteLine(0, "Get a range of players to send ground disappear items data pack");
							}
							((Players)queues.Dequeue()).BAT_GIU_KIEM_TRA_LAI_PHAM_VI_MAT_DAT_VAT_PHAM();
						}
					}
					catch (Exception exception)
					{
						Form1.WriteLine(1, string.Concat("Get a range of players to send ground disappear items data pack1 error：", exception));
					}
					if (this.threadSafeDictionary_0 != null)
					{
						this.threadSafeDictionary_0.Clear();
					}
				}
			}
			catch (Exception exception1)
			{
				Form1.WriteLine(1, string.Concat("Get a range of players to send ground disappear items data pack 3 error：", exception1));
			}
		}

		public bool method_3(int int_2, Players class15_1)
		{
			if (class15_1.CharacterCoords_Map != this.Rxjh_Map)
			{
				return false;
			}
			float characterCoordsX = class15_1.CharacterCoords_X - this.Rxjh_X;
			float characterCoordsY = class15_1.CharacterCoords_Y - this.Rxjh_Y;
			return (float)((int)Math.Sqrt((double)(characterCoordsX * characterCoordsX + characterCoordsY * characterCoordsY))) <= (float)int_2;
		}

		public static MAT_DAT_ITEM_LOAI smethod_0(long long_1)
		{
			MAT_DAT_ITEM_LOAI mATDATITEMLOAI;
			if (World.threadSafeDictionary_3.TryGetValue(long_1, out mATDATITEMLOAI))
			{
				return mATDATITEMLOAI;
			}
			return null;
		}

		public void timer_0_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "npcydtheout2");
			}
			try
			{
				try
				{
					if (this.timer_0 != null)
					{
						this.timer_0.Enabled = false;
						this.timer_0.Close();
						this.timer_0.Dispose();
						this.timer_0 = null;
					}
					World.threadSafeDictionary_3.Remove(this.long_0);
					this.method_2();
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					object[] str = new object[] { "Items disappear Errornpcydtheout2 ：", null, null, null, null, null };
					long num = BitConverter.ToInt64(this.VAT_PHAM.method_5(), 0);
					str[1] = num.ToString();
					str[2] = " [";
					str[3] = this.VAT_PHAM.method_13();
					str[4] = "]";
					str[5] = exception;
					Form1.WriteLine(1, string.Concat(str));
				}
			}
			finally
			{
				World.threadSafeDictionary_3.Remove(this.long_0);
				this.Dispose();
			}
		}
	}
}