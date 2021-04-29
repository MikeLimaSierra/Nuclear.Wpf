using System;
using System.Collections.Generic;
using System.Windows.Media;

using Nuclear.TestSite;

namespace Nuclear.Wpf.Data.MultiValueConverters {
    class LogicGateToColorConverter_uTests {

        [TestMethod]
        void Implementation() {

            Test.If.Type.IsSubClass<LogicGateToColorConverter, LogicGateConverter<Color>>();

        }

        #region DefaultCtor

        [TestMethod]
        [TestData(nameof(DefaultCtorData))]
        void DefaultCtor(Object input1, Object input2, Object expected) {

            LogicGateToColorConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToColorConverter(), out Exception ex);

            Test.If.Value.IsEqual(conv.True, Colors.Green);
            Test.If.Value.IsEqual(conv.False, Colors.Red);
            Test.If.Value.IsEqual(conv.Convert(new Object[] { input1, input2 }, default, default, default), expected);

        }

        IEnumerable<Object[]> DefaultCtorData() {
            return new List<Object[]>() {
                new Object[] { false, false, Colors.Red },
                new Object[] { true, false, Colors.Red },
                new Object[] { false, true, Colors.Red },
                new Object[] { true, true, Colors.Green },
            };
        }

        #endregion

        #region GateCtor

        [TestMethod]
        [TestData(nameof(GateCtorData))]
        void GateCtor(LogicGates gate, Object input1, Object input2, Object expected) {

            LogicGateToColorConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToColorConverter(gate), out Exception ex);

            Test.If.Value.IsEqual(conv.True, Colors.Green);
            Test.If.Value.IsEqual(conv.False, Colors.Red);
            Test.If.Value.IsEqual(conv.Convert(new Object[] { input1, input2 }, default, default, default), expected);

        }

        IEnumerable<Object[]> GateCtorData() {
            return new List<Object[]>() {
                new Object[] { LogicGates.And, false, false, Colors.Red },
                new Object[] { LogicGates.And, true, false, Colors.Red },
                new Object[] { LogicGates.And, false, true, Colors.Red },
                new Object[] { LogicGates.And, true, true, Colors.Green },
                new Object[] { LogicGates.Or, false, false, Colors.Red },
                new Object[] { LogicGates.Or, true, false, Colors.Green },
                new Object[] { LogicGates.Or, false, true, Colors.Green },
                new Object[] { LogicGates.Or, true, true, Colors.Green },
            };
        }

        #endregion

        #region GateFullCtor

        [TestMethod]
        [TestData(nameof(GateFullCtorData))]
        void GateFullCtor(LogicGates gate, Color @true, Color @false, Object input1, Object input2, Object expected) {

            LogicGateToColorConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToColorConverter(gate, @true, @false), out Exception ex);

            Test.If.Value.IsEqual(conv.True, @true);
            Test.If.Value.IsEqual(conv.False, @false);
            Test.If.Value.IsEqual(conv.Convert(new Object[] { input1, input2 }, default, default, default), expected);

        }

        IEnumerable<Object[]> GateFullCtorData() {
            return new List<Object[]>() {
                new Object[] { LogicGates.And, Colors.Green, Colors.Red, false, false, Colors.Red },
                new Object[] { LogicGates.And, Colors.Green, Colors.Red, true, false, Colors.Red },
                new Object[] { LogicGates.And, Colors.Green, Colors.Red, false, true, Colors.Red },
                new Object[] { LogicGates.And, Colors.Green, Colors.Red, true, true, Colors.Green },
                new Object[] { LogicGates.Or, Colors.Green, Colors.Red, false, false, Colors.Red },
                new Object[] { LogicGates.Or, Colors.Green, Colors.Red, true, false, Colors.Green },
                new Object[] { LogicGates.Or, Colors.Green, Colors.Red, false, true, Colors.Green },
                new Object[] { LogicGates.Or, Colors.Green, Colors.Red, true, true, Colors.Green },
            };
        }

        #endregion

        #region LogicCtor

        [TestMethod]
        [TestData(nameof(LogicCtorData))]
        void LogicCtor(GateLogic logic) {

            LogicGateToColorConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToColorConverter(logic), out Exception ex);

            Test.If.Value.IsEqual(conv.Logic, logic);
            Test.If.Value.IsEqual(conv.True, Colors.Green);
            Test.If.Value.IsEqual(conv.False, Colors.Red);

        }

        IEnumerable<Object[]> LogicCtorData() {
            return new List<Object[]>() {
                new Object[] { new GateLogic((_) => true) },
                new Object[] { new GateLogic((_) => false) },
            };
        }

        #endregion

        #region LogicFullCtor

        [TestMethod]
        [TestData(nameof(LogicFullCtorData))]
        void LogicFullCtor(GateLogic logic, Color @true, Color @false) {

            LogicGateToColorConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToColorConverter(logic, @true, @false), out Exception ex);

            Test.If.Value.IsEqual(conv.Logic, logic);
            Test.If.Value.IsEqual(conv.True, @true);
            Test.If.Value.IsEqual(conv.False, @false);

        }

        IEnumerable<Object[]> LogicFullCtorData() {
            return new List<Object[]>() {
                new Object[] { new GateLogic((_) => true), Colors.Green, Colors.Red },
                new Object[] { new GateLogic((_) => false), Colors.Red, Colors.Green },
            };
        }

        #endregion

    }
}
