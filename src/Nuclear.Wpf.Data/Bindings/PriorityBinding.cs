using System;

using BB = System.Windows.Data.BindingBase;

namespace Nuclear.Wpf.Data.Bindings {

    /// <summary>
    /// Extends <see cref="System.Windows.Data.PriorityBinding"/> with parameterized constructors.
    /// </summary>
    public class PriorityBinding : System.Windows.Data.PriorityBinding {

        #region ctors

        /// <summary>
        /// Creates a new instance of <see cref="PriorityBinding"/>.
        /// </summary>
        /// <param name="bindings">The initial range of bindings.</param>
        public PriorityBinding(params BB[] bindings) {
            Array.ForEach(bindings, _ => Bindings.Add(_));
        }

        /// <summary>
        /// Creates a new instance of <see cref="PriorityBinding"/>.
        /// </summary>
        /// <param name="b1">The first binding.</param>
        public PriorityBinding(BB b1) : this(new BB[] { b1 }) { }

        /// <summary>
        /// Creates a new instance of <see cref="PriorityBinding"/>.
        /// </summary>
        /// <param name="b1">The first binding.</param>
        /// <param name="b2">The second binding.</param>
        public PriorityBinding(BB b1, BB b2) : this(new BB[] { b1, b2 }) { }

        /// <summary>
        /// Creates a new instance of <see cref="PriorityBinding"/>.
        /// </summary>
        /// <param name="b1">The first binding.</param>
        /// <param name="b2">The second binding.</param>
        /// <param name="b3">The third binding.</param>
        public PriorityBinding(BB b1, BB b2, BB b3) : this(new BB[] { b1, b2, b3 }) { }

        /// <summary>
        /// Creates a new instance of <see cref="PriorityBinding"/>.
        /// </summary>
        /// <param name="b1">The first binding.</param>
        /// <param name="b2">The second binding.</param>
        /// <param name="b3">The third binding.</param>
        /// <param name="b4">The fourth binding.</param>
        public PriorityBinding(BB b1, BB b2, BB b3, BB b4) : this(new BB[] { b1, b2, b3, b4 }) { }

        /// <summary>
        /// Creates a new instance of <see cref="PriorityBinding"/>.
        /// </summary>
        /// <param name="b1">The first binding.</param>
        /// <param name="b2">The second binding.</param>
        /// <param name="b3">The third binding.</param>
        /// <param name="b4">The fourth binding.</param>
        /// <param name="b5">The fifth binding.</param>
        public PriorityBinding(BB b1, BB b2, BB b3, BB b4, BB b5) : this(new BB[] { b1, b2, b3, b4, b5 }) { }

        /// <summary>
        /// Creates a new instance of <see cref="PriorityBinding"/>.
        /// </summary>
        /// <param name="b1">The first binding.</param>
        /// <param name="b2">The second binding.</param>
        /// <param name="b3">The third binding.</param>
        /// <param name="b4">The fourth binding.</param>
        /// <param name="b5">The fifth binding.</param>
        /// <param name="b6">The sixth binding.</param>
        public PriorityBinding(BB b1, BB b2, BB b3, BB b4, BB b5, BB b6) : this(new BB[] { b1, b2, b3, b4, b5, b6 }) { }

        /// <summary>
        /// Creates a new instance of <see cref="PriorityBinding"/>.
        /// </summary>
        /// <param name="b1">The first binding.</param>
        /// <param name="b2">The second binding.</param>
        /// <param name="b3">The third binding.</param>
        /// <param name="b4">The fourth binding.</param>
        /// <param name="b5">The fifth binding.</param>
        /// <param name="b6">The sixth binding.</param>
        /// <param name="b7">The seventh binding.</param>
        public PriorityBinding(BB b1, BB b2, BB b3, BB b4, BB b5, BB b6, BB b7) : this(new BB[] { b1, b2, b3, b4, b5, b6, b7 }) { }

        /// <summary>
        /// Creates a new instance of <see cref="PriorityBinding"/>.
        /// </summary>
        /// <param name="b1">The first binding.</param>
        /// <param name="b2">The second binding.</param>
        /// <param name="b3">The third binding.</param>
        /// <param name="b4">The fourth binding.</param>
        /// <param name="b5">The fifth binding.</param>
        /// <param name="b6">The sixth binding.</param>
        /// <param name="b7">The seventh binding.</param>
        /// <param name="b8">The eigth binding.</param>
        public PriorityBinding(BB b1, BB b2, BB b3, BB b4, BB b5, BB b6, BB b7, BB b8) : this(new BB[] { b1, b2, b3, b4, b5, b6, b7, b8 }) { }

        #endregion

    }

}
