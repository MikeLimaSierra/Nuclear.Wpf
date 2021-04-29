using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Nuclear.Wpf.Data.ValueConverters {

    [ValueConversion(typeof(Boolean?), typeof(Boolean))]
    public class NullableBooleanToBooleanConverter : NullableBooleanConverter<Boolean> {

        public static Boolean DefaultTrue { get; set; } = true;

        public static Boolean DefaultFalse { get; set; } = false;

        public static Boolean DefaultNull { get; set; } = false;

        public NullableBooleanToBooleanConverter() : base(DefaultTrue, DefaultFalse, DefaultNull) { }

    }

    [ValueConversion(typeof(Boolean?), typeof(String))]
    public class NullableBooleanToStringConverter : NullableBooleanConverter<String> {

        public static String DefaultTrue { get; set; } = "true";

        public static String DefaultFalse { get; set; } = "false";

        public static String DefaultNull { get; set; } = "null";

        public NullableBooleanToStringConverter() : base(DefaultTrue, DefaultFalse, DefaultNull) { }

    }

    [ValueConversion(typeof(Boolean?), typeof(Color))]
    public class NullableBooleanToColorConverter : NullableBooleanConverter<Color> {

        public static Color DefaultTrue { get; set; } = Colors.Green;

        public static Color DefaultFalse { get; set; } = Colors.Red;

        public static Color DefaultNull { get; set; } = Colors.Yellow;

        public NullableBooleanToColorConverter() : base(DefaultTrue, DefaultFalse, DefaultNull) { }

    }

    [ValueConversion(typeof(Boolean?), typeof(Brush))]
    public class NullableBooleanToBrushConverter : NullableBooleanConverter<Brush> {

        public static Brush DefaultTrue { get; set; } = Brushes.Green;

        public static Brush DefaultFalse { get; set; } = Brushes.Red;

        public static Brush DefaultNull { get; set; } = Brushes.Yellow;

        public NullableBooleanToBrushConverter() : base(DefaultTrue, DefaultFalse, DefaultNull) { }

    }

    [ValueConversion(typeof(Boolean?), typeof(Visibility))]
    public class NullableBooleanToVisibilityConverter : NullableBooleanConverter<Visibility> {

        public static Visibility DefaultTrue { get; set; } = Visibility.Visible;

        public static Visibility DefaultFalse { get; set; } = Visibility.Collapsed;

        public static Visibility DefaultNull { get; set; } = Visibility.Hidden;

        public NullableBooleanToVisibilityConverter() : base(DefaultTrue, DefaultFalse, DefaultNull) { }

    }

    [ValueConversion(typeof(Boolean?), typeof(GridLength))]
    public class NullableBooleanToGridLengthConverter : NullableBooleanConverter<GridLength> {

        public static GridLength DefaultTrue { get; set; } = new GridLength(1, GridUnitType.Star);

        public static GridLength DefaultFalse { get; set; } = GridLength.Auto;

        public static GridLength DefaultNull { get; set; } = GridLength.Auto;

        public NullableBooleanToGridLengthConverter() : base(DefaultTrue, DefaultFalse, DefaultNull) { }

    }

}
