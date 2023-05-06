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
    }
}