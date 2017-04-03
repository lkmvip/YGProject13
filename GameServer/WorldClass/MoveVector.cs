using ns3;
using ns9;
using System;

namespace ns11
{
	internal class MoveVector
	{
		private DateTime dateTime_0;

		private float float_0;

		private float float_1;

		private float float_2;

		private float float_3;

		private float float_4;

		private float float_5;

		private float float_6;

		private float float_7;

		public MoveVector(Players Play, float x, float y, float z)
		{
			this.dateTime_0 = DateTime.Now;
			this.float_0 = x;
			this.float_1 = y;
			this.float_2 = z;
			this.float_3 = Play.CharacterCoords_X;
			this.float_4 = Play.CharacterCoords_Y;
			this.float_5 = Play.CharacterCoords_Z;
			this.float_7 = Play.float_0;
			float single = x - Play.CharacterCoords_X;
			float single1 = y - Play.CharacterCoords_Y;
			float single2 = (float)Math.Sqrt((double)(single * single + single1 * single1));
			this.float_6 = single2 / (Play.float_0 / 1000f);
		}

		public MoveVector(Players Play, float x, float y, float z, float fromx, float fromy, float fromz)
		{
			this.dateTime_0 = DateTime.Now;
			this.float_0 = x;
			this.float_1 = y;
			this.float_2 = z;
			this.float_3 = fromx;
			this.float_4 = fromy;
			this.float_5 = fromz;
			this.float_7 = Play.float_0;
			float single = x - Play.CharacterCoords_X;
			float single1 = y - Play.CharacterCoords_Y;
			float single2 = (float)Math.Sqrt((double)(single * single + single1 * single1));
			this.float_6 = single2 / (Play.float_0 / 1000f);
		}

		public void method_0(out float float_8, out float float_9, out float float_10)
		{
			TimeSpan timeSpan = DateTime.Now.Subtract(this.dateTime_0);
			float totalMilliseconds = (float)timeSpan.TotalMilliseconds / this.float_6;
			if (this.float_6 == 15f || totalMilliseconds > 31f)
			{
				float_8 = this.float_0;
				float_9 = this.float_1;
				float_10 = this.float_2;
				return;
			}
			float float0 = this.float_0 - this.float_3;
			float float1 = this.float_1 - this.float_4;
			float float2 = this.float_2 - this.float_5;
			float0 = float0 * totalMilliseconds;
			float1 = float1 * totalMilliseconds;
			float2 = float2 * totalMilliseconds;
			float_8 = this.float_3 + float0;
			float_9 = this.float_4 + float1;
			float_10 = this.float_5 + float2;
		}

		public bool method_1()
		{
			TimeSpan timeSpan = DateTime.Now.Subtract(this.dateTime_0);
			return (float)timeSpan.TotalMilliseconds - this.float_6 < 1000f;
		}

		public bool method_2()
		{
			if ((float)DateTime.Now.Subtract(this.dateTime_0).TotalMilliseconds / this.float_6 <= 1f && this.float_6 != 0f)
			{
				return false;
			}
			return true;
		}

		public void method_3(float float_8, float float_9, float float_10, float float_11)
		{
			this.method_0(out this.float_3, out this.float_4, out this.float_5);
			this.dateTime_0 = DateTime.Now;
			float float8 = float_8 - this.float_3;
			float float9 = float_9 - this.float_4;
			this.float_0 = float_8;
			this.float_1 = float_9;
			this.float_2 = float_10;
			float single = (float)Math.Sqrt((double)(float8 * float8 + float9 * float9));
			this.float_6 = single / (float_11 / 1000f);
		}
	}
}