using System;
using System.Collections.Generic;
using System.Windows;

using Nuclear.TestSite;

namespace Nuclear.Wpf.Data.MultiValueConverters {
    class LogicGateToGridLengthConverter_uTests {

        [TestMethod]
        void Implementation() {

            Test.If.Type.IsSubClass<LogicGateToGridLengthConverter, LogicGateConverter<GridLength>>();

        }

        #region DefaultCtor

        [TestMethod]
        [TestData(nameof(DefaultCtorData))]
        void DefaultCtor(Object input1, Object input2, Object expected) {

            LogicGateToGridLengthConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToGridLengthConverter(), out Exception ex);

            Test.If.Value.IsEqual(conv.True, new GridLength(1, GridUnitType.Star));
            Test.If.Value.IsEqual(conv.False, GridLength.Auto);
            Test.If.Value.IsEqual(conv.Convert(new Object[] { input1, input2 }, default, default, default), expected);

        }

        IEnumerable<Object[]> DefaultCtorData() {
            return new List<Object[]>() {
                new Object[] { false, false, GridLength.Auto },
                new Object[] { true, false, GridLength.Auto },
                new Object[] { false, true, GridLength.Auto },
                new Object[] { true, true, new GridLength(1, GridUnitType.Star) },
            };
        }

        #endregion

        #region GateCtor

        [TestMethod]
        [TestData(nameof(GateCtorData))]
        void GateCtor(LogicGates gate, Object input1, Object input2, Object expected) {

            LogicGateToGridLengthConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToGridLengthConverter(gate), out Exception ex);

            Test.If.Value.IsEqual(conv.True, new GridLength(1, GridUnitType.Star));
            Test.If.Value.IsEqual(conv.False, GridLength.Auto);
            Test.If.Value.IsEqual(conv.Convert(new Object[] { input1, input2 }, default, default, default), expected);

        }

        IEnumerable<Object[]> GateCtorData() {
            return new List<Object[]>() {
                new Object[] { LogicGates.And, false, false, GridLength.Auto },
                new Object[] { LogicGates.And, true, false, GridLength.Auto },
                new Object[] { LogicGates.And, false, true, GridLength.Auto },
                new Object[] { LogicGates.And, true, true, new GridLength(1, GridUnitType.Star) },
                new Object[] { LogicGates.Or, false, false, GridLength.Auto },
                new Object[] { LogicGates.Or, true, false, new GridLength(1, GridUnitType.Star) },
                new Object[] { LogicGates.Or, false, true, new GridLength(1, GridUnitType.Star) },
                new Object[] { LogicGates.Or, true, true, new GridLength(1, GridUnitType.Star) },
            };
        }

        #endregion

        #region GateFullCtor

        [TestMethod]
        [TestData(nameof(GateFullCtorData))]
        void GateFullCtor(LogicGates gate, GridLength @true, GridLength @false, Object input1, Object input2, Object expected) {

            LogicGateToGridLengthConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToGridLengthConverter(gate, @true, @false), out Exception ex);

            Test.If.Value.IsEqual(conv.True, @true);
            Test.If.Value.IsEqual(conv.False, @false);
            Test.If.Value.IsEqual(conv.Convert(new Object[] { input1, input2 }, default, default, default), expected);

        }

        IEnumerable<Object[]> GateFullCtorData() {
            return new List<Object[]>() {
                new Object[] { LogicGates.And, new GridLength(1, GridUnitType.Star), GridLength.Auto, false, false, GridLength.Auto },
                new Object[] { LogicGates.And, new GridLength(1, GridUnitType.Star), GridLength.Auto, true, false, GridLength.Auto },
                new Object[] { LogicGates.And, new GridLength(1, GridUnitType.Star), GridLength.Auto, false, true, GridLength.Auto },
                new Object[] { LogicGates.And, new GridLength(1, GridUnitType.Star), GridLength.Auto, true, true, new GridLength(1, GridUnitType.Star) },
                new Object[] { LogicGates.Or, new GridLength(1, GridUnitType.Star), GridLength.Auto, false, false, GridLength.Auto },
                new Object[] { LogicGates.Or, new GridLength(1, GridUnitType.Star), GridLength.Auto, true, false, new GridLength(1, GridUnitType.Star) },
                new Object[] { LogicGates.Or, new GridLength(1, GridUnitType.Star), GridLength.Auto, false, true, new GridLength(1, GridUnitType.Star) },
                new Object[] { LogicGates.Or, new GridLength(1, GridUnitType.Star), GridLength.Auto, true, true, new GridLength(1, GridUnitType.Star) },
            };
        }

        #endregion

        #region LogicCtor

        [TestMethod]
        [TestData(nameof(LogicCtorData))]
        void LogicCtor(GateLogic logic) {

            LogicGateToGridLengthConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToGridLengthConverter(logic), out Exception ex);

            Test.If.Value.IsEqual(conv.Logic, logic);
            Test.If.Value.IsEqual(conv.True, new GridLength(1, GridUnitType.Star));
            Test.If.Value.IsEqual(conv.False, GridLength.Auto);

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
        void LogicFullCtor(GateLogic logic, GridLength @true, GridLength @false) {

            LogicGateToGridLengthConverter conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateToGridLengthConverter(logic, @true, @false), out Exception ex);

            Test.If.Value.IsEqual(conv.Logic, logic);
            Test.If.Value.IsEqual(conv.True, @true);
            Test.If.Value.IsEqual(conv.False, @false);

        }

        IEnumerable<Object[]> LogicFullCtorData() {
            return new List<Object[]>() {
                new Object[] { new GateLogic((_) => true), new GridLength(1, GridUnitType.Star), GridLength.Auto },
                new Object[] { new GateLogic((_) => false), GridLength.Auto, new GridLength(1, GridUnitType.Star) },
            };
        }

        #endregion

    }
}
