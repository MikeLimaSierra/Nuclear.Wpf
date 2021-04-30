using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that chains a range of conversions.
    /// </summary>
    [ValueConversion(typeof(Object), typeof(Object))]
    public partial class Chain : BaseValueConverter {

        #region properties

        /// <summary>
        /// Gets the stored conversion links.
        /// </summary>
        public ICollection<Link> Links { get; } = new Collection<Link>();

        #endregion

        #region ctors

        /// <summary>
        /// Creates a new instance of <see cref="Chain"/>.
        /// </summary>
        /// <param name="links">The initial range of links.</param>
        public Chain(params Link[] links) {
            Array.ForEach(links, _ => Links.Add(_));
        }

        /// <summary>
        /// Creates a new instance of <see cref="Chain"/>.
        /// </summary>
        /// <param name="l1">The first conversion link.</param>
        public Chain(Link l1) : this(new Link[] { l1 }) { }

        /// <summary>
        /// Creates a new instance of <see cref="Chain"/>.
        /// </summary>
        /// <param name="l1">The first conversion link.</param>
        /// <param name="l2">The second conversion link.</param>
        public Chain(Link l1, Link l2) : this(new Link[] { l1, l2 }) { }

        /// <summary>
        /// Creates a new instance of <see cref="Chain"/>.
        /// </summary>
        /// <param name="l1">The first conversion link.</param>
        /// <param name="l2">The second conversion link.</param>
        /// <param name="l3">The third conversion link.</param>
        public Chain(Link l1, Link l2, Link l3) : this(new Link[] { l1, l2, l3 }) { }

        /// <summary>
        /// Creates a new instance of <see cref="Chain"/>.
        /// </summary>
        /// <param name="l1">The first conversion link.</param>
        /// <param name="l2">The second conversion link.</param>
        /// <param name="l3">The third conversion link.</param>
        /// <param name="l4">The fourth conversion link.</param>
        public Chain(Link l1, Link l2, Link l3, Link l4) : this(new Link[] { l1, l2, l3, l4 }) { }

        /// <summary>
        /// Creates a new instance of <see cref="Chain"/>.
        /// </summary>
        /// <param name="l1">The first conversion link.</param>
        /// <param name="l2">The second conversion link.</param>
        /// <param name="l3">The third conversion link.</param>
        /// <param name="l4">The fourth conversion link.</param>
        /// <param name="l5">The fifth conversion link.</param>
        public Chain(Link l1, Link l2, Link l3, Link l4, Link l5) : this(new Link[] { l1, l2, l3, l4, l5 }) { }

        /// <summary>
        /// Creates a new instance of <see cref="Chain"/>.
        /// </summary>
        /// <param name="l1">The first conversion link.</param>
        /// <param name="l2">The second conversion link.</param>
        /// <param name="l3">The third conversion link.</param>
        /// <param name="l4">The fourth conversion link.</param>
        /// <param name="l5">The fifth conversion link.</param>
        /// <param name="l6">The sixth conversion link.</param>
        public Chain(Link l1, Link l2, Link l3, Link l4, Link l5, Link l6) : this(new Link[] { l1, l2, l3, l4, l5, l6 }) { }

        /// <summary>
        /// Creates a new instance of <see cref="Chain"/>.
        /// </summary>
        /// <param name="l1">The first conversion link.</param>
        /// <param name="l2">The second conversion link.</param>
        /// <param name="l3">The third conversion link.</param>
        /// <param name="l4">The fourth conversion link.</param>
        /// <param name="l5">The fifth conversion link.</param>
        /// <param name="l6">The sixth conversion link.</param>
        /// <param name="l7">The seventh conversion link.</param>
        public Chain(Link l1, Link l2, Link l3, Link l4, Link l5, Link l6, Link l7) : this(new Link[] { l1, l2, l3, l4, l5, l6, l7 }) { }

        /// <summary>
        /// Creates a new instance of <see cref="Chain"/>.
        /// </summary>
        /// <param name="l1">The first conversion link.</param>
        /// <param name="l2">The second conversion link.</param>
        /// <param name="l3">The third conversion link.</param>
        /// <param name="l4">The fourth conversion link.</param>
        /// <param name="l5">The fifth conversion link.</param>
        /// <param name="l6">The sixth conversion link.</param>
        /// <param name="l7">The seventh conversion link.</param>
        /// <param name="l8">The eigth conversion link.</param>
        public Chain(Link l1, Link l2, Link l3, Link l4, Link l5, Link l6, Link l7, Link l8) : this(new Link[] { l1, l2, l3, l4, l5, l6, l7, l8 }) { }

        #endregion

        #region methods

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) {
            Object returnObject = value;

            foreach(Link link in Links) {
                returnObject = link.Converter.Convert(returnObject, targetType, link.Parameter, link.Culture);
            }

            return returnObject;
        }

        public override Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) {
            Object returnObject = value;

            foreach(Link link in Links.Reverse()) {
                returnObject = link.Converter.ConvertBack(returnObject, targetType, link.Parameter, link.Culture);
            }

            return returnObject;
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        #endregion

    }
}
