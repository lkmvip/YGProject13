using ns8;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace ns12
{
	public class Reverser<T> : IComparer<T>
	{
		private Struct10 struct10_0;

		private Type type_0;

		public Reverser(string className, string name, Struct10.Enum1 direction)
		{
			try
			{
				this.type_0 = Type.GetType(className, true);
				this.struct10_0.string_0 = name;
				this.struct10_0.enum1_0 = direction;
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}
		}

		public Reverser(Type type, string name, Struct10.Enum1 direction)
		{
			this.type_0 = type;
			this.struct10_0.string_0 = name;
			if (direction != Struct10.Enum1.const_0)
			{
				this.struct10_0.enum1_0 = direction;
			}
		}

		public Reverser(T t, string name, Struct10.Enum1 direction)
		{
			this.type_0 = t.GetType();
			this.struct10_0.string_0 = name;
			this.struct10_0.enum1_0 = direction;
		}

		private void method_0(ref object object_0, ref object object_1)
		{
			object object0 = null;
			object0 = object_0;
			object_0 = object_1;
			object_1 = object0;
		}

		int System.Collections.Generic.IComparer<T>.Compare(T x, T y)
		{
			object obj = this.type_0.InvokeMember(this.struct10_0.string_0, BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty, null, x, null);
			object obj1 = this.type_0.InvokeMember(this.struct10_0.string_0, BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty, null, y, null);
			if (this.struct10_0.enum1_0 != Struct10.Enum1.const_0)
			{
				this.method_0(ref obj, ref obj1);
			}
			return (new CaseInsensitiveComparer()).Compare(obj, obj1);
		}
	}
}