using RxjhTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

namespace YBQ_TOOLS_NEW
{
      internal class CustomPropertyCollection: List<CustomProperty>, ICustomTypeDescriptor
      {
            public CustomPropertyCollection()
            {
            }

            AttributeCollection ICustomTypeDescriptor.GetAttributes()
            {
                  return TypeDescriptor.GetAttributes(this, true);
            }

            string ICustomTypeDescriptor.GetClassName()
            {
                  return TypeDescriptor.GetClassName(this, true);
            }

            string ICustomTypeDescriptor.GetComponentName()
            {
                  return TypeDescriptor.GetComponentName(this, true);
            }

            TypeConverter ICustomTypeDescriptor.GetConverter()
            {
                  return TypeDescriptor.GetConverter(this, true);
            }

            EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
            {
                  return TypeDescriptor.GetDefaultEvent(this, true);
            }

            PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
            {
                  return TypeDescriptor.GetDefaultProperty(this, true);
            }

            object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
            {
                  return TypeDescriptor.GetEditor(this, editorBaseType, true);
            }

            EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
            {
                  return TypeDescriptor.GetEvents(this, true);
            }

            EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
            {
                  return TypeDescriptor.GetEvents(this, attributes, true);
            }

            PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
            {
                  return TypeDescriptor.GetProperties(this, true);
            }

            PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
            {
                  PropertyDescriptorCollection propertyDescriptorCollections = new PropertyDescriptorCollection(null);
                  foreach (CustomProperty customProperty in this)
                  {
                        List<Attribute> attributes1 = new List<Attribute>()
                        {
                              new CategoryAttribute(customProperty.Category)
                        };
                        if (!customProperty.IsBrowsable)
                        {
                              attributes1.Add(new BrowsableAttribute(customProperty.IsBrowsable));
                        }
                        if (customProperty.IsReadOnly)
                        {
                              attributes1.Add(new ReadOnlyAttribute(customProperty.IsReadOnly));
                        }
                        if (customProperty.EditorType != null)
                        {
                              attributes1.Add(new EditorAttribute(customProperty.EditorType, typeof(UITypeEditor)));
                        }
                        if (customProperty.ConverterType)
                        {
                              attributes1.Add(new TypeConverterAttribute(typeof(SpellingOptionsConverter)));
                        }
                        propertyDescriptorCollections.Add(new CustomPropertyDescriptor(customProperty, attributes1.ToArray()));
                  }
                  return propertyDescriptorCollections;
            }

            object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
            {
                  return this;
            }
      }
}
