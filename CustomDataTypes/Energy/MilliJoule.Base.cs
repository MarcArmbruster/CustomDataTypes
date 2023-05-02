namespace System.CustomDataTypes
{
    using System.Diagnostics;
    using System.Globalization;

    /// <summary>
    /// Custom MilliJoule Data Type.
    /// </summary>
    [DebuggerDisplay("{Value} mJ")]
    public readonly partial struct MilliJoule
    {
        public decimal Value { get; }
        
        public MilliJoule(decimal value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{this.Value.ToString(CultureInfo.CurrentCulture)} mJ";
        }
    }
}