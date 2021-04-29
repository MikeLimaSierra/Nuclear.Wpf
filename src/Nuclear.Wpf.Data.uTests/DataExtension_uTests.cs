using System;
using System.Windows.Markup;

using Nuclear.TestSite;

namespace Nuclear.Wpf.Data {
    class DataExtension_uTests {

        [TestMethod]
        void Implementations() {

            Test.If.Type.IsSubClass<DataExtension<Object>, MarkupExtension>();

            Test.If.Type.IsSubClass<BooleanExtension, DataExtension<Boolean>>();
            Test.If.Type.IsSubClass<ByteExtension, DataExtension<Byte>>();
            Test.If.Type.IsSubClass<SByteExtension, DataExtension<SByte>>();
            Test.If.Type.IsSubClass<Int16Extension, DataExtension<Int16>>();
            Test.If.Type.IsSubClass<Int32Extension, DataExtension<Int32>>();
            Test.If.Type.IsSubClass<Int64Extension, DataExtension<Int64>>();
            Test.If.Type.IsSubClass<UInt16Extension, DataExtension<UInt16>>();
            Test.If.Type.IsSubClass<UInt32Extension, DataExtension<UInt32>>();
            Test.If.Type.IsSubClass<UInt64Extension, DataExtension<UInt64>>();
            Test.If.Type.IsSubClass<SingleExtensions, DataExtension<Single>>();
            Test.If.Type.IsSubClass<DoubleExtension, DataExtension<Double>>();
            Test.If.Type.IsSubClass<DecimalExtension, DataExtension<Decimal>>();

        }

        [TestMethod]
        [TestParameters(null)]
        [TestParameters(0.1d)]
        [TestParameters("Hello!")]
        void Ctor(Object value) {

            DataExtension<Object> data = default;

            Test.IfNot.Action.ThrowsException(() => data = new DataExtension<Object>(value), out Exception ex);

            Test.If.Value.IsEqual(data.Value, value);

        }

    }
}
