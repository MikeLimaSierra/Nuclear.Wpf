using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

using Nuclear.TestSite;
using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {
    class BooleanConverter_uTests {

        [TestMethod]
        void Implementations() {

            Test.If.Type.IsSubClass<BooleanConverter<Object>, BaseValueConverter>();

            Test.If.Type.IsSubClass<InvertedBooleanConverter, BooleanConverter<Boolean>>();
            Test.If.Type.IsSubClass<BooleanToStringConverter, BooleanConverter<String>>();
            Test.If.Type.IsSubClass<BooleanToColorConverter, BooleanConverter<Color>>();
            Test.If.Type.IsSubClass<BooleanToBrushConverter, BooleanConverter<Brush>>();
            Test.If.Type.IsSubClass<BooleanToVisibilityConverter, BooleanConverter<Visibility>>();
            Test.If.Type.IsSubClass<BooleanToGridLengthConverter, BooleanConverter<GridLength>>();

        }

        [TestMethod]
        [TestData(nameof(DefaultsData))]
        void Defaults<TConv, TValue>(TValue @true, TValue @false)
            where TConv : BooleanConverter<TValue>, new() {

            TConv conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new TConv(), out Exception ex);

            Test.If.Value.IsEqual(conv.True, @true);
            Test.If.Value.IsEqual(conv.False, @false);

        }

        IEnumerable<Object[]> DefaultsData() {
            return new List<Object[]>() {
                new Object[] { typeof(InvertedBooleanConverter), typeof(Boolean), false, true },
                new Object[] { typeof(BooleanToStringConverter), typeof(String), "true", "false" },
                new Object[] { typeof(BooleanToColorConverter), typeof(Color), Colors.Green, Colors.Red },
                new Object[] { typeof(BooleanToBrushConverter), typeof(Brush), Brushes.Green, Brushes.Red },
                new Object[] { typeof(BooleanToVisibilityConverter), typeof(Visibility), Visibility.Visible, Visibility.Collapsed },
                new Object[] { typeof(BooleanToGridLengthConverter), typeof(GridLength), new GridLength(1, GridUnitType.Star), GridLength.Auto },
            };
        }

        #region ctor

        [TestMethod]
        [TestData(nameof(CtorData))]
        void Ctor(String @true, String @false) {

            BooleanConverter<String> conv = default;

            Test.IfNot.Action.ThrowsException(() => conv = new BooleanConverter<String>(@true, @false), out Exception ex);

            Test.If.Value.IsEqual(conv.True, @true);
            Test.If.Value.IsEqual(conv.False, @false);

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
        [TestData(nameof(TrueData))]
        void True(String @true) {

            BooleanConverter<String> conv = new BooleanConverter<String>("true", "false");

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

            BooleanConverter<String> conv = new BooleanConverter<String>("true", "false");

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

        #endregion

        #region Convert

        [TestMethod]
        [TestData(nameof(ConvertData))]
        void Convert(Object input, Object expected) {

            BooleanConverter<Boolean> conv = new BooleanConverter<Boolean>(true, false);
            Object result = default;

            Test.IfNot.Action.ThrowsException(() => result = conv.Convert(input, default, default, default), out Exception ex);

            Test.If.Value.IsEqual(result, expected);

        }

        IEnumerable<Object[]> ConvertData() {
            return new List<Object[]>() {
                new Object[] { null, DependencyProperty.UnsetValue },
                new Object[] { 1, DependencyProperty.UnsetValue },
                new Object[] { false, false },
                new Object[] { true, true },
            };
        }

        #endregion

        #region ConvertBack

        [TestMethod]
        [TestData(nameof(ConvertBackData))]
        void ConvertBack(Object input, Object expected) {

            BooleanConverter<Boolean> conv = new BooleanConverter<Boolean>(true, false);
            Object result = default;

            Test.IfNot.Action.ThrowsException(() => result = conv.ConvertBack(input, default, default, default), out Exception ex);

            Test.If.Value.IsEqual(result, expected);

        }

        IEnumerable<Object[]> ConvertBackData() {
            return new List<Object[]>() {
                new Object[] { null, DependencyProperty.UnsetValue },
                new Object[] { 1, DependencyProperty.UnsetValue },
                new Object[] { false, false },
                new Object[] { true, true },
            };
        }

        #endregion

    }
}
