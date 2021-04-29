using System;
using System.Globalization;
using System.Windows;

using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {
    public class StringConverter<T> : BaseValueConverter {

        #region properties

        public T Null { get; set; }

        public T Empty { get; set; }

        public T WhiteSpace { get; set; }

        public T HasValue { get; set; }

        #endregion

        #region ctors

        public StringConverter(T @null, T empty, T whiteSpace, T hasValue) {
            Null = @null;
            Empty = empty;
            WhiteSpace = whiteSpace;
            HasValue = hasValue;
        }

        #endregion

        #region methods

        public override Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) {
            if(value == null) {
                return Null;

            } else if(value is String s) {
                if(String.IsNullOrEmpty(s)) { return Empty; }

                if(String.IsNullOrWhiteSpace(s)) { return WhiteSpace; }

                return HasValue;
            }

            return DependencyProperty.UnsetValue;
        }

        public override Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) => DependencyProperty.UnsetValue;

        #endregion

    }
}
