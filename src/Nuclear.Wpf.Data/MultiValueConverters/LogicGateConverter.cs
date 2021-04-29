using System;
using System.Globalization;
using System.Linq;
using System.Windows;

using Nuclear.Wpf.Data.MultiValueConverters.Base;

namespace Nuclear.Wpf.Data.MultiValueConverters {
    public class LogicGateConverter<T> : BaseMultiValueConverter {

        #region properties

        public GateLogic Logic { get; private set; }

        public LogicGates Gate { set => Logic = GetLogicByGate(value); }

        public T True { get; set; }

        public T False { get; set; }

        #endregion

        #region ctors

        private LogicGateConverter(T @true, T @false) {
            True = @true;
            False = @false;
        }

        public LogicGateConverter(LogicGates gate, T @true, T @false) : this(@true, @false) {
            Gate = gate;
        }

        public LogicGateConverter(GateLogic logic, T @true, T @false) : this(@true, @false) {
            Logic = logic;
        }

        #endregion

        #region methods

        public override Object Convert(Object[] values, Type targetType, Object parameter, CultureInfo culture) {
            if(values.Count() == 0 || values.Any(value => value == null || !(value is Boolean))) { return DependencyProperty.UnsetValue; }

            return Logic(values.Cast<Boolean>()) ? True : False;
        }

        public override Object[] ConvertBack(Object value, Type[] targetTypes, Object parameter, CultureInfo culture) => null;

        private GateLogic GetLogicByGate(LogicGates gate) {
            switch(gate) {
                case LogicGates.And:
                    return new GateLogic((values) => values.All(_ => _));

                case LogicGates.Nand:
                    return new GateLogic((values) => values.Any(_ => !_));

                case LogicGates.Or:
                    return new GateLogic((values) => values.Any(_ => _));

                case LogicGates.Nor:
                    return new GateLogic((values) => values.All(_ => !_));

                case LogicGates.Xor:
                    return new GateLogic((values) => values.Count(_ => _) == 1);

                case LogicGates.Xnor:
                    return new GateLogic((values) => values.Count(_ => _) != 1);

                default:
                    return new GateLogic((_) => false);
            }
        }

        #endregion

    }
}
