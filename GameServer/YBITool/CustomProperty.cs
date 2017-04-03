using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns8
{
	internal class CustomProperty
	{
		private object object_0;

		private object object_1;

		private object object_2;

		private PropertyInfo[] propertyInfo_0;

		private string string_0;

		public string Category
		{
			get;
			set;
		}

		public bool ConverterType
		{
			get;
			set;
		}

		public object DefaultValue
		{
			get
			{
				return this.object_0;
			}
			set
			{
				this.object_0 = value;
				if (this.object_0 != null)
				{
					if (this.object_1 == null)
					{
						this.object_1 = this.object_0;
					}
					if (this.ValueType == null)
					{
						this.ValueType = this.object_0.GetType();
					}
				}
			}
		}

		public string Description
		{
			get;
			set;
		}

		public Type EditorType
		{
			get;
			set;
		}

		public bool IsBrowsable
		{
			get;
			set;
		}

		public bool IsReadOnly
		{
			get;
			set;
		}

		public string Name
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
				if (this.PropertyNames == null)
				{
					this.PropertyNames = new string[] { this.string_0 };
				}
			}
		}

		public object ObjectSource
		{
			get
			{
				return this.object_2;
			}
			set
			{
				this.object_2 = value;
				this.method_0();
			}
		}

		protected PropertyInfo[] PropertyInfos
		{
			get
			{
				if (this.propertyInfo_0 == null)
				{
					Type type = this.ObjectSource.GetType();
					this.propertyInfo_0 = new PropertyInfo[(int)this.PropertyNames.Length];
					for (int i = 0; i < (int)this.PropertyNames.Length; i++)
					{
						this.propertyInfo_0[i] = type.GetProperty(this.PropertyNames[i]);
					}
				}
				return this.propertyInfo_0;
			}
		}

		public string[] PropertyNames
		{
			get;
			set;
		}

		public object Value
		{
			get
			{
				return this.object_1;
			}
			set
			{
				this.object_1 = value;
				this.method_1();
			}
		}

		public Type ValueType
		{
			get;
			set;
		}

		public CustomProperty()
		{
			this.string_0 = string.Empty;
		}

		public CustomProperty(string name, string THUOC_TINH_TEN, bool isReadOnly, string category, string description, object 对象) : this(name, new string[] { THUOC_TINH_TEN }, null, null, null, isReadOnly, true, category, description, 对象, null, false)
		{
		}

		public CustomProperty(string name, string 属性名, bool isReadOnly, string category, string description, object 对象, bool converterType) : this(name, new string[] { 属性名 }, null, null, null, isReadOnly, true, category, description, 对象, null, converterType)
		{
		}

		public CustomProperty(string name, string 属性名, bool isReadOnly, string category, string description, object 对象, Type editorType) : this(name, new string[] { 属性名 }, null, null, null, isReadOnly, true, category, description, 对象, editorType, false)
		{
		}

		public CustomProperty(string name, string 属性名, bool isReadOnly, string category, string description, object 对象, Type editorType, bool converterType) : this(name, new string[] { 属性名 }, null, null, null, isReadOnly, true, category, description, 对象, editorType, converterType)
		{
		}

		public CustomProperty(string name, string[] 属性名, Type valueType, object defaultValue, object value, bool isReadOnly, bool isBrowsable, string category, string description, object 对象, Type editorType, bool converterType)
		{
			this.string_0 = string.Empty;
			this.Name = name;
			this.PropertyNames = 属性名;
			this.ValueType = valueType;
			this.object_0 = defaultValue;
			this.object_1 = value;
			this.IsReadOnly = isReadOnly;
			this.IsBrowsable = isBrowsable;
			this.Category = category;
			this.Description = description;
			this.ObjectSource = 对象;
			this.EditorType = editorType;
			this.ConverterType = converterType;
		}

		protected void method_0()
		{
			if (this.PropertyInfos.Length != 0)
			{
				object value = this.PropertyInfos[0].GetValue(this.object_2, null);
				if (this.object_0 == null)
				{
					this.DefaultValue = value;
				}
				this.object_1 = value;
			}
		}

		protected void method_1()
		{
			if (this.object_2 != null)
			{
				PropertyInfo[] propertyInfos = this.PropertyInfos;
				for (int i = 0; i < (int)propertyInfos.Length; i++)
				{
					propertyInfos[i].SetValue(this.object_2, this.object_1, null);
				}
			}
		}

		public void ResetValue()
		{
			this.Value = this.DefaultValue;
		}
	}
}