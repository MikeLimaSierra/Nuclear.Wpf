using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts a <see cref="String"/> to <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The conversion result type.</typeparam>
    public class StringConverter<T> : BaseValueConverter {

        #region properties

        /// <summary>
        /// Gets or sets the substitute value for null.
        /// </summary>
        public T Null { get; set; }

        /// <summary>
        /// Gets or sets the substitute value for <see cref="String.Empty"/>.
        /// </summary>
        public T Empty { get; set; }

        /// <summary>
        /// Gets or sets the substitute value for strings containing only whitespaces.
        /// </summary>
        public T WhiteSpace { get; set; }

        /// <summary>
        /// Gets or sets the substitute value for strings with non-whitespace content.
        /// </summary>
        public T HasValue { get; set; }

        #endregion

        #region ctors

        /// <summary>
        /// Creates a new instance of <see cref="StringConverter{T}"/>.
        /// </summary>
        /// <param name="null">The substitute value for null.</param>
        /// <param name="empty">The substitute value for <see cref="String.Empty"/>.</param>
        /// <param name="whiteSpace">The substitute value for strings containing only whitespaces.</param>
        /// <param name="hasValue">The substitute value for strings with non-whitespace content.</param>
        public StringConverter(T @null, T empty, T whiteSpace, T hasValue) {
            Null = @null;
            Empty = empty;
            WhiteSpace = whiteSpace;
            HasValue = hasValue;
        }

        #endregion

        #region methods

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
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
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        #endregion

    }
}
