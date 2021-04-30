using System;
using System.Globalization;
using System.Windows.Data;

using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that does not convert.
    /// </summary>
    [ValueConversion(typeof(Object), typeof(Object))]
    public class NoOpConverter : BaseValueConverter {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) => value;

        public override Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) => value;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    }
}
