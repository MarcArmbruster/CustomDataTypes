namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// Money: Implementation of IComparable<Money>
    /// </summary>
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
#pragma warning disable CA1309 // Use ordinal string comparison
                return string.Compare(this.CurrencyCode, other.CurrencyCode, StringComparison.CurrentCulture);
#pragma warning restore CA1309 // Use ordinal string comparison
            }

            return this.ValueExact.CompareTo(other.ValueExact);
        }
    }
}
