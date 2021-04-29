using System;
using System.Windows.Markup;

namespace Nuclear.Wpf.Data {

    /// <summary>
    /// Implements a markup extension to declare an inlined object inside XAML markup.
    /// </summary>
    /// <typeparam name="T">The type of the object.</typeparam>
    public class DataExtension<T> : MarkupExtension {

        #region properties

        /// <summary>
        /// Gets the declared object that will be provided.
        /// </summary>
        public T Value { get; }

        #endregion

        #region ctors

        /// <summary>
        /// Creates a new instance of <see cref="DataExtension{T}"/>.
        /// </summary>
        /// <param name="value">The value that will be provided.</param>
        public DataExtension(T value) {
            Value = value;
        }

        #endregion

        #region method

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override Object ProvideValue(IServiceProvider serviceProvider) => Value;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        #endregion

    }

}
