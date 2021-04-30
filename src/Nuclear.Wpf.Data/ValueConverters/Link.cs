using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Nuclear.Wpf.Data.ValueConverters {

    /// <summary>
    /// Implementation of a conversion link that is used in a conversion <see cref="Chain"/>.
    /// </summary>
    public class Link : MarkupExtension {

        #region properties

        /// <summary>
        /// Gets or sets the <see cref="IValueConverter"/> instance.
        /// </summary>
        public IValueConverter Converter { get; set; }

        /// <summary>
        /// Gets or sets the parameter for the conversion.
        /// </summary>
        public Object Parameter { get; set; }

        /// <summary>
        /// Gets or sets the used <see cref="CultureInfo"/> for the conversion.
        /// </summary>
        public CultureInfo Culture { get; set; }

        #endregion

        #region methods

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override Object ProvideValue(IServiceProvider serviceProvider) => this;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        #endregion

    }
}
