using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Nuclear.Wpf.Data.ValueConverters {

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts <see cref="Boolean"/> to <see cref="Boolean"/>.
    /// </summary>
    [ValueConversion(typeof(Boolean), typeof(Boolean))]
    public class InvertedBooleanConverter : BooleanConverter<Boolean> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static Boolean DefaultTrue { get; set; } = false;

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static Boolean DefaultFalse { get; set; } = true;

        /// <summary>
        /// Creates a new instance of <see cref="InvertedBooleanConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public InvertedBooleanConverter() : base(DefaultTrue, DefaultFalse) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts <see cref="Boolean"/> to <see cref="String"/>.
    /// </summary>
    [ValueConversion(typeof(Boolean), typeof(String))]
    public class BooleanToStringConverter : BooleanConverter<String> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static String DefaultTrue { get; set; } = "true";

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static String DefaultFalse { get; set; } = "false";

        /// <summary>
        /// Creates a new instance of <see cref="BooleanToStringConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public BooleanToStringConverter() : base(DefaultTrue, DefaultFalse) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts <see cref="Boolean"/> to <see cref="Color"/>.
    /// </summary>
    [ValueConversion(typeof(Boolean), typeof(Color))]
    public class BooleanToColorConverter : BooleanConverter<Color> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static Color DefaultTrue { get; set; } = Colors.Green;

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static Color DefaultFalse { get; set; } = Colors.Red;

        /// <summary>
        /// Creates a new instance of <see cref="BooleanToColorConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public BooleanToColorConverter() : base(DefaultTrue, DefaultFalse) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts <see cref="Boolean"/> to <see cref="Brush"/>.
    /// </summary>
    [ValueConversion(typeof(Boolean), typeof(Brush))]
    public class BooleanToBrushConverter : BooleanConverter<Brush> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static Brush DefaultTrue { get; set; } = Brushes.Green;

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static Brush DefaultFalse { get; set; } = Brushes.Red;

        /// <summary>
        /// Creates a new instance of <see cref="BooleanToBrushConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public BooleanToBrushConverter() : base(DefaultTrue, DefaultFalse) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts <see cref="Boolean"/> to <see cref="Visibility"/>.
    /// </summary>
    [ValueConversion(typeof(Boolean), typeof(Visibility))]
    public class BooleanToVisibilityConverter : BooleanConverter<Visibility> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static Visibility DefaultTrue { get; set; } = Visibility.Visible;

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static Visibility DefaultFalse { get; set; } = Visibility.Collapsed;

        /// <summary>
        /// Creates a new instance of <see cref="BooleanToVisibilityConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public BooleanToVisibilityConverter() : base(DefaultTrue, DefaultFalse) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IValueConverter"/> that converts <see cref="Boolean"/> to <see cref="GridLength"/>.
    /// </summary>
    [ValueConversion(typeof(Boolean), typeof(GridLength))]
    public class BooleanToGridLengthConverter : BooleanConverter<GridLength> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static GridLength DefaultTrue { get; set; } = new GridLength(1, GridUnitType.Star);

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static GridLength DefaultFalse { get; set; } = GridLength.Auto;

        /// <summary>
        /// Creates a new instance of <see cref="BooleanToGridLengthConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public BooleanToGridLengthConverter() : base(DefaultTrue, DefaultFalse) { }

    }

}
