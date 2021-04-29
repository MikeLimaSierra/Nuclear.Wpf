using System.Windows.Data;
using System.Windows.Markup;

using Nuclear.TestSite;

namespace Nuclear.Wpf.Data.ValueConverters.Base {
    class BaseValueConverter_uTests {

        [TestMethod]
        void Implementation() {

            Test.If.Type.IsSubClass<BaseValueConverter, MarkupExtension>();
            Test.If.Type.Implements<BaseValueConverter, IValueConverter>();

        }

    }
}
