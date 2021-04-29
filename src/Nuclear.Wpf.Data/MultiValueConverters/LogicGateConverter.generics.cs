using System;
using System.Windows;
using System.Windows.Media;

namespace Nuclear.Wpf.Data.MultiValueConverters {

    public class LogicGateToStringConverter : LogicGateConverter<String> {

        public LogicGateToStringConverter() : this(LogicGates.And) { }

        public LogicGateToStringConverter(LogicGates gate) : this(gate, "true", "false") { }

        public LogicGateToStringConverter(GateLogic logic) : this(logic, "true", "false") { }

        public LogicGateToStringConverter(LogicGates gate, String @true, String @false) : base(gate, @true, @false) { }

        public LogicGateToStringConverter(GateLogic logic, String @true, String @false) : base(logic, @true, @false) { }

    }

    public class LogicGateToBooleanConverter : LogicGateConverter<Boolean> {

        public LogicGateToBooleanConverter() : this(LogicGates.And) { }

        public LogicGateToBooleanConverter(LogicGates gate) : this(gate, true, false) { }

        public LogicGateToBooleanConverter(GateLogic logic) : this(logic, true, false) { }

        public LogicGateToBooleanConverter(LogicGates gate, Boolean @true, Boolean @false) : base(gate, @true, @false) { }

        public LogicGateToBooleanConverter(GateLogic logic, Boolean @true, Boolean @false) : base(logic, @true, @false) { }

    }

    public class LogicGateToColorConverter : LogicGateConverter<Color> {

        public LogicGateToColorConverter() : this(LogicGates.And) { }

        public LogicGateToColorConverter(LogicGates gate) : this(gate, Colors.Green, Colors.Red) { }

        public LogicGateToColorConverter(GateLogic logic) : this(logic, Colors.Green, Colors.Red) { }

        public LogicGateToColorConverter(LogicGates gate, Color @true, Color @false) : base(gate, @true, @false) { }

        public LogicGateToColorConverter(GateLogic logic, Color @true, Color @false) : base(logic, @true, @false) { }

    }

    public class LogicGateToBrushConverter : LogicGateConverter<Brush> {

        public LogicGateToBrushConverter() : this(LogicGates.And) { }

        public LogicGateToBrushConverter(LogicGates gate) : this(gate, Brushes.Green, Brushes.Red) { }

        public LogicGateToBrushConverter(GateLogic logic) : this(logic, Brushes.Green, Brushes.Red) { }

        public LogicGateToBrushConverter(LogicGates gate, Brush @true, Brush @false) : base(gate, @true, @false) { }

        public LogicGateToBrushConverter(GateLogic logic, Brush @true, Brush @false) : base(logic, @true, @false) { }

    }

    public class LogicGateToVisibilityConverter : LogicGateConverter<Visibility> {

        public LogicGateToVisibilityConverter() : this(LogicGates.And) { }

        public LogicGateToVisibilityConverter(LogicGates gate) : this(gate, Visibility.Visible, Visibility.Collapsed) { }

        public LogicGateToVisibilityConverter(GateLogic logic) : this(logic, Visibility.Visible, Visibility.Collapsed) { }

        public LogicGateToVisibilityConverter(LogicGates gate, Visibility @true, Visibility @false) : base(gate, @true, @false) { }

        public LogicGateToVisibilityConverter(GateLogic logic, Visibility @true, Visibility @false) : base(logic, @true, @false) { }

    }

    public class LogicGateToGridLengthConverter : LogicGateConverter<GridLength> {

        public LogicGateToGridLengthConverter() : this(LogicGates.And) { }

        public LogicGateToGridLengthConverter(LogicGates gate) : this(gate, new GridLength(1, GridUnitType.Star), GridLength.Auto) { }

        public LogicGateToGridLengthConverter(GateLogic logic) : this(logic, new GridLength(1, GridUnitType.Star), GridLength.Auto) { }

        public LogicGateToGridLengthConverter(LogicGates gate, GridLength @true, GridLength @false) : base(gate, @true, @false) { }

        public LogicGateToGridLengthConverter(GateLogic logic, GridLength @true, GridLength @false) : base(logic, @true, @false) { }

    }

}
