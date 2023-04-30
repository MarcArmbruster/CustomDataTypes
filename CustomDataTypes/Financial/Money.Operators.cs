namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// Money: Implementation of operators
    /// If precision is different the result will have the max precision.
    /// </summary>
    /// <remarks>
    /// Overloading of operator + overloads also +=. Same for other operators.
    /// </remarks>
    public readonly partial struct Money
    {
        private static int MaxPrecision(Money one, Money two)
            => one.Precision > two.Precision ? one.Precision : two.Precision;

        public static Money operator +(Money first, Money second)
        {
            if (first.CurrencyCode != second.CurrencyCode)
            {
                throw new InvalidOperationException("Money addition requires same currency codes!");
            }

            return new Money(first.ValueExact + second.ValueExact, first.CurrencyCode, MaxPrecision(first, second));
        }

        public static Money operator -(Money first, Money second)
        {
            if (first.CurrencyCode != second.CurrencyCode)
            {
                throw new InvalidOperationException("Money subtraction requires same currency codes!");
            }

            return new Money(first.ValueExact - second.ValueExact, first.CurrencyCode, MaxPrecision(first, second));
        }

        public static Money operator *(Money first, Money second)
        {
            if (first.CurrencyCode != second.CurrencyCode)
            {
                throw new InvalidOperationException("Money multiplication requires same currency codes!");
            }

            return new Money(first.ValueExact * second.ValueExact, first.CurrencyCode, MaxPrecision(first, second));
        }

        public static Money operator /(Money first, Money second)
        {
            if (first.CurrencyCode != second.CurrencyCode)
            {
                throw new InvalidOperationException("Money division requires same currency codes!");
            }

            return new Money(first.ValueExact / second.ValueExact, first.CurrencyCode, MaxPrecision(first, second));
        }

        public static bool operator ==(Money first, Money second)
        {
            if (first.CurrencyCode != second.CurrencyCode)
            {
                return false;
            }

            return first.Equals(second);
        }

        public static bool operator !=(Money first, Money second)
        {
            if (first.CurrencyCode != second.CurrencyCode)
            {
                return true;
            }

            return !first.Equals(second);
        }

        public static bool operator >(Money first, Money second)
        {
            if (first.CurrencyCode != second.CurrencyCode)
            {
                throw new InvalidOperationException("Money comparision requires same currency codes!");
            }

            return first.ValueExact > second.ValueExact;
        }

        public static bool operator >=(Money first, Money second)
        {
            if (first.CurrencyCode != second.CurrencyCode)
            {
                throw new InvalidOperationException("Money comparision requires same currency codes!");
            }

            return first.ValueExact >= second.ValueExact;
        }

        public static bool operator <(Money first, Money second)
        {
            if (first.CurrencyCode != second.CurrencyCode)
            {
                throw new InvalidOperationException("Money comparision requires same currency codes!");
            }

            return first.ValueExact < second.ValueExact;
        }

        public static bool operator <=(Money first, Money second)
        {
            if (first.CurrencyCode != second.CurrencyCode)
            {
                throw new InvalidOperationException("Money comparision requires same currency codes!");
            }

            return first.ValueExact <= second.ValueExact;
        }
    }
}
