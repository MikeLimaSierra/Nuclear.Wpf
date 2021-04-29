using System;
using System.Globalization;
using System.Windows;

using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {
    public class NullConverter<T> : BaseValueConverter {

        #region properties

        public T Null { get; set; }

        public T NotNull { get; set; }

        #endregion

        #region ctors

        public NullConverter(T @null, T notNull) {
            Null = @null;
            NotNull = notNull;
        }

        #endregion

        #region methods

        public override Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) => value == null ? Null : NotNull;

        public override Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) => DependencyProperty.UnsetValue;

        #endregion

    }
}
