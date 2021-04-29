using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

using Nuclear.TestSite;
using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {
    class NullableBooleanConverter_uTests {

        [TestMethod]
        void Implementations() {

            Test.If.Type.IsSubClass<NullableBooleanConverter<Object>, BaseValueConverter>();

            Test.If.Type.IsSubClass<NullableBooleanToBooleanConverter, NullableBooleanConverter<Boolean>>();
            Test.If.Type.IsSubClass<NullableBooleanToStringConverter, NullableBooleanConverter<String>>();
            Test.If.Type.IsSubClass<NullableBooleanToColorConverter, NullableBooleanConverter<Color>>();
            Test.If.Type.IsSubClass<NullableBooleanToBrushConverter, NullableBooleanConverter<Brush>>();
            Test.If.Type.IsSubClass<NullableBooleanToVisibilityConverter, NullableBooleanConverter<Visibility>>();
            Test.If.Type.IsSubClass<NullableBooleanToGridLengthConverter, NullableBooleanConverter<GridLength>>();

        }

        [TestMethod]
        [TestData(nameof(DefaultsData))]
        void Defaults<TConv, TValue>(TValue @true, TValue @false, TValue @null)
            where TConv : NullableBooleanConverter<TValue>, new() {

            TConv conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new TConv(), out Exception ex);

            Test.If.Value.IsEqual(conv.True, @true);
            Test.If.Value.IsEqual(conv.False, @false);
            Test.If.Value.IsEqual(conv.Null, @null);

        }

        IEnumerable<Object[]> DefaultsData() {
            return new List<Object[]>() {
                new Object[] { typeof(NullableBooleanToBooleanConverter), typeof(Boolean), true, false, false },
                new Object[] { typeof(NullableBooleanToStringConverter), typeof(String), "true", "false", "null" },
                new Object[] { typeof(NullableBooleanToColorConverter), typeof(Color), Colors.Green, Colors.Red, Colors.Yellow },
                new Object[] { typeof(NullableBooleanToBrushConverter), typeof(Brush), Brushes.Green, Brushes.Red, Brushes.Yellow },
                new Object[] { typeof(NullableBooleanToVisibilityConverter), typeof(Visibility), Visibility.Visible, Visibility.Collapsed, Visibility.Hidden },
                new Object[] { typeof(NullableBooleanToGridLengthConverter), typeof(GridLength), new GridLength(1, GridUnitType.Star), GridLength.Auto, GridLength.Auto },
            };
        }

        #region ctor

        [TestMethod]
        [TestData(nameof(CtorData))]
        void Ctor(String @true, String @false, String @null) {

            NullableBooleanConverter<String> conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new NullableBooleanConverter<String>(@true, @false, @null), out Exception ex);

            Test.If.Value.IsEqual(conv.True, @true);
            Test.If.Value.IsEqual(conv.False, @false);
            Test.If.Value.IsEqual(conv.Null, @null);

        }

        IEnumerable<Object[]> CtorData() {
            return new List<Object[]>() {
                new Object[] { null, null, null },
                new Object[] { null, null, "null" },
                new Object[] { null, "false", null },
                new Object[] { "true", null, null },
                new Object[] { "", "", "" },
                new Object[] { "", "", "null" },
                new Object[] { "", "false", "" },
                new Object[] { "true", "", "" },
                new Object[] { " ", " ", " " },
                new Object[] { " ", " ", "null" },
                new Object[] { " ", "false", " " },
                new Object[] { "true", " ", " " },
                new Object[] { "true", "false", "null" },
            };
        }

        #endregion

        #region properties

        [TestMethod]
        [TestData(nameof(TrueData))]
        void True(String @true) {

            NullableBooleanConverter<String> conv = new NullableBooleanConverter<String>("true", "false", "null");

            Test.IfNot.Action.ThrowsException(() => conv.True = @true, out Exception ex);

            Test.If.Value.IsEqual(conv.True, @true);

        }

        IEnumerable<Object[]> TrueData() {
            return new List<Object[]>() {
                new Object[] { null },
                new Object[] { "" },
                new Object[] { " " },
                new Object[] { "true" },
                new Object[] { "false" },
            };
        }

        [TestMethod]
        [TestData(nameof(FalseData))]
        void False(String @false) {

            NullableBooleanConverter<String> conv = new NullableBooleanConverter<String>("true", "false", "null");

            Test.IfNot.Action.ThrowsException(() => conv.False = @false, out Exception ex);

            Test.If.Value.IsEqual(conv.False, @false);

        }

        IEnumerable<Object[]> FalseData() {
            return new List<Object[]>() {
                new Object[] { null },
                new Object[] { "" },
                new Object[] { " " },
                new Object[] { "true" },
                new Object[] { "false" },
            };
        }

        [TestMethod]
        [TestData(nameof(NullData))]
        void Null(String @null) {

            NullableBooleanConverter<String> conv = new NullableBooleanConverter<String>("true", "false", "null");

            Test.IfNot.Action.ThrowsException(() => conv.Null = @null, out Exception ex);

            Test.If.Value.IsEqual(conv.Null, @null);

        }

        IEnumerable<Object[]> NullData() {
            return new List<Object[]>() {
                new Object[] { null },
                new Object[] { "" },
                new Object[] { " " },
                new Object[] { "true" },
                new Object[] { "false" },
            };
        }

        #endregion

        #region Convert

        [TestMethod]
        [TestData(nameof(ConvertData))]
        void Convert(Object input, Object expected) {

            NullableBooleanConverter<String> conv = new NullableBooleanConverter<String>("true", "false", "null");
            Object result = default;

            Test.IfNot.Action.ThrowsException(() => result = conv.Convert(input, default, default, default), out Exception ex);

            Test.If.Value.IsEqual(result, expected);

        }

        IEnumerable<Object[]> ConvertData() {
            return new List<Object[]>() {
                new Object[] { null, "null" },
                new Object[] { 1, DependencyProperty.UnsetValue },
                new Object[] { false, "false" },
                new Object[] { true, "true" },
            };
        }

        #endregion

        #region ConvertBack

        [TestMethod]
        [TestData(nameof(ConvertBackData))]
        void ConvertBack(Object input, Object expected) {

            NullableBooleanConverter<String> conv = new NullableBooleanConverter<String>("true", "false", "null");
            Object result = default;

            Test.IfNot.Action.ThrowsException(() => result = conv.ConvertBack(input, default, default, default), out Exception ex);

            Test.If.Value.IsEqual(result, expected);

        }

        IEnumerable<Object[]> ConvertBackData() {
            return new List<Object[]>() {
                new Object[] { "null", null },
                new Object[] { 1, DependencyProperty.UnsetValue },
                new Object[] { "false", false },
                new Object[] { "true", true },
            };
        }

        #endregion

    }
}
