namespace System.CustomDataTypes
{
    using System.Diagnostics;
    using System.Globalization;

    /// <summary>
    /// Custom Euro Data Type.
    /// </summary>
    [DebuggerDisplay("{ValueExact} EUR")]
    public readonly partial struct Euro
    {
        public static string CurrencyCode => "EUR";
        public static byte Precision => 2;

        public decimal ValueExact { get; }
        public decimal Value => Math.Round(this.ValueExact, 2);
        public bool IsPositive => this.ValueExact > 0m;
        public bool IsNegative => this.ValueExact < 0m;
        public bool IsZero => this.ValueExact == 0m;
        
        public Euro(decimal value)
        {
            this.ValueExact = value;
        }

        public override string ToString()
        {
            return $"{this.ValueExact.ToString(CultureInfo.CurrentCulture)} {CurrencyCode}";
        }
    }
}