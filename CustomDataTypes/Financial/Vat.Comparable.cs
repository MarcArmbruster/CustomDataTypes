namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// Vat: Implementation of IComparable<Vat>
    /// </summary>
    public readonly partial struct Vat : IComparable<Vat>
    {
        /// <summary>
        /// Implementation of ICompareable<Euro>.
        /// </summary>
        /// <param name="other">The other instance to be compared with current instance.</param>
        /// <returns>
        /// The comparision result value.
        /// </returns>
        public int CompareTo(Vat other)
        {
            return this.Percentage.CompareTo(other.Percentage);
        }
    }
}