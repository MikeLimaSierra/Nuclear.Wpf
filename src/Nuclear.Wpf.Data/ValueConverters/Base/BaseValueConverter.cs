using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Nuclear.Wpf.Data.ValueConverters.Base {

    /// <summary>
    /// Abstract implementation of a markup extending <see cref="IValueConverter"/>.
    /// </summary>
    public abstract class BaseValueConverter : MarkupExtension, IValueConverter {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public abstract Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture);

        public abstract Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture);

        public override Object ProvideValue(IServiceProvider serviceProvider) => this;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    }
}
