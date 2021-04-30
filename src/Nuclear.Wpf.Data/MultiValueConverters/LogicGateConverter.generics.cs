using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Nuclear.Wpf.Data.MultiValueConverters {

    /// <summary>
    /// Implementation of an <see cref="IMultiValueConverter"/> that converts multiple <see cref="Boolean"/> to <see cref="String"/> using logic gates.
    /// </summary>
    public class LogicGateToStringConverter : LogicGateConverter<String> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static String DefaultTrue { get; set; } = "true";

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static String DefaultFalse { get; set; } = "false";

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToStringConverter"/> defaulting to <see cref="LogicGates.And"/>, <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public LogicGateToStringConverter() : this(LogicGates.And) { }

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToStringConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        /// <param name="gate"></param>
        public LogicGateToStringConverter(LogicGates gate) : base(gate, DefaultTrue, DefaultFalse) { }

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToStringConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public LogicGateToStringConverter(GateLogic logic) : base(logic, DefaultTrue, DefaultFalse) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IMultiValueConverter"/> that converts multiple <see cref="Boolean"/> to <see cref="Boolean"/> using logic gates.
    /// </summary>
    public class LogicGateToBooleanConverter : LogicGateConverter<Boolean> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static Boolean DefaultTrue { get; set; } = true;

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static Boolean DefaultFalse { get; set; } = false;

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToBooleanConverter"/> defaulting to <see cref="LogicGates.And"/>, <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public LogicGateToBooleanConverter() : this(LogicGates.And) { }

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToBooleanConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public LogicGateToBooleanConverter(LogicGates gate) : base(gate, DefaultTrue, DefaultFalse) { }

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToBooleanConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public LogicGateToBooleanConverter(GateLogic logic) : base(logic, DefaultTrue, DefaultFalse) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IMultiValueConverter"/> that converts multiple <see cref="Boolean"/> to <see cref="Color"/> using logic gates.
    /// </summary>
    public class LogicGateToColorConverter : LogicGateConverter<Color> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static Color DefaultTrue { get; set; } = Colors.Green;

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static Color DefaultFalse { get; set; } = Colors.Red;

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToColorConverter"/> defaulting to <see cref="LogicGates.And"/>, <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public LogicGateToColorConverter() : this(LogicGates.And) { }

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToColorConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public LogicGateToColorConverter(LogicGates gate) : base(gate, DefaultTrue, DefaultFalse) { }

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToColorConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public LogicGateToColorConverter(GateLogic logic) : base(logic, DefaultTrue, DefaultFalse) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IMultiValueConverter"/> that converts multiple <see cref="Boolean"/> to <see cref="Brush"/> using logic gates.
    /// </summary>
    public class LogicGateToBrushConverter : LogicGateConverter<Brush> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static Brush DefaultTrue { get; set; } = Brushes.Green;

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static Brush DefaultFalse { get; set; } = Brushes.Red;

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToBrushConverter"/> defaulting to <see cref="LogicGates.And"/>, <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public LogicGateToBrushConverter() : this(LogicGates.And) { }

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToBrushConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public LogicGateToBrushConverter(LogicGates gate) : base(gate, DefaultTrue, DefaultFalse) { }

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToBrushConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public LogicGateToBrushConverter(GateLogic logic) : base(logic, DefaultTrue, DefaultFalse) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IMultiValueConverter"/> that converts multiple <see cref="Boolean"/> to <see cref="Visibility"/> using logic gates.
    /// </summary>
    public class LogicGateToVisibilityConverter : LogicGateConverter<Visibility> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static Visibility DefaultTrue { get; set; } = Visibility.Visible;

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static Visibility DefaultFalse { get; set; } = Visibility.Collapsed;

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToVisibilityConverter"/> defaulting to <see cref="LogicGates.And"/>, <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public LogicGateToVisibilityConverter() : this(LogicGates.And) { }

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToVisibilityConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public LogicGateToVisibilityConverter(LogicGates gate) : base(gate, DefaultTrue, DefaultFalse) { }

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToVisibilityConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public LogicGateToVisibilityConverter(GateLogic logic) : base(logic, DefaultTrue, DefaultFalse) { }

    }

    /// <summary>
    /// Implementation of an <see cref="IMultiValueConverter"/> that converts multiple <see cref="Boolean"/> to <see cref="GridLength"/> using logic gates.
    /// </summary>
    public class LogicGateToGridLengthConverter : LogicGateConverter<GridLength> {

        /// <summary>
        /// The default substitute value for true.
        /// </summary>
        public static GridLength DefaultTrue { get; set; } = new GridLength(1, GridUnitType.Star);

        /// <summary>
        /// The default substitute value for false.
        /// </summary>
        public static GridLength DefaultFalse { get; set; } = GridLength.Auto;

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToGridLengthConverter"/> defaulting to <see cref="LogicGates.And"/>, <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public LogicGateToGridLengthConverter() : this(LogicGates.And) { }

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToGridLengthConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public LogicGateToGridLengthConverter(LogicGates gate) : base(gate, DefaultTrue, DefaultFalse) { }

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateToGridLengthConverter"/> defaulting to <see cref="DefaultTrue"/> and <see cref="DefaultFalse"/>.
        /// </summary>
        public LogicGateToGridLengthConverter(GateLogic logic) : base(logic, DefaultTrue, DefaultFalse) { }

    }

}
