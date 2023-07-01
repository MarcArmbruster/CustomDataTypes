namespace System.CustomDataTypes
{
    using System.Diagnostics;
    using System.Globalization;

    /// <summary>
    /// Custom CHF Data Type.
    /// </summary>
    [DebuggerDisplay("{ValueExact} CHF")]
    public sealed partial class CHF
    {
        public static string CurrencyCode => "CHF";
        public static byte Precision => 2;
        public decimal ValueExact { get; }
        public decimal Value => Math.Round(this.ValueExact, 2);
        public bool IsPositive => this.ValueExact > 0m;
        public bool IsNegative => this.ValueExact < 0m;
        public bool IsZero => this.ValueExact == 0m;
        
        public CHF(decimal value)
        {
            this.ValueExact = value;
        }

        public override string ToString()
        {
            return $"{this.ValueExact.ToString(CultureInfo.CurrentCulture)} {CurrencyCode}";
        }

        public CHF Netto(decimal vatRateFactor)
        {
            var tara = this.ValueExact * vatRateFactor;
            return new CHF(this.ValueExact - tara);
        }

        public CHF Netto(Vat vat)
        {
            var tara = this.ValueExact * vat.Factor;
            return new CHF(this.ValueExact - tara);
        }

        public CHF Tara(decimal vatRateFactor)
        {
            var tara = this.ValueExact * vatRateFactor;
            return new CHF(tara);
        }

        public CHF Tara(Vat vat)
        {
            var tara = this.ValueExact * vat.Factor;
            return new CHF(tara);
        }
    }
}