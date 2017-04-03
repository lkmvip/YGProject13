using System;
using System.ComponentModel;
using System.Globalization;
namespace RxjhTool
{
	public class SpellingOptionsConverter : ExpandableObjectConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(PositionClass) || base.CanConvertTo(context, destinationType);
		}
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value is string)
			{
				try
				{
					string text = (string)value;
					int num = text.IndexOf(':');
					int num2 = text.IndexOf(',');
					if (num != -1 && num2 != -1)
					{
						text.Substring(num + 1, num2 - num - 1);
						num = text.IndexOf(':', num2 + 1);
						num2 = text.IndexOf(',', num2 + 1);
						text.Substring(num + 1, num2 - num - 1);
						num = text.IndexOf(':', num2 + 1);
						text.Substring(num + 1);
						return new PositionClass();
					}
				}
				catch
				{
					throw new ArgumentException("无法将“" + (string)value + "”转换为 SpellingOptions 类型");
				}
			}
			return base.ConvertFrom(context, culture, value);
		}
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object result;
			if (destinationType == typeof(string) && value is PositionClass)
			{
				PositionClass 坐标类 = (PositionClass)value;
				result = string.Concat(new object[]
				{
					"Map ID:",
					坐标类.MapID,
					"，좌표 X: ",
					坐标类.CoordsX,
					"，좌표 Y: ",
					坐标类.CoordsY
				});
			}
			else
			{
				result = base.ConvertTo(context, culture, value, destinationType);
			}
			return result;
		}
	}
}
