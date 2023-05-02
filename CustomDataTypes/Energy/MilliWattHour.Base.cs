namespace System.CustomDataTypes
{
    using System.Diagnostics;
    using System.Globalization;

    /// <summary>
    /// Custom MilliWattHour Data Type.
    /// </summary>
    [DebuggerDisplay("{Value} mWh")]
    public readonly partial struct MilliWattHour
    {
        public decimal Value { get; }
        public MilliWattHour(decimal value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{this.Value.ToString(CultureInfo.CurrentCulture)} mWh";
        }
    }
}