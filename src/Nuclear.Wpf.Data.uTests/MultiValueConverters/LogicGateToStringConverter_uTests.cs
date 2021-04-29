using System;
using System.Collections.Generic;

using Nuclear.TestSite;

namespace Nuclear.Wpf.Data.MultiValueConverters {
    class LogicGateToStringConverter_uTests {

        [TestMethod]
        void Implementation() {

            Test.If.Type.IsSubClass<LogicGateToStringConverter, LogicGateConverter<String>>();

        }

        [TestMethod]
        [TestParameters(false, false, "false")]
        [TestParameters(true, false, "false")]
        [TestParameters(false, true, "false")]
        [TestParameters(true, true, "true")]
        void DefaultCtor(Object input1, Object input2, Object expected) {

            LogicGateToStringConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToStringConverter(), out Exception ex);

            Test.If.Value.IsEqual(conv.True, "true");
            Test.If.Value.IsEqual(conv.False, "false");
            Test.If.Value.IsEqual(conv.Convert(new Object[] { input1, input2 }, default, default, default), expected);

        }

        [TestMethod]
        [TestParameters(LogicGates.And, false, false, "false")]
        [TestParameters(LogicGates.And, true, false, "false")]
        [TestParameters(LogicGates.And, false, true, "false")]
        [TestParameters(LogicGates.And, true, true, "true")]
        [TestParameters(LogicGates.Or, false, false, "false")]
        [TestParameters(LogicGates.Or, true, false, "true")]
        [TestParameters(LogicGates.Or, false, true, "true")]
        [TestParameters(LogicGates.Or, true, true, "true")]
        void GateCtor(LogicGates gate, Object input1, Object input2, Object expected) {

            LogicGateToStringConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToStringConverter(gate), out Exception ex);

            Test.If.Value.IsEqual(conv.True, "true");
            Test.If.Value.IsEqual(conv.False, "false");
            Test.If.Value.IsEqual(conv.Convert(new Object[] { input1, input2 }, default, default, default), expected);

        }

        [TestMethod]
        [TestParameters(LogicGates.And, "true", "false", false, false, "false")]
        [TestParameters(LogicGates.And, "true", "false", true, false, "false")]
        [TestParameters(LogicGates.And, "true", "false", false, true, "false")]
        [TestParameters(LogicGates.And, "true", "false", true, true, "true")]
        [TestParameters(LogicGates.Or, "true", "false", false, false, "false")]
        [TestParameters(LogicGates.Or, "true", "false", true, false, "true")]
        [TestParameters(LogicGates.Or, "true", "false", false, true, "true")]
        [TestParameters(LogicGates.Or, "true", "false", true, true, "true")]
        void GateFullCtor(LogicGates gate, String @true, String @false, Object input1, Object input2, Object expected) {

            LogicGateToStringConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToStringConverter(gate, @true, @false), out Exception ex);

            Test.If.Value.IsEqual(conv.True, @true);
            Test.If.Value.IsEqual(conv.False, @false);
            Test.If.Value.IsEqual(conv.Convert(new Object[] { input1, input2 }, default, default, default), expected);

        }

        [TestMethod]
        [TestData(nameof(LogicCtorData))]
        void LogicCtor(GateLogic logic) {

            LogicGateToStringConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToStringConverter(logic), out Exception ex);

            Test.If.Value.IsEqual(conv.Logic, logic);
            Test.If.Value.IsEqual(conv.True, "true");
            Test.If.Value.IsEqual(conv.False, "false");

        }

        IEnumerable<Object[]> LogicCtorData() {
            return new List<Object[]>() {
                new Object[] { new GateLogic((_) => true) },
                new Object[] { new GateLogic((_) => false) },
            };
        }

        [TestMethod]
        [TestData(nameof(LogicFullCtorData))]
        void LogicFullCtor(GateLogic logic, String @true, String @false) {

            LogicGateToStringConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToStringConverter(logic, @true, @false), out Exception ex);

            Test.If.Value.IsEqual(conv.Logic, logic);
            Test.If.Value.IsEqual(conv.True, @true);
            Test.If.Value.IsEqual(conv.False, @false);

        }

        IEnumerable<Object[]> LogicFullCtorData() {
            return new List<Object[]>() {
                new Object[] { new GateLogic((_) => true), "true", "false" },
                new Object[] { new GateLogic((_) => false), "false", "true" },
            };
        }

    }
}
