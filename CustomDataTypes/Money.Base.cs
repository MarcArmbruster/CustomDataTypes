namespace System.CustomDataTypes
{
    using System.Globalization;

    /// <summary>
    /// Custom Money Data Type.
    /// </summary>
    public readonly partial struct Money
    {
        private readonly CultureInfo cultureInfo;

        public decimal ValueExact { get; }
        public decimal Value => Math.Round(this.ValueExact, this.Precision);
        public string CurrencyCode { get; }
        public int Precision { get; }

        public Money(decimal value, string currencyCode)
        {
            if (string.IsNullOrWhiteSpace(currencyCode))
            {
                throw new ArgumentNullException(nameof(currencyCode));
            }

            this.cultureInfo = CultureInfo.CurrentCulture;
            this.ValueExact = value;
            this.CurrencyCode = currencyCode.ToUpper(this.cultureInfo);
            this.Precision = 2;
        }

        public Money(decimal value, string currencyCode, int precision)
        {
            if (string.IsNullOrWhiteSpace(currencyCode))
            {
                throw new ArgumentNullException(nameof(currencyCode));
            }

            this.cultureInfo = CultureInfo.CurrentCulture;
            this.ValueExact = value;
            this.CurrencyCode = currencyCode.ToUpper(this.cultureInfo);
            this.Precision = precision;
        }

        public override string ToString()
        {
            return $"{this.ValueExact.ToString(cultureInfo)} {this.CurrencyCode}";
        }

        public static Money ToOtherCurrency(Money money, string newCurrencyCode, decimal exchangeRateFactor)
        {
            return new Money(money.ValueExact * exchangeRateFactor, newCurrencyCode);
        }
    }
}