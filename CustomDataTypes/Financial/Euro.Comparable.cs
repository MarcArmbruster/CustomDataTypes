namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// Euro: Implementation of IComparable<Euro>
    /// </summary>
    public readonly partial struct Euro : IComparable<Euro>
    {
        /// <summary>
        /// Implementation of ICompareable<Euro>.
        /// </summary>
        /// <param name="other">The other instance to be compared with current instance.</param>
        /// <returns>
        /// The comparision result value.
        /// </returns>
        public int CompareTo(Euro other)
        {
            return this.ValueExact.CompareTo(other.ValueExact);
        }
    }
}