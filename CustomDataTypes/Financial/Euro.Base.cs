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

        public Euro Netto(decimal vatRateFactor)
        {
            var tara = this.ValueExact * vatRateFactor;
            return new Euro(this.ValueExact - tara);
        }

        public Euro Netto(Vat vat)
        {
            var tara = this.ValueExact * vat.Factor;
            return new Euro(this.ValueExact - tara);
        }

        public Euro Tara(decimal vatRateFactor)
        {
            var tara = this.ValueExact * vatRateFactor;
            return new Euro(tara);
        }

        public Euro Tara(Vat vat)
        {
            var tara = this.ValueExact * vat.Factor;
            return new Euro(tara);
        }
    }
}