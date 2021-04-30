using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Nuclear.Wpf.Data.ValueConverters {

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts a <see cref="String"/> to <see cref="Boolean"/>.
    /// </summary>
    [ValueConversion(typeof(String), typeof(Boolean))]
    public class StringToBooleanConverter : StringConverter<Boolean> {

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static Boolean DefaultNull { get; set; } = false;

        /// <summary>
        /// The default substitute value for <see cref="String.Empty"/>.
        /// </summary>
        public static Boolean DefaultEmpty { get; set; } = false;

        /// <summary>
        /// The default substitute value for strings containing only whitespaces.
        /// </summary>
        public static Boolean DefaultWhiteSpace { get; set; } = false;

        /// <summary>
        /// The default substitute value for strings with non-whitespace content.
        /// </summary>
        public static Boolean DefaultHasValue { get; set; } = true;

        /// <summary>
        /// Creates a new instance of <see cref="StringToBooleanConverter"/> defaulting to <see cref="DefaultNull"/>, <see cref="DefaultEmpty"/>, <see cref="DefaultWhiteSpace"/> and <see cref="DefaultHasValue"/>.
        /// </summary>
        public StringToBooleanConverter() : base(DefaultNull, DefaultEmpty, DefaultWhiteSpace, DefaultHasValue) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts a <see cref="String"/> to <see cref="String"/>.
    /// </summary>
    [ValueConversion(typeof(String), typeof(String))]
    public class StringToStringConverter : StringConverter<String> {

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static String DefaultNull { get; set; } = "null";

        /// <summary>
        /// The default substitute value for <see cref="String.Empty"/>.
        /// </summary>
        public static String DefaultEmpty { get; set; } = "empty";

        /// <summary>
        /// The default substitute value for strings containing only whitespaces.
        /// </summary>
        public static String DefaultWhiteSpace { get; set; } = "white-space";

        /// <summary>
        /// The default substitute value for strings with non-whitespace content.
        /// </summary>
        public static String DefaultHasValue { get; set; } = "has value";

        /// <summary>
        /// Creates a new instance of <see cref="StringToStringConverter"/> defaulting to <see cref="DefaultNull"/>, <see cref="DefaultEmpty"/>, <see cref="DefaultWhiteSpace"/> and <see cref="DefaultHasValue"/>.
        /// </summary>
        public StringToStringConverter() : base(DefaultNull, DefaultEmpty, DefaultWhiteSpace, DefaultHasValue) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts a <see cref="String"/> to <see cref="Color"/>.
    /// </summary>
    [ValueConversion(typeof(String), typeof(Color))]
    public class StringToColorConverter : StringConverter<Color> {

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static Color DefaultNull { get; set; } = Colors.Red;

        /// <summary>
        /// The default substitute value for <see cref="String.Empty"/>.
        /// </summary>
        public static Color DefaultEmpty { get; set; } = Colors.Orange;

        /// <summary>
        /// The default substitute value for strings containing only whitespaces.
        /// </summary>
        public static Color DefaultWhiteSpace { get; set; } = Colors.Yellow;

        /// <summary>
        /// The default substitute value for strings with non-whitespace content.
        /// </summary>
        public static Color DefaultHasValue { get; set; } = Colors.Green;

        /// <summary>
        /// Creates a new instance of <see cref="StringToColorConverter"/> defaulting to <see cref="DefaultNull"/>, <see cref="DefaultEmpty"/>, <see cref="DefaultWhiteSpace"/> and <see cref="DefaultHasValue"/>.
        /// </summary>
        public StringToColorConverter() : base(DefaultNull, DefaultEmpty, DefaultWhiteSpace, DefaultHasValue) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts a <see cref="String"/> to <see cref="Brush"/>.
    /// </summary>
    [ValueConversion(typeof(String), typeof(Brush))]
    public class StringToBrushConverter : StringConverter<Brush> {

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static Brush DefaultNull { get; set; } = Brushes.Red;

        /// <summary>
        /// The default substitute value for <see cref="String.Empty"/>.
        /// </summary>
        public static Brush DefaultEmpty { get; set; } = Brushes.Orange;

        /// <summary>
        /// The default substitute value for strings containing only whitespaces.
        /// </summary>
        public static Brush DefaultWhiteSpace { get; set; } = Brushes.Yellow;

        /// <summary>
        /// The default substitute value for strings with non-whitespace content.
        /// </summary>
        public static Brush DefaultHasValue { get; set; } = Brushes.Green;

        /// <summary>
        /// Creates a new instance of <see cref="StringToBrushConverter"/> defaulting to <see cref="DefaultNull"/>, <see cref="DefaultEmpty"/>, <see cref="DefaultWhiteSpace"/> and <see cref="DefaultHasValue"/>.
        /// </summary>
        public StringToBrushConverter() : base(DefaultNull, DefaultEmpty, DefaultWhiteSpace, DefaultHasValue) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts a <see cref="String"/> to <see cref="Visibility"/>.
    /// </summary>
    [ValueConversion(typeof(String), typeof(Visibility))]
    public class StringToVisibilityConverter : StringConverter<Visibility> {

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static Visibility DefaultNull { get; set; } = Visibility.Collapsed;

        /// <summary>
        /// The default substitute value for <see cref="String.Empty"/>.
        /// </summary>
        public static Visibility DefaultEmpty { get; set; } = Visibility.Collapsed;

        /// <summary>
        /// The default substitute value for strings containing only whitespaces.
        /// </summary>
        public static Visibility DefaultWhiteSpace { get; set; } = Visibility.Collapsed;

        /// <summary>
        /// The default substitute value for strings with non-whitespace content.
        /// </summary>
        public static Visibility DefaultHasValue { get; set; } = Visibility.Visible;

        /// <summary>
        /// Creates a new instance of <see cref="StringToVisibilityConverter"/> defaulting to <see cref="DefaultNull"/>, <see cref="DefaultEmpty"/>, <see cref="DefaultWhiteSpace"/> and <see cref="DefaultHasValue"/>.
        /// </summary>
        public StringToVisibilityConverter() : base(DefaultNull, DefaultEmpty, DefaultWhiteSpace, DefaultHasValue) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts a <see cref="String"/> to <see cref="GridLength"/>.
    /// </summary>
    [ValueConversion(typeof(String), typeof(GridLength))]
    public class StringToGridLengthConverter : StringConverter<GridLength> {

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static GridLength DefaultNull { get; set; } = GridLength.Auto;

        /// <summary>
        /// The default substitute value for <see cref="String.Empty"/>.
        /// </summary>
        public static GridLength DefaultEmpty { get; set; } = GridLength.Auto;

        /// <summary>
        /// The default substitute value for strings containing only whitespaces.
        /// </summary>
        public static GridLength DefaultWhiteSpace { get; set; } = GridLength.Auto;

        /// <summary>
        /// The default substitute value for strings with non-whitespace content.
        /// </summary>
        public static GridLength DefaultHasValue { get; set; } = new GridLength(1, GridUnitType.Star);

        /// <summary>
        /// Creates a new instance of <see cref="StringToGridLengthConverter"/> defaulting to <see cref="DefaultNull"/>, <see cref="DefaultEmpty"/>, <see cref="DefaultWhiteSpace"/> and <see cref="DefaultHasValue"/>.
        /// </summary>
        public StringToGridLengthConverter() : base(DefaultNull, DefaultEmpty, DefaultWhiteSpace, DefaultHasValue) { }

    }

}
