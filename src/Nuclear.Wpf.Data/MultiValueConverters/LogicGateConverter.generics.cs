using System;
using System.Windows;
using System.Windows.Media;

namespace Nuclear.Wpf.Data.MultiValueConverters {

    public class LogicGateToStringConverter : LogicGateConverter<String> {

        public LogicGateToStringConverter() : this(LogicGates.And) { }

        public LogicGateToStringConverter(LogicGates gate) : base(gate, "true", "false") { }

        public LogicGateToStringConverter(GateLogic logic) : base(logic, "true", "false") { }

    }

    public class LogicGateToBooleanConverter : LogicGateConverter<Boolean> {

        public LogicGateToBooleanConverter() : this(LogicGates.And) { }

        public LogicGateToBooleanConverter(LogicGates gate) : base(gate, true, false) { }

        public LogicGateToBooleanConverter(GateLogic logic) : base(logic, true, false) { }

    }

    public class LogicGateToColorConverter : LogicGateConverter<Color> {

        public LogicGateToColorConverter() : this(LogicGates.And) { }

        public LogicGateToColorConverter(LogicGates gate) : base(gate, Colors.Green, Colors.Red) { }

        public LogicGateToColorConverter(GateLogic logic) : base(logic, Colors.Green, Colors.Red) { }

    }

    public class LogicGateToBrushConverter : LogicGateConverter<Brush> {

        public LogicGateToBrushConverter() : this(LogicGates.And) { }

        public LogicGateToBrushConverter(LogicGates gate) : base(gate, Brushes.Green, Brushes.Red) { }

        public LogicGateToBrushConverter(GateLogic logic) : base(logic, Brushes.Green, Brushes.Red) { }

    }

    public class LogicGateToVisibilityConverter : LogicGateConverter<Visibility> {

        public LogicGateToVisibilityConverter() : this(LogicGates.And) { }

        public LogicGateToVisibilityConverter(LogicGates gate) : base(gate, Visibility.Visible, Visibility.Collapsed) { }

        public LogicGateToVisibilityConverter(GateLogic logic) : base(logic, Visibility.Visible, Visibility.Collapsed) { }

    }

    public class LogicGateToGridLengthConverter : LogicGateConverter<GridLength> {

        public LogicGateToGridLengthConverter() : this(LogicGates.And) { }

        public LogicGateToGridLengthConverter(LogicGates gate) : base(gate, new GridLength(1, GridUnitType.Star), GridLength.Auto) { }

        public LogicGateToGridLengthConverter(GateLogic logic) : base(logic, new GridLength(1, GridUnitType.Star), GridLength.Auto) { }

    }

}
