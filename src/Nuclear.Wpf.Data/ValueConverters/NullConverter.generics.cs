using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Nuclear.Wpf.Data.ValueConverters {

    [ValueConversion(typeof(Object), typeof(Boolean))]
    public class NullToBooleanConverter : NullConverter<Boolean> {

        public static Boolean DefaultNull { get; set; } = false;

        public static Boolean DefaultNotNull { get; set; } = true;

        public NullToBooleanConverter() : base(DefaultNull, DefaultNotNull) { }

    }

    [ValueConversion(typeof(Object), typeof(String))]
    public class NullToStringConverter : NullConverter<String> {

        public static String DefaultNull { get; set; } = "null";

        public static String DefaultNotNull { get; set; } = "not null";

        public NullToStringConverter() : base(DefaultNull, DefaultNotNull) { }

    }

    [ValueConversion(typeof(Object), typeof(Color))]
    public class NullToColorConverter : NullConverter<Color> {

        public static Color DefaultNull { get; set; } = Colors.Red;

        public static Color DefaultNotNull { get; set; } = Colors.Green;

        public NullToColorConverter() : base(DefaultNull, DefaultNotNull) { }

    }

    [ValueConversion(typeof(Object), typeof(Brush))]
    public class NullToBrushConverter : NullConverter<Brush> {

        public static Brush DefaultNull { get; set; } = Brushes.Red;

        public static Brush DefaultNotNull { get; set; } = Brushes.Green;

        public NullToBrushConverter() : base(DefaultNull, DefaultNotNull) { }

    }

    [ValueConversion(typeof(Object), typeof(Visibility))]
    public class NullToVisibilityConverter : NullConverter<Visibility> {

        public static Visibility DefaultNull { get; set; } = Visibility.Collapsed;

        public static Visibility DefaultNotNull { get; set; } = Visibility.Visible;

        public NullToVisibilityConverter() : base(DefaultNull, DefaultNotNull) { }

    }

    [ValueConversion(typeof(Object), typeof(GridLength))]
    public class NullToGridLengthConverter : NullConverter<GridLength> {

        public static GridLength DefaultNull { get; set; } = GridLength.Auto;

        public static GridLength DefaultNotNull { get; set; } = new GridLength(1, GridUnitType.Star);

        public NullToGridLengthConverter() : base(DefaultNull, DefaultNotNull) { }

    }

}
