using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;

using Nuclear.Wpf.Data.MultiValueConverters.Base;

namespace Nuclear.Wpf.Data.MultiValueConverters {

    /// <summary>
    /// Implementation of an <see cref="IMultiValueConverter"/> that converts multiple <see cref="Boolean"/> to <typeparamref name="T"/> using logic gates.
    /// </summary>
    /// <typeparam name="T">The conversion result type.</typeparam>
    public class LogicGateConverter<T> : BaseMultiValueConverter {

        #region properties

        private LogicGates _gate = LogicGates.And;

        #endregion

        #region properties

        /// <summary>
        /// Gets the used <see cref="GateLogic"/> delegate.
        /// </summary>
        public GateLogic Logic { get; private set; }

        /// <summary>
        /// Gets or sets the used logic gate.
        /// </summary>
        public LogicGates Gate {
            get => _gate;
            set => Logic = GetLogicByGate(_gate = Enum.IsDefined(typeof(LogicGates), value) ? value : LogicGates.Custom);
        }

        /// <summary>
        /// Gets or sets the substitute value for true.
        /// </summary>
        public T True { get; set; }

        /// <summary>
        /// Gets or sets the substitute value for false.
        /// </summary>
        public T False { get; set; }

        #endregion

        #region ctors

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateConverter{T}"/> defaulting to <see cref="LogicGates.And"/> logic.
        /// </summary>
        /// <param name="true">The substitute value for true.</param>
        /// <param name="false">The substitute value for false.</param>
        private LogicGateConverter(T @true, T @false) {
            True = @true;
            False = @false;
        }

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateConverter{T}"/>.
        /// </summary>
        /// <param name="gate">The gate logic to be used.</param>
        /// <param name="true">The substitute value for true.</param>
        /// <param name="false">The substitute value for false.</param>
        public LogicGateConverter(LogicGates gate, T @true, T @false) : this(@true, @false) {
            Gate = gate;
        }

        /// <summary>
        /// Creates a new instance of <see cref="LogicGateConverter{T}"/>.
        /// </summary>
        /// <param name="logic">The gate logic delegate.</param>
        /// <param name="true">The substitute value for true.</param>
        /// <param name="false">The substitute value for false.</param>
        public LogicGateConverter(GateLogic logic, T @true, T @false) : this(@true, @false) {
            _gate = LogicGates.Custom;
            Logic = logic;
        }

        #endregion

        #region methods

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override Object Convert(Object[] values, Type targetType, Object parameter, CultureInfo culture) {
            if(values.Count() == 0 || values.Any(value => value == null || !(value is Boolean))) { return DependencyProperty.UnsetValue; }

            return Logic(values.Cast<Boolean>()) ? True : False;
        }

        public override Object[] ConvertBack(Object value, Type[] targetTypes, Object parameter, CultureInfo culture) => null;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

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

                case LogicGates.Custom:
                default:
                    return new GateLogic((_) => false);
            }
        }

        #endregion

    }
}
