﻿using System;
using System.Linq;

using Nuclear.TestSite;
using Nuclear.Wpf.Data.ValueConverters.Base;

namespace Nuclear.Wpf.Data.ValueConverters {
    class Chain_uTests {

        [TestMethod]
        void Implementation() {

            Test.If.Type.IsSubClass<Chain, BaseValueConverter>();

        }

        [TestMethod]
        void Ctor_Params() {

            Link l1 = new Link();
            Link l2 = new Link();
            Link l3 = new Link();
            Link l4 = new Link();
            Link l5 = new Link();
            Link l6 = new Link();
            Link l7 = new Link();
            Link l8 = new Link();

            Chain chain = default;

            Test.IfNot.Action.ThrowsException(() => chain = new Chain(), out Exception ex);
            Test.If.Enumerable.Matches(chain.Links, Enumerable.Empty<Link>());

            Test.IfNot.Action.ThrowsException(() => chain = new Chain(new Link[] { l1 }), out ex);
            Test.If.Enumerable.Matches(chain.Links, new Link[] { l1 });

            Test.IfNot.Action.ThrowsException(() => chain = new Chain(new Link[] { l1, l2 }), out ex);
            Test.If.Enumerable.Matches(chain.Links, new Link[] { l1, l2 });

            Test.IfNot.Action.ThrowsException(() => chain = new Chain(new Link[] { l1, l2, l3 }), out ex);
            Test.If.Enumerable.Matches(chain.Links, new Link[] { l1, l2, l3 });

            Test.IfNot.Action.ThrowsException(() => chain = new Chain(new Link[] { l1, l2, l3, l4 }), out ex);
            Test.If.Enumerable.Matches(chain.Links, new Link[] { l1, l2, l3, l4 });

            Test.IfNot.Action.ThrowsException(() => chain = new Chain(new Link[] { l1, l2, l3, l4, l5 }), out ex);
            Test.If.Enumerable.Matches(chain.Links, new Link[] { l1, l2, l3, l4, l5 });

            Test.IfNot.Action.ThrowsException(() => chain = new Chain(new Link[] { l1, l2, l3, l4, l5, l6 }), out ex);
            Test.If.Enumerable.Matches(chain.Links, new Link[] { l1, l2, l3, l4, l5, l6 });

            Test.IfNot.Action.ThrowsException(() => chain = new Chain(new Link[] { l1, l2, l3, l4, l5, l6, l7 }), out ex);
            Test.If.Enumerable.Matches(chain.Links, new Link[] { l1, l2, l3, l4, l5, l6, l7 });

            Test.IfNot.Action.ThrowsException(() => chain = new Chain(new Link[] { l1, l2, l3, l4, l5, l6, l7, l8 }), out ex);
            Test.If.Enumerable.Matches(chain.Links, new Link[] { l1, l2, l3, l4, l5, l6, l7, l8 });


            Test.IfNot.Action.ThrowsException(() => chain = new Chain(l1), out ex);
            Test.If.Enumerable.Matches(chain.Links, new Link[] { l1 });

            Test.IfNot.Action.ThrowsException(() => chain = new Chain(l1, l2), out ex);
            Test.If.Enumerable.Matches(chain.Links, new Link[] { l1, l2 });

            Test.IfNot.Action.ThrowsException(() => chain = new Chain(l1, l2, l3), out ex);
            Test.If.Enumerable.Matches(chain.Links, new Link[] { l1, l2, l3 });

            Test.IfNot.Action.ThrowsException(() => chain = new Chain(l1, l2, l3, l4), out ex);
            Test.If.Enumerable.Matches(chain.Links, new Link[] { l1, l2, l3, l4 });

            Test.IfNot.Action.ThrowsException(() => chain = new Chain(l1, l2, l3, l4, l5), out ex);
            Test.If.Enumerable.Matches(chain.Links, new Link[] { l1, l2, l3, l4, l5 });

            Test.IfNot.Action.ThrowsException(() => chain = new Chain(l1, l2, l3, l4, l5, l6), out ex);
            Test.If.Enumerable.Matches(chain.Links, new Link[] { l1, l2, l3, l4, l5, l6 });

            Test.IfNot.Action.ThrowsException(() => chain = new Chain(l1, l2, l3, l4, l5, l6, l7), out ex);
            Test.If.Enumerable.Matches(chain.Links, new Link[] { l1, l2, l3, l4, l5, l6, l7 });

            Test.IfNot.Action.ThrowsException(() => chain = new Chain(l1, l2, l3, l4, l5, l6, l7, l8), out ex);
            Test.If.Enumerable.Matches(chain.Links, new Link[] { l1, l2, l3, l4, l5, l6, l7, l8 });

        }

    }
}
