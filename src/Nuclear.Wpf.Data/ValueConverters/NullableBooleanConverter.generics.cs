using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Nuclear.Wpf.Data.ValueConverters {

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts <see cref="Nullable{Boolean}"/> to <see cref="Boolean"/>.
    /// </summary>
    [ValueConversion(typeof(Boolean?), typeof(Boolean))]
    public class NullableBooleanToBooleanConverter : NullableBooleanConverter<Boolean> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static Boolean DefaultTrue { get; set; } = true;

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static Boolean DefaultFalse { get; set; } = false;

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static Boolean DefaultNull { get; set; } = false;

        /// <summary>
        /// Creates a new instance of <see cref="NullableBooleanToBooleanConverter"/> defaulting to <see cref="DefaultTrue"/>, <see cref="DefaultFalse"/> and <see cref="DefaultNull"/>.
        /// </summary>
        public NullableBooleanToBooleanConverter() : base(DefaultTrue, DefaultFalse, DefaultNull) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts <see cref="Nullable{Boolean}"/> to <see cref="String"/>.
    /// </summary>
    [ValueConversion(typeof(Boolean?), typeof(String))]
    public class NullableBooleanToStringConverter : NullableBooleanConverter<String> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static String DefaultTrue { get; set; } = "true";

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static String DefaultFalse { get; set; } = "false";

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static String DefaultNull { get; set; } = "null";

        /// <summary>
        /// Creates a new instance of <see cref="NullableBooleanToStringConverter"/> defaulting to <see cref="DefaultTrue"/>, <see cref="DefaultFalse"/> and <see cref="DefaultNull"/>.
        /// </summary>
        public NullableBooleanToStringConverter() : base(DefaultTrue, DefaultFalse, DefaultNull) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts <see cref="Nullable{Boolean}"/> to <see cref="Color"/>.
    /// </summary>
    [ValueConversion(typeof(Boolean?), typeof(Color))]
    public class NullableBooleanToColorConverter : NullableBooleanConverter<Color> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static Color DefaultTrue { get; set; } = Colors.Green;

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static Color DefaultFalse { get; set; } = Colors.Red;

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static Color DefaultNull { get; set; } = Colors.Yellow;

        /// <summary>
        /// Creates a new instance of <see cref="NullableBooleanToColorConverter"/> defaulting to <see cref="DefaultTrue"/>, <see cref="DefaultFalse"/> and <see cref="DefaultNull"/>.
        /// </summary>
        public NullableBooleanToColorConverter() : base(DefaultTrue, DefaultFalse, DefaultNull) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts <see cref="Nullable{Boolean}"/> to <see cref="Brush"/>.
    /// </summary>
    [ValueConversion(typeof(Boolean?), typeof(Brush))]
    public class NullableBooleanToBrushConverter : NullableBooleanConverter<Brush> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static Brush DefaultTrue { get; set; } = Brushes.Green;

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static Brush DefaultFalse { get; set; } = Brushes.Red;

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static Brush DefaultNull { get; set; } = Brushes.Yellow;

        /// <summary>
        /// Creates a new instance of <see cref="NullableBooleanToBrushConverter"/> defaulting to <see cref="DefaultTrue"/>, <see cref="DefaultFalse"/> and <see cref="DefaultNull"/>.
        /// </summary>
        public NullableBooleanToBrushConverter() : base(DefaultTrue, DefaultFalse, DefaultNull) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts <see cref="Nullable{Boolean}"/> to <see cref="Visibility"/>.
    /// </summary>
    [ValueConversion(typeof(Boolean?), typeof(Visibility))]
    public class NullableBooleanToVisibilityConverter : NullableBooleanConverter<Visibility> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static Visibility DefaultTrue { get; set; } = Visibility.Visible;

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static Visibility DefaultFalse { get; set; } = Visibility.Collapsed;

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static Visibility DefaultNull { get; set; } = Visibility.Hidden;

        /// <summary>
        /// Creates a new instance of <see cref="NullableBooleanToVisibilityConverter"/> defaulting to <see cref="DefaultTrue"/>, <see cref="DefaultFalse"/> and <see cref="DefaultNull"/>.
        /// </summary>
        public NullableBooleanToVisibilityConverter() : base(DefaultTrue, DefaultFalse, DefaultNull) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts <see cref="Nullable{Boolean}"/> to <see cref="GridLength"/>.
    /// </summary>
    [ValueConversion(typeof(Boolean?), typeof(GridLength))]
    public class NullableBooleanToGridLengthConverter : NullableBooleanConverter<GridLength> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static GridLength DefaultTrue { get; set; } = new GridLength(1, GridUnitType.Star);

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static GridLength DefaultFalse { get; set; } = GridLength.Auto;

        /// <summary>
        /// The default substitute value for null.
        /// </summary>
        public static GridLength DefaultNull { get; set; } = GridLength.Auto;

        /// <summary>
        /// Creates a new instance of <see cref="NullableBooleanToGridLengthConverter"/> defaulting to <see cref="DefaultTrue"/>, <see cref="DefaultFalse"/> and <see cref="DefaultNull"/>.
        /// </summary>
        public NullableBooleanToGridLengthConverter() : base(DefaultTrue, DefaultFalse, DefaultNull) { }

    }

}
