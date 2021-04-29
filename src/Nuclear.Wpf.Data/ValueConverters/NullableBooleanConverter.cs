﻿using System;
using System.Globalization;
using System.Windows;

using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {
    public class NullableBooleanConverter<T> : BaseValueConverter {

        #region properties

        public T True { get; set; }

        public T False { get; set; }

        public T Null { get; set; }

        #endregion

        #region ctors

        public NullableBooleanConverter(T @true, T @false, T @null) {
            True = @true;
            False = @false;
            Null = @null;
        }

        #endregion

        #region methods

        public override Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) {
            if(value == null) { return Null; }

            if(value is Boolean boolean) {
                return boolean ? True : False;
            }

            return DependencyProperty.UnsetValue;
        }

        public override Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) {
            if(value != null && value is T t) {
                if(True.Equals(t)) { return true; }
                if(False.Equals(t)) { return false; }
                if(Null.Equals(t)) { return null; }
            }

            return DependencyProperty.UnsetValue;
        }

        #endregion
    }
}
