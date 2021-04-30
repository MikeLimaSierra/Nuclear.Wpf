using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Nuclear.Wpf.Data.MultiValueConverters.Base {

    /// <summary>
    /// Abstract implementation of a markup extending <see cref="IMultiValueConverter"/>.
    /// </summary>
    public abstract class BaseMultiValueConverter : MarkupExtension, IMultiValueConverter {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public abstract Object Convert(Object[] values, Type targetType, Object parameter, CultureInfo culture);

        public abstract Object[] ConvertBack(Object value, Type[] targetTypes, Object parameter, CultureInfo culture);

        public override Object ProvideValue(IServiceProvider serviceProvider) => this;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    }
}
