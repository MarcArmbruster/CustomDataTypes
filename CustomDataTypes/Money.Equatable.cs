namespace System.CustomDataTypes
{
    using System;

    public readonly partial struct Money : IEquatable<Money>
    {
        /// <summary>
        /// Implementation of IEquatable<Money>.
        /// </summary>
        /// <param name="other">The other instance to be compared with current instance.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
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
