using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts <see cref="Nullable{Boolean}"/> to <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The conversion result type.</typeparam>
    public class NullableBooleanConverter<T> : BaseValueConverter {

        #region properties

        /// <summary>
        /// Gets or sets the substitute value for true.
        /// </summary>
        public T True { get; set; }

        /// <summary>
        /// Gets or sets the substitute value for false.
        /// </summary>
        public T False { get; set; }

        /// <summary>
        /// Gets or sets the substitute value for null.
        /// </summary>
        public T Null { get; set; }

        #endregion

        #region ctors

        /// <summary>
        /// Creates a new instance of <see cref="NullableBooleanConverter{T}"/>.
        /// </summary>
        /// <param name="true">The substitute value for true.</param>
        /// <param name="false">The substitute value for false.</param>
        /// <param name="null">The substitute value for null.</param>
        public NullableBooleanConverter(T @true, T @false, T @null) {
            True = @true;
            False = @false;
            Null = @null;
        }

        #endregion

        #region methods

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
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
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        #endregion
    }
}
