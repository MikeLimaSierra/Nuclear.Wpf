using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

using Nuclear.TestSite;
using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {
    class StringConverter_uTests {

        [TestMethod]
        void Implementation() {

            Test.If.Type.IsSubClass<StringConverter<Object>, BaseValueConverter>();

            Test.If.Type.IsSubClass<StringToBooleanConverter, StringConverter<Boolean>>();
            Test.If.Type.IsSubClass<StringToStringConverter, StringConverter<String>>();
            Test.If.Type.IsSubClass<StringToColorConverter, StringConverter<Color>>();
            Test.If.Type.IsSubClass<StringToBrushConverter, StringConverter<Brush>>();
            Test.If.Type.IsSubClass<StringToVisibilityConverter, StringConverter<Visibility>>();
            Test.If.Type.IsSubClass<StringToGridLengthConverter, StringConverter<GridLength>>();

        }

        [TestMethod]
        [TestData(nameof(DefaultsData))]
        void Defaults<TConv, TValue>(TValue @null, TValue empty, TValue whiteSpace, TValue hasValue)
            where TConv : StringConverter<TValue>, new() {

            TConv conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new TConv(), out Exception ex);

            Test.If.Value.IsEqual(conv.Null, @null);
            Test.If.Value.IsEqual(conv.Empty, empty);
            Test.If.Value.IsEqual(conv.WhiteSpace, whiteSpace);
            Test.If.Value.IsEqual(conv.HasValue, hasValue);

        }

        IEnumerable<Object[]> DefaultsData() {
            return new List<Object[]>() {
                new Object[] { typeof(StringToBooleanConverter), typeof(Boolean), false, false, false, true },
                new Object[] { typeof(StringToStringConverter), typeof(String), "null", "empty", "white-space", "has value" },
                new Object[] { typeof(StringToColorConverter), typeof(Color), Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green },
                new Object[] { typeof(StringToBrushConverter), typeof(Brush), Brushes.Red, Brushes.Orange, Brushes.Yellow, Brushes.Green },
                new Object[] { typeof(StringToVisibilityConverter), typeof(Visibility), Visibility.Collapsed, Visibility.Collapsed, Visibility.Collapsed, Visibility.Visible },
                new Object[] { typeof(StringToGridLengthConverter), typeof(GridLength), GridLength.Auto, GridLength.Auto, GridLength.Auto, new GridLength(1, GridUnitType.Star) },
            };
        }

        #region ctor

        [TestMethod]
        [TestData(nameof(CtorData))]
        void Ctor(String @null, String empty, String whiteSpace, String hasValue) {

            StringConverter<String> conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new StringConverter<String>(@null, empty, whiteSpace, hasValue), out Exception ex);

            Test.If.Value.IsEqual(conv.Null, @null);
            Test.If.Value.IsEqual(conv.Empty, empty);
            Test.If.Value.IsEqual(conv.WhiteSpace, whiteSpace);
            Test.If.Value.IsEqual(conv.HasValue, hasValue);

        }

        IEnumerable<Object[]> CtorData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, null },
                new Object[] { null, null, null, "has value" },
                new Object[] { null, null, "white-space", null },
                new Object[] { null, "empty", null, null },
                new Object[] { "null", null, null, null },
                new Object[] { "", "", "", "" },
                new Object[] { "", "", "", "has value" },
                new Object[] { "", "", "white-space", "" },
                new Object[] { "", "empty", "", "" },
                new Object[] { "null", "", "", "" },
                new Object[] { " ", " ", " ", " " },
                new Object[] { " ", " ", " ", "has value" },
                new Object[] { " ", " ", "white-space", " " },
                new Object[] { " ", "empty", " ", " " },
                new Object[] { "null", " ", " ", " " },
                new Object[] { "null", "empty", "white-space", "has value" },
            };
        }

        #endregion

        #region properties

        [TestMethod]
        [TestData(nameof(NullData))]
        void Null(String @null) {

            StringConverter<String> conv = new StringConverter<String>("null", "empty", "white-space", "has value");

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

        [TestMethod]
        [TestData(nameof(EmptyData))]
        void Empty(String empty) {

            StringConverter<String> conv = new StringConverter<String>("null", "empty", "white-space", "has value");

            Test.IfNot.Action.ThrowsException(() => conv.Empty = empty, out Exception ex);

            Test.If.Value.IsEqual(conv.Empty, empty);

        }

        IEnumerable<Object[]> EmptyData() {
            return new List<Object[]>() {
                new Object[] { null },
                new Object[] { "" },
                new Object[] { " " },
                new Object[] { "true" },
                new Object[] { "false" },
            };
        }

        [TestMethod]
        [TestData(nameof(WhiteSpaceData))]
        void WhiteSpace(String whiteSpace) {

            StringConverter<String> conv = new StringConverter<String>("null", "empty", "white-space", "has value");

            Test.IfNot.Action.ThrowsException(() => conv.WhiteSpace = whiteSpace, out Exception ex);

            Test.If.Value.IsEqual(conv.WhiteSpace, whiteSpace);

        }

        IEnumerable<Object[]> WhiteSpaceData() {
            return new List<Object[]>() {
                new Object[] { null },
                new Object[] { "" },
                new Object[] { " " },
                new Object[] { "true" },
                new Object[] { "false" },
            };
        }

        [TestMethod]
        [TestData(nameof(HasValueData))]
        void HasValue(String hasValue) {

            StringConverter<String> conv = new StringConverter<String>("null", "empty", "white-space", "has value");

            Test.IfNot.Action.ThrowsException(() => conv.HasValue = hasValue, out Exception ex);

            Test.If.Value.IsEqual(conv.HasValue, hasValue);

        }

        IEnumerable<Object[]> HasValueData() {
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

            StringConverter<String> conv = new StringConverter<String>("null", "empty", "white-space", "has value");
            Object result = default;

            Test.IfNot.Action.ThrowsException(() => result = conv.Convert(input, default, default, default), out Exception ex);

            Test.If.Value.IsEqual(result, expected);

        }

        IEnumerable<Object[]> ConvertData() {
            return new List<Object[]>() {
                new Object[] { null, "null" },
                new Object[] { 1, DependencyProperty.UnsetValue },
                new Object[] { "", "empty" },
                new Object[] { " ", "white-space" },
                new Object[] { "Hello", "has value" },
                new Object[] { " Hello ", "has value" },
            };
        }

        #endregion

        #region ConvertBack

        [TestMethod]
        [TestData(nameof(ConvertBackData))]
        void ConvertBack(Object input, Object expected) {

            StringConverter<String> conv = new StringConverter<String>("null", "empty", "white-space", "has value");
            Object result = default;

            Test.IfNot.Action.ThrowsException(() => result = conv.ConvertBack(input, default, default, default), out Exception ex);

            Test.If.Value.IsEqual(result, expected);

        }

        IEnumerable<Object[]> ConvertBackData() {
            return new List<Object[]>() {
                new Object[] { "null", DependencyProperty.UnsetValue },
                new Object[] { 1, DependencyProperty.UnsetValue },
                new Object[] { "empty", DependencyProperty.UnsetValue },
                new Object[] { "white-space", DependencyProperty.UnsetValue },
                new Object[] { "has value", DependencyProperty.UnsetValue },
            };
        }

        #endregion

    }
}
