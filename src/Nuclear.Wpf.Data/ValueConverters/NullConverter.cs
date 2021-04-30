using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts null references to <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The conversion result type.</typeparam>
    public class NullConverter<T> : BaseValueConverter {

        #region properties

        /// <summary>
        /// Gets or sets the substitute value for null.
        /// </summary>
        public T Null { get; set; }

        /// <summary>
        /// Gets or sets the substitute value for non-null.
        /// </summary>
        public T NotNull { get; set; }

        #endregion

        #region ctors

        /// <summary>
        /// Creates a new instance of <see cref="NullConverter{T}"/>.
        /// </summary>
        /// <param name="null">The substitute value for null.</param>
        /// <param name="notNull">The substitute value for non-null.</param>
        public NullConverter(T @null, T notNull) {
            Null = @null;
            NotNull = notNull;
        }

        #endregion

        #region methods

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) => value == null ? Null : NotNull;

        public override Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) => DependencyProperty.UnsetValue;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        #endregion

    }
}
