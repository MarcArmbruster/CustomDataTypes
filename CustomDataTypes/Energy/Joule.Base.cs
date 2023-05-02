namespace System.CustomDataTypes
{
    using System.Diagnostics;
    using System.Globalization;

    /// <summary>
    /// Custom Euro Data Type.
    /// </summary>
    [DebuggerDisplay("{Value} J")]
    public readonly partial struct Joule
    {
        public decimal Value { get; }
        
        public Joule(decimal value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{this.Value.ToString(CultureInfo.CurrentCulture)} J";
        }
    }
}