using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Nuclear.Wpf.Data.ValueConverters {

    [ValueConversion(typeof(Boolean), typeof(Boolean))]
    public class InvertedBooleanConverter : BooleanConverter<Boolean> {

        public static Boolean DefaultTrue { get; set; } = false;

        public static Boolean DefaultFalse { get; set; } = true;

        public InvertedBooleanConverter() : base(DefaultTrue, DefaultFalse) { }

    }

    [ValueConversion(typeof(Boolean), typeof(String))]
    public class BooleanToStringConverter : BooleanConverter<String> {

        public static String DefaultTrue { get; set; } = "true";

        public static String DefaultFalse { get; set; } = "false";

        public BooleanToStringConverter() : base(DefaultTrue, DefaultFalse) { }

    }

    [ValueConversion(typeof(Boolean), typeof(Color))]
    public class BooleanToColorConverter : BooleanConverter<Color> {

        public static Color DefaultTrue { get; set; } = Colors.Green;

        public static Color DefaultFalse { get; set; } = Colors.Red;

        public BooleanToColorConverter() : base(DefaultTrue, DefaultFalse) { }

    }

    [ValueConversion(typeof(Boolean), typeof(Brush))]
    public class BooleanToBrushConverter : BooleanConverter<Brush> {

        public static Brush DefaultTrue { get; set; } = Brushes.Green;

        public static Brush DefaultFalse { get; set; } = Brushes.Red;

        public BooleanToBrushConverter() : base(DefaultTrue, DefaultFalse) { }

    }

    [ValueConversion(typeof(Boolean), typeof(Visibility))]
    public class BooleanToVisibilityConverter : BooleanConverter<Visibility> {

        public static Visibility DefaultTrue { get; set; } = Visibility.Visible;

        public static Visibility DefaultFalse { get; set; } = Visibility.Collapsed;

        public BooleanToVisibilityConverter() : base(DefaultTrue, DefaultFalse) { }

    }

    [ValueConversion(typeof(Boolean), typeof(GridLength))]
    public class BooleanToGridLengthConverter : BooleanConverter<GridLength> {

        public static GridLength DefaultTrue { get; set; } = new GridLength(1, GridUnitType.Star);

        public static GridLength DefaultFalse { get; set; } = GridLength.Auto;

        public BooleanToGridLengthConverter() : base(DefaultTrue, DefaultFalse) { }

    }

}
