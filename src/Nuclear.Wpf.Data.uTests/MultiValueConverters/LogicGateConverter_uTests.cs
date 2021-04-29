
using System;
using System.Collections.Generic;
using System.Windows;

using Nuclear.TestSite;
using Nuclear.Wpf.Data.MultiValueConverters.Base;

namespace Nuclear.Wpf.Data.MultiValueConverters {
    class LogicGateConverter_uTests {

        [TestMethod]
        void Implementation() {

            Test.If.Type.IsSubClass<LogicGateConverter<Object>, BaseMultiValueConverter>();

        }

        #region ctors

        [TestMethod]
        [TestParameters(typeof(String), LogicGates.And, null, null)]
        [TestParameters(typeof(String), LogicGates.Nand, null, "True")]
        [TestParameters(typeof(String), LogicGates.Or, "False", null)]
        [TestParameters(typeof(String), LogicGates.Nor, "", "True")]
        [TestParameters(typeof(String), LogicGates.Xor, "False", "")]
        [TestParameters(typeof(String), LogicGates.Xnor, " ", "True")]
        [TestParameters(typeof(String), (LogicGates) 42, "False", " ")]
        [TestParameters(typeof(Int32), LogicGates.And, 0, 10)]
        void CtorEnum<T>(LogicGates gate, T @true, T @false) {

            LogicGateConverter<T> conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateConverter<T>(gate, @true, @false), out Exception ex);

            Test.If.Value.IsEqual(conv.True, @true);
            Test.If.Value.IsEqual(conv.False, @false);

        }

        [TestMethod]
        [TestData(nameof(CtorDelegateData))]
        void CtorDelegate<T>(GateLogic logic, T @true, T @false) {

            LogicGateConverter<T> conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new LogicGateConverter<T>(logic, @true, @false), out Exception ex);

