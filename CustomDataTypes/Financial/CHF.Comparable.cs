namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// CHF: Implementation of IComparable<CHF>
    /// </summary>
    public partial class CHF : IComparable<CHF>
    {
        /// <summary>
        /// Implementation of ICompareable<Euro>.
        /// </summary>
        /// <param name="other">The other instance to be compared with current instance.</param>
        /// <returns>
        /// The comparision result value.
        /// </returns>
        public int CompareTo(CHF other)
        {
            return this.ValueExact.CompareTo(other.ValueExact);
        }
    }
}