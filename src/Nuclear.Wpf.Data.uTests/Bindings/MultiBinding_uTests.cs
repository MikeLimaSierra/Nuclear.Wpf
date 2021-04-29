using System;
using System.Linq;

using Nuclear.TestSite;
using Nuclear.Wpf.Data.Bindings;

using B = System.Windows.Data.Binding;

namespace Nuclear.Wpf.DataBinding.Bindings {
    class MultiBinding_uTests {

        [TestMethod]
        void Implementation() {

            Test.If.Type.IsSubClass<MultiBinding, System.Windows.Data.MultiBinding>();

        }

        [TestMethod]
        void Ctor_Params() {

            B b1 = new B();
            B b2 = new B();
            B b3 = new B();
            B b4 = new B();
            B b5 = new B();
            B b6 = new B();
            B b7 = new B();
            B b8 = new B();

            MultiBinding mBinding = default;

            Test.IfNot.Action.ThrowsException(() => mBinding = new MultiBinding(), out Exception ex);
            Test.If.Enumerable.Matches(mBinding.Bindings, Enumerable.Empty<B>());

            Test.IfNot.Action.ThrowsException(() => mBinding = new MultiBinding(new B[] { b1 }), out ex);
            Test.If.Enumerable.Matches(mBinding.Bindings, new B[] { b1 });

            Test.IfNot.Action.ThrowsException(() => mBinding = new MultiBinding(new B[] { b1, b2 }), out ex);
            Test.If.Enumerable.Matches(mBinding.Bindings, new B[] { b1, b2 });

            Test.IfNot.Action.ThrowsException(() => mBinding = new MultiBinding(new B[] { b1, b2, b3 }), out ex);
            Test.If.Enumerable.Matches(mBinding.Bindings, new B[] { b1, b2, b3 });

            Test.IfNot.Action.ThrowsException(() => mBinding = new MultiBinding(new B[] { b1, b2, b3, b4 }), out ex);
            Test.If.Enumerable.Matches(mBinding.Bindings, new B[] { b1, b2, b3, b4 });

            Test.IfNot.Action.ThrowsException(() => mBinding = new MultiBinding(new B[] { b1, b2, b3, b4, b5 }), out ex);
            Test.If.Enumerable.Matches(mBinding.Bindings, new B[] { b1, b2, b3, b4, b5 });

            Test.IfNot.Action.ThrowsException(() => mBinding = new MultiBinding(new B[] { b1, b2, b3, b4, b5, b6 }), out ex);
            Test.If.Enumerable.Matches(mBinding.Bindings, new B[] { b1, b2, b3, b4, b5, b6 });

            Test.IfNot.Action.ThrowsException(() => mBinding = new MultiBinding(new B[] { b1, b2, b3, b4, b5, b6, b7 }), out ex);
            Test.If.Enumerable.Matches(mBinding.Bindings, new B[] { b1, b2, b3, b4, b5, b6, b7 });

            Test.IfNot.Action.ThrowsException(() => mBinding = new MultiBinding(new B[] { b1, b2, b3, b4, b5, b6, b7, b8 }), out ex);
            Test.If.Enumerable.Matches(mBinding.Bindings, new B[] { b1, b2, b3, b4, b5, b6, b7, b8 });


            Test.IfNot.Action.ThrowsException(() => mBinding = new MultiBinding(b1), out ex);
            Test.If.Enumerable.Matches(mBinding.Bindings, new B[] { b1 });

            Test.IfNot.Action.ThrowsException(() => mBinding = new MultiBinding(b1, b2), out ex);
            Test.If.Enumerable.Matches(mBinding.Bindings, new B[] { b1, b2 });

            Test.IfNot.Action.ThrowsException(() => mBinding = new MultiBinding(b1, b2, b3), out ex);
            Test.If.Enumerable.Matches(mBinding.Bindings, new B[] { b1, b2, b3 });

            Test.IfNot.Action.ThrowsException(() => mBinding = new MultiBinding(b1, b2, b3, b4), out ex);
            Test.If.Enumerable.Matches(mBinding.Bindings, new B[] { b1, b2, b3, b4 });

            Test.IfNot.Action.ThrowsException(() => mBinding = new MultiBinding(b1, b2, b3, b4, b5), out ex);
            Test.If.Enumerable.Matches(mBinding.Bindings, new B[] { b1, b2, b3, b4, b5 });

            Test.IfNot.Action.ThrowsException(() => mBinding = new MultiBinding(b1, b2, b3, b4, b5, b6), out ex);
            Test.If.Enumerable.Matches(mBinding.Bindings, new B[] { b1, b2, b3, b4, b5, b6 });

            Test.IfNot.Action.ThrowsException(() => mBinding = new MultiBinding(b1, b2, b3, b4, b5, b6, b7), out ex);
            Test.If.Enumerable.Matches(mBinding.Bindings, new B[] { b1, b2, b3, b4, b5, b6, b7 });

            Test.IfNot.Action.ThrowsException(() => mBinding = new MultiBinding(b1, b2, b3, b4, b5, b6, b7, b8), out ex);
            Test.If.Enumerable.Matches(mBinding.Bindings, new B[] { b1, b2, b3, b4, b5, b6, b7, b8 });

        }

    }
}