            Test.If.Value.IsEqual(conv.Logic, logic);
            Test.If.Value.IsEqual(conv.True, @true);
            Test.If.Value.IsEqual(conv.False, @false);

        }

        IEnumerable<Object[]> CtorDelegateData() {
            return new List<Object[]>() {
                new Object[] { typeof(String), null, null, null },
                new Object[] { typeof(String), default, null, "True" },
                new Object[] { typeof(String), new GateLogic((_) => true), "False", null },
                new Object[] { typeof(String), new GateLogic((_) => false), "", "True" },
                new Object[] { typeof(String), new GateLogic((_) => throw new NotImplementedException()), "False", "" },
                new Object[] { typeof(String), new GateLogic((_) => true), " ", "True" },
                new Object[] { typeof(String), new GateLogic((_) => true), "False", " " },
                new Object[] { typeof(Int32), new GateLogic((_) => true), 0, 10 },
            };
        }

        #endregion

        #region properties

        [TestMethod]
        [TestParameters(LogicGates.And)]
        [TestParameters(LogicGates.Nand)]
        [TestParameters(LogicGates.Or)]
        [TestParameters(LogicGates.Nor)]
        [TestParameters(LogicGates.Xor)]
        [TestParameters(LogicGates.Xnor)]
        [TestParameters((LogicGates) 42)]
        void Gate(LogicGates gate) {

            LogicGateConverter<Object> conv = new LogicGateConverter<Object>(null, default, default);

            Test.IfNot.Action.ThrowsException(() => conv.Gate = gate, out Exception ex);

            Test.IfNot.Object.IsNull(conv.Logic);

        }

        [TestMethod]
        [TestParameters(typeof(String), null)]
        [TestParameters(typeof(String), "")]
        [TestParameters(typeof(String), " ")]
        [TestParameters(typeof(String), "Hello!")]
        [TestParameters(typeof(Int32), 0)]
        void True<T>(T @true) {

            LogicGateConverter<T> conv = new LogicGateConverter<T>(null, default, default);
            T _true = default;

            Test.IfNot.Action.ThrowsException(() => conv.True = @true, out Exception ex);

            Test.IfNot.Action.ThrowsException(() => _true = conv.True, out ex);
            Test.If.Value.IsEqual(_true, @true);

        }

        [TestMethod]
        [TestParameters(typeof(String), null)]
        [TestParameters(typeof(String), "")]
        [TestParameters(typeof(String), " ")]
        [TestParameters(typeof(String), "Hello!")]
        [TestParameters(typeof(Int32), 0)]
        void False<T>(T @false) {

            LogicGateConverter<T> conv = new LogicGateConverter<T>(null, default, default);
            T _false = default;

            Test.IfNot.Action.ThrowsException(() => conv.False = @false, out Exception ex);

            Test.IfNot.Action.ThrowsException(() => _false = conv.False, out ex);
            Test.If.Value.IsEqual(_false, @false);

        }

        #endregion

        #region GetLogicByGate

        [TestMethod]
        [TestParameters(LogicGates.And, false, false, false, false)]
        [TestParameters(LogicGates.And, false, false, true, false)]
        [TestParameters(LogicGates.And, false, true, false, false)]
        [TestParameters(LogicGates.And, false, true, true, false)]
        [TestParameters(LogicGates.And, true, false, false, false)]
        [TestParameters(LogicGates.And, true, false, true, false)]
        [TestParameters(LogicGates.And, true, true, false, false)]
        [TestParameters(LogicGates.And, true, true, true, true)]
        [TestParameters(LogicGates.Nand, false, false, false, true)]
        [TestParameters(LogicGates.Nand, false, false, true, true)]
        [TestParameters(LogicGates.Nand, false, true, false, true)]
        [TestParameters(LogicGates.Nand, false, true, true, true)]
        [TestParameters(LogicGates.Nand, true, false, false, true)]
        [TestParameters(LogicGates.Nand, true, false, true, true)]
        [TestParameters(LogicGates.Nand, true, true, false, true)]
        [TestParameters(LogicGates.Nand, true, true, true, false)]
        [TestParameters(LogicGates.Or, false, false, false, false)]
        [TestParameters(LogicGates.Or, false, false, true, true)]
        [TestParameters(LogicGates.Or, false, true, false, true)]
        [TestParameters(LogicGates.Or, false, true, true, true)]
        [TestParameters(LogicGates.Or, true, false, false, true)]
        [TestParameters(LogicGates.Or, true, false, true, true)]
        [TestParameters(LogicGates.Or, true, true, false, true)]
        [TestParameters(LogicGates.Or, true, true, true, true)]
        [TestParameters(LogicGates.Nor, false, false, false, true)]
        [TestParameters(LogicGates.Nor, false, false, true, false)]
        [TestParameters(LogicGates.Nor, false, true, false, false)]
        [TestParameters(LogicGates.Nor, false, true, true, false)]
        [TestParameters(LogicGates.Nor, true, false, false, false)]
        [TestParameters(LogicGates.Nor, true, false, true, false)]
        [TestParameters(LogicGates.Nor, true, true, false, false)]
        [TestParameters(LogicGates.Nor, true, true, true, false)]
        [TestParameters(LogicGates.Xor, false, false, false, false)]
        [TestParameters(LogicGates.Xor, false, false, true, true)]
        [TestParameters(LogicGates.Xor, false, true, false, true)]
        [TestParameters(LogicGates.Xor, false, true, true, false)]
        [TestParameters(LogicGates.Xor, true, false, false, true)]
        [TestParameters(LogicGates.Xor, true, false, true, false)]
        [TestParameters(LogicGates.Xor, true, true, false, false)]
        [TestParameters(LogicGates.Xor, true, true, true, false)]
        [TestParameters(LogicGates.Xnor, false, false, false, true)]
        [TestParameters(LogicGates.Xnor, false, false, true, false)]
        [TestParameters(LogicGates.Xnor, false, true, false, false)]
        [TestParameters(LogicGates.Xnor, false, true, true, true)]
        [TestParameters(LogicGates.Xnor, true, false, false, false)]
        [TestParameters(LogicGates.Xnor, true, false, true, true)]
        [TestParameters(LogicGates.Xnor, true, true, false, true)]
        [TestParameters(LogicGates.Xnor, true, true, true, true)]
        [TestParameters((LogicGates) 42, false, false, false, false)]
        [TestParameters((LogicGates) 42, false, false, true, false)]
        [TestParameters((LogicGates) 42, false, true, false, false)]
        [TestParameters((LogicGates) 42, false, true, true, false)]
        [TestParameters((LogicGates) 42, true, false, false, false)]
        [TestParameters((LogicGates) 42, true, false, true, false)]
        [TestParameters((LogicGates) 42, true, true, false, false)]
        [TestParameters((LogicGates) 42, true, true, true, false)]
        void GetLogicByGate(LogicGates gate, Boolean input1, Boolean input2, Boolean input3, Boolean expected) {

            LogicGateConverter<Boolean> conv = new LogicGateConverter<Boolean>(gate, true, false);

            Test.IfNot.Object.IsNull(conv.Logic);

            Object result = conv.Convert(new Object[] { input1, input2, input3 }, default, default, default);

            Test.If.Value.IsEqual(result, expected);

        }

        #endregion

        #region Convert

        [TestMethod]
        void ConvertThrows() {

            GateLogic logic = new GateLogic((_) => throw new NotImplementedException());
            LogicGateConverter<Object> conv = new LogicGateConverter<Object>(logic, default, default);

            Test.If.Action.ThrowsException(() => conv.Convert(new Object[] { true }, default, default, default), out NotImplementedException ex);

        }

        [TestMethod]
        [TestData(nameof(ConvertData))]
        void Convert(GateLogic logic, Object[] input, Object expected) {

            LogicGateConverter<Boolean> conv = new LogicGateConverter<Boolean>(logic, true, false);
            Object result = default;

            Test.IfNot.Action.ThrowsException(() => result = conv.Convert(input, default, default, default), out Exception ex);

            Test.If.Value.IsEqual(result, expected);

        }

        IEnumerable<Object[]> ConvertData() {
            return new List<Object[]>() {
                new Object[] { new GateLogic((_) => throw new NotImplementedException()), new Object[0], DependencyProperty.UnsetValue },
                new Object[] { new GateLogic((_) => throw new NotImplementedException()), new Object[] { null, null }, DependencyProperty.UnsetValue },
                new Object[] { new GateLogic((_) => throw new NotImplementedException()), new Object[] { true, null }, DependencyProperty.UnsetValue },
                new Object[] { new GateLogic((_) => throw new NotImplementedException()), new Object[] { null, true }, DependencyProperty.UnsetValue },
                new Object[] { new GateLogic((_) => true), new Object[0], DependencyProperty.UnsetValue },
                new Object[] { new GateLogic((_) => true), new Object[] { null, null }, DependencyProperty.UnsetValue },
                new Object[] { new GateLogic((_) => true), new Object[] { true, null }, DependencyProperty.UnsetValue },
                new Object[] { new GateLogic((_) => true), new Object[] { null, true }, DependencyProperty.UnsetValue },
                new Object[] { new GateLogic((_) => true), new Object[] { 1, null }, DependencyProperty.UnsetValue },
                new Object[] { new GateLogic((_) => true), new Object[] { null, 1 }, DependencyProperty.UnsetValue },
                new Object[] { new GateLogic((_) => true), new Object[] { true, true }, true },
                new Object[] { new GateLogic((_) => false), new Object[] { true, true }, false },
                new Object[] { new GateLogic((_) => true), new Object[] { false, false }, true },
                new Object[] { new GateLogic((_) => false), new Object[] { false, false }, false },
            };
        }

        #endregion

        #region ConvertBack

        [TestMethod]
        [TestData(nameof(ConvertBackData))]
        void ConvertBack(GateLogic logic, Object input) {

            LogicGateConverter<Boolean> conv = new LogicGateConverter<Boolean>(logic, true, false);
            Object result = default;

            Test.IfNot.Action.ThrowsException(() => result = conv.ConvertBack(input, default, default, default), out Exception ex);

            Test.If.Object.IsNull(result);

        }

        IEnumerable<Object[]> ConvertBackData() {
            return new List<Object[]>() {
                new Object[] { new GateLogic((_) => throw new NotImplementedException()), null },
                new Object[] { new GateLogic((_) => throw new NotImplementedException()), new Object() },
                new Object[] { new GateLogic((_) => throw new NotImplementedException()), true },
                new Object[] { new GateLogic((_) => throw new NotImplementedException()), "Hello!" },
                new Object[] { new GateLogic((_) => true), null },
                new Object[] { new GateLogic((_) => true), new Object() },
                new Object[] { new GateLogic((_) => true), true },
                new Object[] { new GateLogic((_) => true), "Hello!" },
            };
        }

        #endregion

    }
}
