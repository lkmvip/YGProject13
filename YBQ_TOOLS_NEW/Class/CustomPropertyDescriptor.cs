using RxjhTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace YBQ_TOOLS_NEW
{
      internal class CustomPropertyDescriptor: PropertyDescriptor
      {
            private CustomProperty class46_0;

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

            public CustomPropertyDescriptor(CustomProperty customProperty, Attribute[] attrs) : base(customProperty.Name, attrs)
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
