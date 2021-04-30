using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

using Nuclear.TestSite;

namespace Nuclear.Wpf.Data.ValueConverters {
    class Link_uTests {

        #region properties

        [TestMethod]
        [TestData(nameof(ConverterData))]
        void Converter(IValueConverter converter) {

            Link link = new Link();

            Test.IfNot.Action.ThrowsException(() => link.Converter = converter, out Exception ex);

            Test.If.Reference.IsEqual(link.Converter, converter);

        }

        IEnumerable<Object[]> ConverterData() {
            return new List<Object[]>() {
                new Object[] { null },
                new Object[] { new InvertedBooleanConverter() },
                new Object[] { new NullToColorConverter() },
            };
        }

        [TestMethod]
        [TestData(nameof(ParameterData))]
        void Parameter(Object parameter) {

            Link link = new Link();

            Test.IfNot.Action.ThrowsException(() => link.Parameter = parameter, out Exception ex);

            Test.If.Reference.IsEqual(link.Parameter, parameter);

        }

        IEnumerable<Object[]> ParameterData() {
            return new List<Object[]>() {
                new Object[] { null },
                new Object[] { "" },
                new Object[] { " " },
                new Object[] { "true" },
                new Object[] { 1 },
                new Object[] { new Object() },
            };
        }

        [TestMethod]
        [TestData(nameof(CultureData))]
        void Culture(CultureInfo culture) {

            Link link = new Link();

            Test.IfNot.Action.ThrowsException(() => link.Culture = culture, out Exception ex);

            Test.If.Reference.IsEqual(link.Culture, culture);

        }

        IEnumerable<Object[]> CultureData() {
            return new List<Object[]>() {
                new Object[] { null },
                new Object[] { CultureInfo.InvariantCulture },
                new Object[] { CultureInfo.CurrentCulture },
                new Object[] { CultureInfo.GetCultureInfo("en-us") },
                new Object[] { CultureInfo.GetCultureInfo("de-de") },
            };
        }

        #endregion

    }
}
