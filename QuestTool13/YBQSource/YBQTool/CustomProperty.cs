using System;
using System.Reflection;
namespace RxjhTool
{
	public class CustomProperty
	{
		private object _defaultValue;
		private string _name;
		private PropertyInfo[] _propertyInfos;
		private object _value;
		private object _对象;
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
				return this._defaultValue;
			}
			set
			{
				this._defaultValue = value;
				if (this._defaultValue != null)
				{
					if (this._value == null)
					{
						this._value = this._defaultValue;
					}
					if (this.ValueType == null)
					{
						this.ValueType = this._defaultValue.GetType();
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
				return this._name;
			}
			set
			{
				this._name = value;
				if (this.PropertyNames == null)
				{
					this.PropertyNames = new string[]
					{
						this._name
					};
				}
			}
		}
		public object ObjectSource
		{
			get
			{
				return this._对象;
			}
			set
			{
				this._对象 = value;
				this.OnObjectSourceChanged();
			}
		}
		protected PropertyInfo[] PropertyInfos
		{
			get
			{
				if (this._propertyInfos == null)
				{
					Type type = this.ObjectSource.GetType();
					this._propertyInfos = new PropertyInfo[this.PropertyNames.Length];
					for (int i = 0; i < this.PropertyNames.Length; i++)
					{
						this._propertyInfos[i] = type.GetProperty(this.PropertyNames[i]);
					}
				}
				return this._propertyInfos;
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
				return this._value;
			}
			set
			{
				this._value = value;
				this.OnValueChanged();
			}
		}
		public Type ValueType
		{
			get;
			set;
		}
		public CustomProperty()
		{
			this._name = string.Empty;
		}
		public CustomProperty(string name, string 属性名, bool isReadOnly, string category, string description, object 对象) : this(name, new string[]
		{
			属性名
		}, null, null, null, isReadOnly, true, category, description, 对象, null, false)
		{
		}
		public CustomProperty(string name, string 属性名, bool isReadOnly, string category, string description, object 对象, bool converterType) : this(name, new string[]
		{
			属性名
		}, null, null, null, isReadOnly, true, category, description, 对象, null, converterType)
		{
		}
		public CustomProperty(string name, string 属性名, bool isReadOnly, string category, string description, object 对象, Type editorType) : this(name, new string[]
		{
			属性名
		}, null, null, null, isReadOnly, true, category, description, 对象, editorType, false)
		{
		}
		public CustomProperty(string name, string 属性名, bool isReadOnly, string category, string description, object 对象, Type editorType, bool converterType) : this(name, new string[]
		{
			属性名
		}, null, null, null, isReadOnly, true, category, description, 对象, editorType, converterType)
		{
		}
		public CustomProperty(string name, string[] 属性名, Type valueType, object defaultValue, object value, bool isReadOnly, bool isBrowsable, string category, string description, object 对象, Type editorType, bool converterType)
		{
			this._name = string.Empty;
			this.Name = name;
			this.PropertyNames = 属性名;
			this.ValueType = valueType;
			this._defaultValue = defaultValue;
			this._value = value;
			this.IsReadOnly = isReadOnly;
			this.IsBrowsable = isBrowsable;
			this.Category = category;
			this.Description = description;
			this.ObjectSource = 对象;
			this.EditorType = editorType;
			this.ConverterType = converterType;
		}
		protected void OnObjectSourceChanged()
		{
			if (this.PropertyInfos.Length != 0)
			{
				object value = this.PropertyInfos[0].GetValue(this._对象, null);
				if (this._defaultValue == null)
				{
					this.DefaultValue = value;
				}
				this._value = value;
			}
		}
		protected void OnValueChanged()
		{
			if (this._对象 != null)
			{
				PropertyInfo[] propertyInfos = this.PropertyInfos;
				for (int i = 0; i < propertyInfos.Length; i++)
				{
					PropertyInfo propertyInfo = propertyInfos[i];
					propertyInfo.SetValue(this._对象, this._value, null);
				}
			}
		}
		public void ResetValue()
		{
			this.Value = this.DefaultValue;
		}
	}
}
