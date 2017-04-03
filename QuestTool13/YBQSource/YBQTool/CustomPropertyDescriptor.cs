using System;
using System.ComponentModel;
namespace RxjhTool
{
	public class CustomPropertyDescriptor : PropertyDescriptor
	{
		private CustomProperty _customProperty;
		public override string Category
		{
			get
			{
				return this._customProperty.Category;
			}
		}
		public override Type ComponentType
		{
			get
			{
				return this._customProperty.GetType();
			}
		}
		public object CustomProperty
		{
			get
			{
				return this._customProperty;
			}
		}
		public override string Description
		{
			get
			{
				return this._customProperty.Description;
			}
		}
		public override string DisplayName
		{
			get
			{
				return this._customProperty.Name;
			}
		}
		public override bool IsBrowsable
		{
			get
			{
				return this._customProperty.IsBrowsable;
			}
		}
		public override bool IsReadOnly
		{
			get
			{
				return this._customProperty.IsReadOnly;
			}
		}
		public override Type PropertyType
		{
			get
			{
				return this._customProperty.ValueType;
			}
		}
		public CustomPropertyDescriptor(CustomProperty customProperty, Attribute[] attrs) : base(customProperty.Name, attrs)
		{
			this._customProperty = customProperty;
		}
		public override bool CanResetValue(object component)
		{
			return this._customProperty.DefaultValue != null;
		}
		public override object GetValue(object component)
		{
			return this._customProperty.Value;
		}
		public override void ResetValue(object component)
		{
			this._customProperty.ResetValue();
		}
		public override void SetValue(object component, object value)
		{
			this._customProperty.Value = value;
		}
		public override bool ShouldSerializeValue(object component)
		{
			return true;
		}
	}
}
