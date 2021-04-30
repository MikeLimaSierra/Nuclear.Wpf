using System;
using System.Collections.Generic;

namespace Nuclear.Wpf.Data.MultiValueConverters {

    /// <summary>
    /// A logic gate delegate used in <see cref="LogicGateConverter{T}"/>.
    /// </summary>
    /// <param name="values">The range of values used as input data.</param>
    /// <returns>The logic result.</returns>
    public delegate Boolean GateLogic(IEnumerable<Boolean> values);

}
