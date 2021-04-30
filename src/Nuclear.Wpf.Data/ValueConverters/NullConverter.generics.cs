using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Nuclear.Wpf.Data.ValueConverters {

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts null references to <see cref="Boolean"/>.
    /// </summary>
    [ValueConversion(typeof(Object), typeof(Boolean))]
    public class NullToBooleanConverter : NullConverter<Boolean> {

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static Boolean DefaultNull { get; set; } = false;

        /// <summary>
        /// The default substitute value for non-null.
        /// </summary>
        public static Boolean DefaultNotNull { get; set; } = true;

        /// <summary>
        /// Creates a new instance of <see cref="NullToBooleanConverter"/> defaulting to <see cref="DefaultNull"/> and <see cref="DefaultNotNull"/>.
        /// </summary>
        public NullToBooleanConverter() : base(DefaultNull, DefaultNotNull) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts null references to <see cref="String"/>.
    /// </summary>
    [ValueConversion(typeof(Object), typeof(String))]
    public class NullToStringConverter : NullConverter<String> {

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static String DefaultNull { get; set; } = "null";

        /// <summary>
        /// The default substitute value for non-null.
        /// </summary>
        public static String DefaultNotNull { get; set; } = "not null";

        /// <summary>
        /// Creates a new instance of <see cref="NullToStringConverter"/> defaulting to <see cref="DefaultNull"/> and <see cref="DefaultNotNull"/>.
        /// </summary>
        public NullToStringConverter() : base(DefaultNull, DefaultNotNull) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts null references to <see cref="Color"/>.
    /// </summary>
    [ValueConversion(typeof(Object), typeof(Color))]
    public class NullToColorConverter : NullConverter<Color> {

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static Color DefaultNull { get; set; } = Colors.Red;

        /// <summary>
        /// The default substitute value for non-null.
        /// </summary>
        public static Color DefaultNotNull { get; set; } = Colors.Green;

        /// <summary>
        /// Creates a new instance of <see cref="NullToColorConverter"/> defaulting to <see cref="DefaultNull"/> and <see cref="DefaultNotNull"/>.
        /// </summary>
        public NullToColorConverter() : base(DefaultNull, DefaultNotNull) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts null references to <see cref="Brush"/>.
    /// </summary>
    [ValueConversion(typeof(Object), typeof(Brush))]
    public class NullToBrushConverter : NullConverter<Brush> {

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static Brush DefaultNull { get; set; } = Brushes.Red;

        /// <summary>
        /// The default substitute value for non-null.
        /// </summary>
        public static Brush DefaultNotNull { get; set; } = Brushes.Green;

        /// <summary>
        /// Creates a new instance of <see cref="NullToBrushConverter"/> defaulting to <see cref="DefaultNull"/> and <see cref="DefaultNotNull"/>.
        /// </summary>
        public NullToBrushConverter() : base(DefaultNull, DefaultNotNull) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts null references to <see cref="Visibility"/>.
    /// </summary>
    [ValueConversion(typeof(Object), typeof(Visibility))]
    public class NullToVisibilityConverter : NullConverter<Visibility> {

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static Visibility DefaultNull { get; set; } = Visibility.Collapsed;

        /// <summary>
        /// The default substitute value for non-null.
        /// </summary>
        public static Visibility DefaultNotNull { get; set; } = Visibility.Visible;

        /// <summary>
        /// Creates a new instance of <see cref="NullToVisibilityConverter"/> defaulting to <see cref="DefaultNull"/> and <see cref="DefaultNotNull"/>.
        /// </summary>
        public NullToVisibilityConverter() : base(DefaultNull, DefaultNotNull) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts null references to <see cref="GridLength"/>.
    /// </summary>
    [ValueConversion(typeof(Object), typeof(GridLength))]
    public class NullToGridLengthConverter : NullConverter<GridLength> {

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static GridLength DefaultNull { get; set; } = GridLength.Auto;

        /// <summary>
        /// The default substitute value for non-null.
        /// </summary>
        public static GridLength DefaultNotNull { get; set; } = new GridLength(1, GridUnitType.Star);

        /// <summary>
        /// Creates a new instance of <see cref="NullToGridLengthConverter"/> defaulting to <see cref="DefaultNull"/> and <see cref="DefaultNotNull"/>.
        /// </summary>
        public NullToGridLengthConverter() : base(DefaultNull, DefaultNotNull) { }

    }

}
