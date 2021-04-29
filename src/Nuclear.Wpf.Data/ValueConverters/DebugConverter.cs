using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Data;

using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {

    [ValueConversion(typeof(Object), typeof(Object))]
    public class DebugConverter : BaseValueConverter {

        public override Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) {
            Debugger.Break();
            return value;
        }

        public override Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) {
            Debugger.Break();
            return value;
        }

    }
}
