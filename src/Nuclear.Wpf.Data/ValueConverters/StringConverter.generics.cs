using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Nuclear.Wpf.Data.ValueConverters {

    [ValueConversion(typeof(String), typeof(Boolean))]
    public class StringToBooleanConverter : StringConverter<Boolean> {

        public static Boolean DefaultNull { get; set; } = false;

        public static Boolean DefaultEmpty { get; set; } = false;

        public static Boolean DefaultWhiteSpace { get; set; } = false;

        public static Boolean DefaultHasValue { get; set; } = true;

        public StringToBooleanConverter() : base(DefaultNull, DefaultEmpty, DefaultWhiteSpace, DefaultHasValue) { }

    }

    [ValueConversion(typeof(String), typeof(String))]
    public class StringToStringConverter : StringConverter<String> {

        public static String DefaultNull { get; set; } = "null";

        public static String DefaultEmpty { get; set; } = "empty";

        public static String DefaultWhiteSpace { get; set; } = "white-space";

        public static String DefaultHasValue { get; set; } = "has value";

        public StringToStringConverter() : base(DefaultNull, DefaultEmpty, DefaultWhiteSpace, DefaultHasValue) { }

    }

    [ValueConversion(typeof(String), typeof(Color))]
    public class StringToColorConverter : StringConverter<Color> {

        public static Color DefaultNull { get; set; } = Colors.Red;

        public static Color DefaultEmpty { get; set; } = Colors.Orange;

        public static Color DefaultWhiteSpace { get; set; } = Colors.Yellow;

        public static Color DefaultHasValue { get; set; } = Colors.Green;

        public StringToColorConverter() : base(DefaultNull, DefaultEmpty, DefaultWhiteSpace, DefaultHasValue) { }

    }

    [ValueConversion(typeof(String), typeof(Brush))]
    public class StringToBrushConverter : StringConverter<Brush> {

        public static Brush DefaultNull { get; set; } = Brushes.Red;

        public static Brush DefaultEmpty { get; set; } = Brushes.Orange;

        public static Brush DefaultWhiteSpace { get; set; } = Brushes.Yellow;

        public static Brush DefaultHasValue { get; set; } = Brushes.Green;

        public StringToBrushConverter() : base(DefaultNull, DefaultEmpty, DefaultWhiteSpace, DefaultHasValue) { }

    }

    [ValueConversion(typeof(String), typeof(Visibility))]
    public class StringToVisibilityConverter : StringConverter<Visibility> {

        public static Visibility DefaultNull { get; set; } = Visibility.Collapsed;

        public static Visibility DefaultEmpty { get; set; } = Visibility.Collapsed;

        public static Visibility DefaultWhiteSpace { get; set; } = Visibility.Collapsed;

        public static Visibility DefaultHasValue { get; set; } = Visibility.Visible;

        public StringToVisibilityConverter() : base(DefaultNull, DefaultEmpty, DefaultWhiteSpace, DefaultHasValue) { }

    }

    [ValueConversion(typeof(String), typeof(GridLength))]
    public class StringToGridLengthConverter : StringConverter<GridLength> {

        public static GridLength DefaultNull { get; set; } = GridLength.Auto;

        public static GridLength DefaultEmpty { get; set; } = GridLength.Auto;

        public static GridLength DefaultWhiteSpace { get; set; } = GridLength.Auto;

        public static GridLength DefaultHasValue { get; set; } = new GridLength(1, GridUnitType.Star);

        public StringToGridLengthConverter() : base(DefaultNull, DefaultEmpty, DefaultWhiteSpace, DefaultHasValue) { }

    }

}
