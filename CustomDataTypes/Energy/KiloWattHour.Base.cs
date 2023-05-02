namespace System.CustomDataTypes
{
    using System.Diagnostics;
    using System.Globalization;

    /// <summary>
    /// Custom KilloWattHour Data Type.
    /// </summary>
    [DebuggerDisplay("{Value} kWh")]
    public readonly partial struct KilloWattHour
    {
        public decimal Value { get; }
        
        public KilloWattHour(decimal value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{this.Value.ToString(CultureInfo.CurrentCulture)} kWh";
        }
    }
}