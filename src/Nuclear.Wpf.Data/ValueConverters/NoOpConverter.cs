using System;
using System.Globalization;
using System.Windows.Data;

using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {

    [ValueConversion(typeof(Object), typeof(Object))]
    public class NoOpConverter : BaseValueConverter {

        public override Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) => value;

        public override Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) => value;

    }
}
