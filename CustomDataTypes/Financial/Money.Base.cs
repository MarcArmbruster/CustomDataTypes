namespace System.CustomDataTypes
{
    using System.Diagnostics;
    using System.Globalization;

    /// <summary>
    /// Custom Money Data Type.
    /// </summary>
    [DebuggerDisplay("{ValueExact} {CurrencyCode}")]
    public readonly partial struct Money
    {
        public decimal ValueExact { get; }
        public string CurrencyCode { get; }
        public int Precision { get; }
        public decimal Value => Math.Round(this.ValueExact, this.Precision);
        public bool IsPositive => this.ValueExact > 0m;
        public bool IsNegative => this.ValueExact < 0m;
        public bool IsZero => this.ValueExact == 0m;
        
        public Money(decimal value, string currencyCode)
        {
            if (string.IsNullOrWhiteSpace(currencyCode))
            {
                throw new ArgumentNullException(nameof(currencyCode));
            }

            this.ValueExact = value;
            this.CurrencyCode = currencyCode.ToUpper(CultureInfo.CurrentCulture);
            this.Precision = 2;
        }

        public Money(decimal value, string currencyCode, int precision)
        {
            if (string.IsNullOrWhiteSpace(currencyCode))
            {
                throw new ArgumentNullException(nameof(currencyCode));
            }

            this.ValueExact = value;
            this.CurrencyCode = currencyCode.ToUpper(CultureInfo.CurrentCulture);
            this.Precision = precision;
        }

        public override string ToString()
        {
            return $"{this.ValueExact.ToString(CultureInfo.CurrentCulture)} {this.CurrencyCode}";
        }

        public static Money ToOtherCurrency(Money money, string newCurrencyCode, decimal exchangeRateFactor)
        {
            return new Money(money.ValueExact * exchangeRateFactor, newCurrencyCode);
        }
    }
}