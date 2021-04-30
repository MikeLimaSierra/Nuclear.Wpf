using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts <see cref="Boolean"/> to <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The conversion result type.</typeparam>
    public class BooleanConverter<T> : BaseValueConverter {

        #region properties

        /// <summary>
        /// Gets or sets the substitute value for true.
        /// </summary>
        public T True { get; set; }

        /// <summary>
        /// Gets or sets the substitute value for false.
        /// </summary>
        public T False { get; set; }

        #endregion

        #region ctors

        /// <summary>
        /// Creates a new instance of <see cref="BooleanConverter{T}"/>.
        /// </summary>
        /// <param name="true">The substitute value for true.</param>
        /// <param name="false">The substitute value for false.</param>
        public BooleanConverter(T @true, T @false) {
            True = @true;
            False = @false;
        }

        #endregion

        #region methods

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) {
            if(value != null && value is Boolean boolean) {
                return boolean ? True : False;
            }

            return DependencyProperty.UnsetValue;
        }

        public override Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) {
            if(value != null && value is T t) {
                if(True.Equals(t)) { return true; }
                if(False.Equals(t)) { return false; }
            }

            return DependencyProperty.UnsetValue;
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        #endregion

    }
}
