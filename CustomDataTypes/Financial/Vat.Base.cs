namespace System.CustomDataTypes
{
    using System.Diagnostics;
    using System.Globalization;

    /// <summary>
    /// Custom VAT Data Type.
    /// </summary>
    [DebuggerDisplay("{Percentage} %")]
    public readonly partial struct Vat
    {
        private static readonly decimal minimum = 0m;
        private static readonly decimal maximum = 100m;
        public static Vat MinValue => new Vat(minimum);
        public static Vat MaxValue => new Vat(maximum);


        public decimal Factor { get; }
        public decimal Percentage { get; }
        public bool IsZero => this.Percentage == 0m;
        
        
        public Vat(decimal valueInPercent)
        {
            if (valueInPercent < minimum)
            {
                throw new OverflowException("VAT value must be greater than Min value.");
            }

            if (valueInPercent > maximum)
            {
                throw new OverflowException("VAT value must be lower or equal than the Max value.");
            }

            this.Percentage = valueInPercent;
            this.Factor = valueInPercent / 100;
        }

        public override string ToString()
        {
            return $"{this.Percentage.ToString(CultureInfo.CurrentCulture)} %";
        }

        public decimal Netto(decimal brutto)
        {
            var tara = brutto * this.Factor;
            return brutto - tara;
        }

        public decimal Tara(decimal brutto)
        {
            var tara = brutto * this.Factor;
            return tara;
        }
    }
}