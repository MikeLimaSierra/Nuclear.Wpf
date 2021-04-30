using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Data;

using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that does not convert but calls <see cref="Debugger.Break"/>.
    /// </summary>
    [ValueConversion(typeof(Object), typeof(Object))]
    public class DebugConverter : BaseValueConverter {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) {
            Debugger.Break();
            return value;
        }

        public override Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) {
            Debugger.Break();
            return value;
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    }
}
