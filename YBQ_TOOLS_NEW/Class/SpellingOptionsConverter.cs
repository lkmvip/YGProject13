using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;


namespace YBQ_TOOLS_NEW
{
      internal class SpellingOptionsConverter: ExpandableObjectConverter
      {
            public SpellingOptionsConverter()
            {
            }

            public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
                  if (sourceType == typeof(string))
                  {
                        return true;
                  }
                  return base.CanConvertFrom(context, sourceType);
            }

            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                  if (destinationType == typeof(MAP_CLASS))
                  {
                        return true;
                  }
                  return base.CanConvertTo(context, destinationType);
            }

            public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
            {
                  object mAPCLAss;
                  if (value is string)
                  {
                        try
                        {
                              string str = (string)value;
                              int num = str.IndexOf(':');
                              int num1 = str.IndexOf(',');
                              if (num == -1 || num1 == -1)
                              {
                                    return base.ConvertFrom(context, culture, value);
                              }
                              else
                              {
                                    str.Substring(num + 1, num1 - num - 1);
                                    num = str.IndexOf(':', num1 + 1);
                                    num1 = str.IndexOf(',', num1 + 1);
                                    str.Substring(num + 1, num1 - num - 1);
                                    num = str.IndexOf(':', num1 + 1);
                                    str.Substring(num + 1);
                                    mAPCLAss = new MAP_CLASS();
                              }
                        }
                        catch
                        {
                              throw new ArgumentException(string.Concat("you can not“", (string)value, "”Convert to SpellingOptions type"));
                        }
                        return mAPCLAss;
                  }
                  return base.ConvertFrom(context, culture, value);
            }

            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
            {
                  if (destinationType != typeof(string) || !(value is MAP_CLASS))
                  {
                        return base.ConvertTo(context, culture, value, destinationType);
                  }
                  MAP_CLASS mAPCLAss = (MAP_CLASS)value;
                  return string.Concat(new object[] { "MAP ID:", mAPCLAss.MapID, "，X: ", mAPCLAss.CoordX, "，Y: ", mAPCLAss.CoordY });
            }
      }
}
