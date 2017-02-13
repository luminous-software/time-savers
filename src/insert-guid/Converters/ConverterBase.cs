using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Luminous.TimeSavers.InsertGuid.Converters
{
    public abstract class ConverterBase : MarkupExtension, IValueConverter
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return (object)this;
        }

        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo cultureInfo);

        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo cultureInfo);
    }
}