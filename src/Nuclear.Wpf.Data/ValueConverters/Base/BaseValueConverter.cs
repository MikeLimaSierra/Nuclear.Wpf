using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Nuclear.Wpf.Data.ValueConverters.Base {
    public abstract class BaseValueConverter : MarkupExtension, IValueConverter {

        public abstract Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture);

        public abstract Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture);

        public override Object ProvideValue(IServiceProvider serviceProvider) => this;

    }
}
