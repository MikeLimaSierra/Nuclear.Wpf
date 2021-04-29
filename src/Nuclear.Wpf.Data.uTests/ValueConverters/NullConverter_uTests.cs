using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

using Nuclear.TestSite;
using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {
    class NullConverter_uTests {

        [TestMethod]
        void Implementations() {

            Test.If.Type.IsSubClass<NullConverter<Object>, BaseValueConverter>();

            Test.If.Type.IsSubClass<NullToBooleanConverter, NullConverter<Boolean>>();
            Test.If.Type.IsSubClass<NullToStringConverter, NullConverter<String>>();
            Test.If.Type.IsSubClass<NullToColorConverter, NullConverter<Color>>();
            Test.If.Type.IsSubClass<NullToBrushConverter, NullConverter<Brush>>();
            Test.If.Type.IsSubClass<NullToVisibilityConverter, NullConverter<Visibility>>();
            Test.If.Type.IsSubClass<NullToGridLengthConverter, NullConverter<GridLength>>();

        }

        [TestMethod]
        [TestData(nameof(DefaultsData))]
        void Defaults<TConv, TValue>(TValue @null, TValue notNull)
            where TConv : NullConverter<TValue>, new() {

            TConv conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new TConv(), out Exception ex);

            Test.If.Value.IsEqual(conv.Null, @null);
            Test.If.Value.IsEqual(conv.NotNull, notNull);

        }

        IEnumerable<Object[]> DefaultsData() {
            return new List<Object[]>() {
                new Object[] { typeof(NullToBooleanConverter), typeof(Boolean), false, true },
                new Object[] { typeof(NullToStringConverter), typeof(String), "null", "not null" },
                new Object[] { typeof(NullToColorConverter), typeof(Color), Colors.Red, Colors.Green },
                new Object[] { typeof(NullToBrushConverter), typeof(Brush), Brushes.Red, Brushes.Green },
                new Object[] { typeof(NullToVisibilityConverter), typeof(Visibility), Visibility.Collapsed, Visibility.Visible },
                new Object[] { typeof(NullToGridLengthConverter), typeof(GridLength), GridLength.Auto, new GridLength(1, GridUnitType.Star) },
            };
        }

        #region ctor

        [TestMethod]
        [TestData(nameof(CtorData))]
        void Ctor(String @null, String notNull) {

            NullConverter<String> conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new NullConverter<String>(@null, notNull), out Exception ex);

            Test.If.Value.IsEqual(conv.Null, @null);
            Test.If.Value.IsEqual(conv.NotNull, notNull);

        }

        IEnumerable<Object[]> CtorData() {
            return new List<Object[]>() {
                new Object[] { null, null },
                new Object[] { null, "true" },
                new Object[] { "true", null },
                new Object[] { "true", "" },
                new Object[] { "", "true" },
                new Object[] { "true", " " },
                new Object[] { " ", "true" },
                new Object[] { "true", "false" },
                new Object[] { "false", "true" },
            };
        }

        #endregion

        #region properties

        [TestMethod]
        [TestData(nameof(NullData))]
        void Null(String @null) {

            NullConverter<String> conv = new NullConverter<String>("true", "false");

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
        [TestData(nameof(NotNullData))]
        void NotNull(String notNull) {

            NullConverter<String> conv = new NullConverter<String>("true", "false");

            Test.IfNot.Action.ThrowsException(() => conv.NotNull = notNull, out Exception ex);

            Test.If.Value.IsEqual(conv.NotNull, notNull);

        }

        IEnumerable<Object[]> NotNullData() {
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

            NullConverter<Boolean> conv = new NullConverter<Boolean>(true, false);
            Object result = default;

            Test.IfNot.Action.ThrowsException(() => result = conv.Convert(input, default, default, default), out Exception ex);

            Test.If.Value.IsEqual(result, expected);

        }

        IEnumerable<Object[]> ConvertData() {
            return new List<Object[]>() {
                new Object[] { null, true },
                new Object[] { 1, false },
                new Object[] { false, false },
                new Object[] { true, false },
            };
        }

        #endregion

        #region ConvertBack

        [TestMethod]
        [TestData(nameof(ConvertBackData))]
        void ConvertBack(Object input, Object expected) {

            NullConverter<Boolean> conv = new NullConverter<Boolean>(true, false);
            Object result = default;

            Test.IfNot.Action.ThrowsException(() => result = conv.ConvertBack(input, default, default, default), out Exception ex);

            Test.If.Value.IsEqual(result, expected);

        }

        IEnumerable<Object[]> ConvertBackData() {
            return new List<Object[]>() {
                new Object[] { null, DependencyProperty.UnsetValue },
                new Object[] { 1, DependencyProperty.UnsetValue },
                new Object[] { false, DependencyProperty.UnsetValue },
                new Object[] { true, DependencyProperty.UnsetValue },
            };
        }

        #endregion

    }
}
