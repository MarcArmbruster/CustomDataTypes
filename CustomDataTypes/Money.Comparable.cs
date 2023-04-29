namespace System.CustomDataTypes
{
    using System;

    public readonly partial struct Money : IComparable<Money>
    {
        /// <summary>
        /// Implementation of ICompareable<Money>.
        /// </summary>
        /// <param name="other">The other instance to be compared with current instance.</param>
        /// <returns>
        /// The comparision result value.
        /// First currency codes are compared, than - if codes are equal - the exact values.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown if currency codes are different.</exception>
        public int CompareTo(Money other)
        {
            if (this.CurrencyCode != other.CurrencyCode)
            {
                return string.Compare(this.CurrencyCode, other.CurrencyCode, StringComparison.OrdinalIgnoreCase);
            }

            return this.ValueExact.CompareTo(other.ValueExact);
        }
    }
}
