namespace Nuclear.Wpf.Data.MultiValueConverters {

    /// <summary>
    /// Defines a range of supported logic gates.
    /// </summary>
    public enum LogicGates {

        /// <summary>
        /// The used logic gate follows AND-logic
        /// </summary>
        And,

        /// <summary>
        /// The used logic gate follows NAND-logic
        /// </summary>
        Nand,

        /// <summary>
        /// The used logic gate follows OR-logic
        /// </summary>
        Or,

        /// <summary>
        /// The used logic gate follows NOR-logic
        /// </summary>
        Nor,

        /// <summary>
        /// The used logic gate follows XOR-logic
        /// </summary>
        Xor,

        /// <summary>
        /// The used logic gate follows XNOR-logic
        /// </summary>
        Xnor,

        /// <summary>
        /// The used logic gate is a custom <see cref="GateLogic"/>.
        /// </summary>
        Custom
    }
}
