using ns8;
using System;
using System.ComponentModel;

namespace ns0
{
	internal class CustomPropertyDescriptor : PropertyDescriptor
	{
		private ns8.CustomProperty class46_0;

		public override string Category
		{
			get
			{
				return this.class46_0.Category;
			}
		}

		public override Type ComponentType
		{
			get
			{
				return this.class46_0.GetType();
			}
		}

		public object CustomProperty
		{
			get
			{
				return this.class46_0;
			}
		}

		public override string Description
		{
			get
			{
				return this.class46_0.Description;
			}
		}

		public override string DisplayName
		{
			get
			{
				return this.class46_0.Name;
			}
		}

		public override bool IsBrowsable
		{
			get
			{
				return this.class46_0.IsBrowsable;
			}
		}

		public override bool IsReadOnly
		{
			get
			{
				return this.class46_0.IsReadOnly;
			}
		}

		public override Type PropertyType
		{
			get
			{
				return this.class46_0.ValueType;
			}
		}

		public CustomPropertyDescriptor(ns8.CustomProperty customProperty, Attribute[] attrs) : base(customProperty.Name, attrs)
		{
			this.class46_0 = customProperty;
		}

		public override bool CanResetValue(object component)
		{
			return this.class46_0.DefaultValue != null;
		}

		public override object GetValue(object component)
		{
			return this.class46_0.Value;
		}

		public override void ResetValue(object component)
		{
			this.class46_0.ResetValue();
		}

		public override void SetValue(object component, object value)
		{
			this.class46_0.Value = value;
		}

		public override bool ShouldSerializeValue(object component)
		{
			return true;
		}
	}
}