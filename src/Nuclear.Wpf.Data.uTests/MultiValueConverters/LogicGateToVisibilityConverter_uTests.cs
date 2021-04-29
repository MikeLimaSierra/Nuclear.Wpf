using System;
using System.Collections.Generic;
using System.Windows;

using Nuclear.TestSite;

namespace Nuclear.Wpf.Data.MultiValueConverters {
    class LogicGateToVisibilityConverter_uTests {

        [TestMethod]
        void Implementation() {

            Test.If.Type.IsSubClass<LogicGateToVisibilityConverter, LogicGateConverter<Visibility>>();

        }

        [TestMethod]
        [TestParameters(false, false, Visibility.Collapsed)]
        [TestParameters(true, false, Visibility.Collapsed)]
        [TestParameters(false, true, Visibility.Collapsed)]
        [TestParameters(true, true, Visibility.Visible)]
        void DefaultCtor(Object input1, Object input2, Object expected) {

            LogicGateToVisibilityConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToVisibilityConverter(), out Exception ex);

            Test.If.Value.IsEqual(conv.True, Visibility.Visible);
            Test.If.Value.IsEqual(conv.False, Visibility.Collapsed);
            Test.If.Value.IsEqual(conv.Convert(new Object[] { input1, input2 }, default, default, default), expected);

        }

        [TestMethod]
        [TestParameters(LogicGates.And, false, false, Visibility.Collapsed)]
        [TestParameters(LogicGates.And, true, false, Visibility.Collapsed)]
        [TestParameters(LogicGates.And, false, true, Visibility.Collapsed)]
        [TestParameters(LogicGates.And, true, true, Visibility.Visible)]
        [TestParameters(LogicGates.Or, false, false, Visibility.Collapsed)]
        [TestParameters(LogicGates.Or, true, false, Visibility.Visible)]
        [TestParameters(LogicGates.Or, false, true, Visibility.Visible)]
        [TestParameters(LogicGates.Or, true, true, Visibility.Visible)]
        void GateCtor(LogicGates gate, Object input1, Object input2, Object expected) {

            LogicGateToVisibilityConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToVisibilityConverter(gate), out Exception ex);

            Test.If.Value.IsEqual(conv.True, Visibility.Visible);
            Test.If.Value.IsEqual(conv.False, Visibility.Collapsed);
            Test.If.Value.IsEqual(conv.Convert(new Object[] { input1, input2 }, default, default, default), expected);

        }

        [TestMethod]
        [TestParameters(LogicGates.And, Visibility.Visible, Visibility.Collapsed, false, false, Visibility.Collapsed)]
        [TestParameters(LogicGates.And, Visibility.Visible, Visibility.Collapsed, true, false, Visibility.Collapsed)]
        [TestParameters(LogicGates.And, Visibility.Visible, Visibility.Collapsed, false, true, Visibility.Collapsed)]
        [TestParameters(LogicGates.And, Visibility.Visible, Visibility.Collapsed, true, true, Visibility.Visible)]
        [TestParameters(LogicGates.Or, Visibility.Visible, Visibility.Collapsed, false, false, Visibility.Collapsed)]
        [TestParameters(LogicGates.Or, Visibility.Visible, Visibility.Collapsed, true, false, Visibility.Visible)]
        [TestParameters(LogicGates.Or, Visibility.Visible, Visibility.Collapsed, false, true, Visibility.Visible)]
        [TestParameters(LogicGates.Or, Visibility.Visible, Visibility.Collapsed, true, true, Visibility.Visible)]
        void GateFullCtor(LogicGates gate, Visibility @true, Visibility @false, Object input1, Object input2, Object expected) {

            LogicGateToVisibilityConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToVisibilityConverter(gate, @true, @false), out Exception ex);

            Test.If.Value.IsEqual(conv.True, @true);
            Test.If.Value.IsEqual(conv.False, @false);
            Test.If.Value.IsEqual(conv.Convert(new Object[] { input1, input2 }, default, default, default), expected);

        }

        [TestMethod]
        [TestData(nameof(LogicCtorData))]
        void LogicCtor(GateLogic logic) {

            LogicGateToVisibilityConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToVisibilityConverter(logic), out Exception ex);

            Test.If.Value.IsEqual(conv.Logic, logic);
            Test.If.Value.IsEqual(conv.True, Visibility.Visible);
            Test.If.Value.IsEqual(conv.False, Visibility.Collapsed);

        }

        IEnumerable<Object[]> LogicCtorData() {
            return new List<Object[]>() {
                new Object[] { new GateLogic((_) => true) },
                new Object[] { new GateLogic((_) => false) },
            };
        }

        [TestMethod]
        [TestData(nameof(LogicFullCtorData))]
        void LogicFullCtor(GateLogic logic, Visibility @true, Visibility @false) {

            LogicGateToVisibilityConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToVisibilityConverter(logic, @true, @false), out Exception ex);

            Test.If.Value.IsEqual(conv.Logic, logic);
            Test.If.Value.IsEqual(conv.True, @true);
            Test.If.Value.IsEqual(conv.False, @false);

        }

        IEnumerable<Object[]> LogicFullCtorData() {
            return new List<Object[]>() {
                new Object[] { new GateLogic((_) => true), Visibility.Visible, Visibility.Collapsed },
                new Object[] { new GateLogic((_) => false), Visibility.Collapsed, Visibility.Visible },
            };
        }

    }
}
