using System.Windows.Data;
using System.Windows.Markup;

using Nuclear.TestSite;

namespace Nuclear.Wpf.Data.MultiValueConverters.Base {
    class BaseMultiValueConverter_uTests {

        [TestMethod]
        void Implementation() {

            Test.If.Type.IsSubClass<BaseMultiValueConverter, MarkupExtension>();
            Test.If.Type.Implements<BaseMultiValueConverter, IMultiValueConverter>();

        }

    }
}
