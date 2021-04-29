
using System;
using System.Collections.Generic;
using System.Windows;

using Nuclear.TestSite;
using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {
    class NoOpConverter_uTests {

        [TestMethod]
        void Implementation() {

            Test.If.Type.IsSubClass<NoOpConverter, BaseValueConverter>();

        }

        #region Convert

        [TestMethod]
        [TestData(nameof(ConvertData))]
        void Convert(Object input, Object expected) {

            NoOpConverter conv = new NoOpConverter();
            Object result = default;

            Test.IfNot.Action.ThrowsException(() => result = conv.Convert(input, default, default, default), out Exception ex);

            Test.If.Value.IsEqual(result, expected);

        }

        IEnumerable<Object[]> ConvertData() {
            Object obj = new Object();

            return new List<Object[]>() {
                new Object[] { null, null },
                new Object[] { 1, 1 },
                new Object[] { 1, 1 },
                new Object[] { "", "" },
                new Object[] { " ", " " },
                new Object[] { "Hello", "Hello" },
                new Object[] { obj, obj },
                new Object[] { DependencyProperty.UnsetValue, DependencyProperty.UnsetValue },
            };
        }

        #endregion

        #region ConvertBack

        [TestMethod]
        [TestData(nameof(ConvertBackData))]
        void ConvertBack(Object input, Object expected) {

            NoOpConverter conv = new NoOpConverter();
            Object result = default;

            Test.IfNot.Action.ThrowsException(() => result = conv.ConvertBack(input, default, default, default), out Exception ex);

            Test.If.Value.IsEqual(result, expected);

        }

        IEnumerable<Object[]> ConvertBackData() {
            Object obj = new Object();

            return new List<Object[]>() {
                new Object[] { null, null },
                new Object[] { 1, 1 },
                new Object[] { 1, 1 },
                new Object[] { "", "" },
                new Object[] { " ", " " },
                new Object[] { "Hello", "Hello" },
                new Object[] { obj, obj },
                new Object[] { DependencyProperty.UnsetValue, DependencyProperty.UnsetValue },
            };
        }

        #endregion

    }
}
