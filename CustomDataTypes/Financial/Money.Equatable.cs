namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// Money: Implementation of IEquatable<Money>.
    /// </summary>
    public readonly partial struct Money : IEquatable<Money>
    {
        public bool Equals(Money other)
        {
            return this.CurrencyCode == other.CurrencyCode
                && this.Precision == other.Precision
                && this.ValueExact == other.ValueExact;
        }

        public override bool Equals(object obj)
        {
            if (obj is Money otherMoney)
            {
                return this.CurrencyCode == otherMoney.CurrencyCode
                    && this.Precision == otherMoney.Precision
                    && this.ValueExact == otherMoney.ValueExact;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.ValueExact.GetHashCode()
                ^ this.Precision.GetHashCode()
                ^ this.CurrencyCode.GetHashCode();
        }
    }
}