using System;
using System.Collections.Generic;
using System.Windows.Media;

using Nuclear.TestSite;

namespace Nuclear.Wpf.Data.MultiValueConverters {
    class LogicGateToBrushConverter_uTests {

        [TestMethod]
        void Implementation() {

            Test.If.Type.IsSubClass<LogicGateToBrushConverter, LogicGateConverter<Brush>>();

        }

        #region DefaultCtor

        [TestMethod]
        [TestData(nameof(DefaultCtorData))]
        void DefaultCtor(Object input1, Object input2, Object expected) {

            LogicGateToBrushConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToBrushConverter(), out Exception ex);

            Test.If.Value.IsEqual(conv.True, Brushes.Green);
            Test.If.Value.IsEqual(conv.False, Brushes.Red);
            Test.If.Value.IsEqual(conv.Convert(new Object[] { input1, input2 }, default, default, default), expected);

        }

        IEnumerable<Object[]> DefaultCtorData() {
            return new List<Object[]>() {
                new Object[] { false, false, Brushes.Red },
                new Object[] { true, false, Brushes.Red },
                new Object[] { false, true, Brushes.Red },
                new Object[] { true, true, Brushes.Green },
            };
        }

        #endregion

        #region GateCtor

        [TestMethod]
        [TestData(nameof(GateCtorData))]
        void GateCtor(LogicGates gate, Object input1, Object input2, Object expected) {

            LogicGateToBrushConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToBrushConverter(gate), out Exception ex);

            Test.If.Value.IsEqual(conv.True, Brushes.Green);
            Test.If.Value.IsEqual(conv.False, Brushes.Red);
            Test.If.Value.IsEqual(conv.Convert(new Object[] { input1, input2 }, default, default, default), expected);

        }

        IEnumerable<Object[]> GateCtorData() {
            return new List<Object[]>() {
                new Object[] { LogicGates.And, false, false, Brushes.Red },
                new Object[] { LogicGates.And, true, false, Brushes.Red },
                new Object[] { LogicGates.And, false, true, Brushes.Red },
                new Object[] { LogicGates.And, true, true, Brushes.Green },
                new Object[] { LogicGates.Or, false, false, Brushes.Red },
                new Object[] { LogicGates.Or, true, false, Brushes.Green },
                new Object[] { LogicGates.Or, false, true, Brushes.Green },
                new Object[] { LogicGates.Or, true, true, Brushes.Green },
            };
        }

        #endregion

        #region GateFullCtor

        [TestMethod]
        [TestData(nameof(GateFullCtorData))]
        void GateFullCtor(LogicGates gate, Brush @true, Brush @false, Object input1, Object input2, Object expected) {

            LogicGateToBrushConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToBrushConverter(gate, @true, @false), out Exception ex);

            Test.If.Value.IsEqual(conv.True, @true);
            Test.If.Value.IsEqual(conv.False, @false);
            Test.If.Value.IsEqual(conv.Convert(new Object[] { input1, input2 }, default, default, default), expected);

        }

        IEnumerable<Object[]> GateFullCtorData() {
            return new List<Object[]>() {
                new Object[] { LogicGates.And, Brushes.Green, Brushes.Red, false, false, Brushes.Red },
                new Object[] { LogicGates.And, Brushes.Green, Brushes.Red, true, false, Brushes.Red },
                new Object[] { LogicGates.And, Brushes.Green, Brushes.Red, false, true, Brushes.Red },
                new Object[] { LogicGates.And, Brushes.Green, Brushes.Red, true, true, Brushes.Green },
                new Object[] { LogicGates.Or, Brushes.Green, Brushes.Red, false, false, Brushes.Red },
                new Object[] { LogicGates.Or, Brushes.Green, Brushes.Red, true, false, Brushes.Green },
                new Object[] { LogicGates.Or, Brushes.Green, Brushes.Red, false, true, Brushes.Green },
                new Object[] { LogicGates.Or, Brushes.Green, Brushes.Red, true, true, Brushes.Green },
            };
        }

        #endregion

        #region LogicCtor

        [TestMethod]
        [TestData(nameof(LogicCtorData))]
        void LogicCtor(GateLogic logic) {

            LogicGateToBrushConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToBrushConverter(logic), out Exception ex);

            Test.If.Value.IsEqual(conv.Logic, logic);
            Test.If.Value.IsEqual(conv.True, Brushes.Green);
            Test.If.Value.IsEqual(conv.False, Brushes.Red);

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
        void LogicFullCtor(GateLogic logic, Brush @true, Brush @false) {

            LogicGateToBrushConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToBrushConverter(logic, @true, @false), out Exception ex);

            Test.If.Value.IsEqual(conv.Logic, logic);
            Test.If.Value.IsEqual(conv.True, @true);
            Test.If.Value.IsEqual(conv.False, @false);

        }

        IEnumerable<Object[]> LogicFullCtorData() {
            return new List<Object[]>() {
                new Object[] { new GateLogic((_) => true), Brushes.Green, Brushes.Red },
                new Object[] { new GateLogic((_) => false), Brushes.Red, Brushes.Green },
            };
        }

        #endregion

    }
}
