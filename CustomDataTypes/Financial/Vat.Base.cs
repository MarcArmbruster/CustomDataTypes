namespace System.CustomDataTypes
{
    using System.Diagnostics;
    using System.Globalization;

    /// <summary>
    /// Custom Euro Data Type.
    /// </summary>
    [DebuggerDisplay("{Percentage} %")]
    public readonly partial struct Vat
    {
        public decimal Factor { get; }
        public decimal Percentage { get; }
        public bool IsZero => this.Percentage == 0m;
        
        public Vat(decimal valueInPercent)
        {
            this.Percentage = valueInPercent;
            this.Factor = valueInPercent / 100;
        }

        public override string ToString()
        {
            return $"{this.Percentage.ToString(CultureInfo.CurrentCulture)} %";
        }
    }
}