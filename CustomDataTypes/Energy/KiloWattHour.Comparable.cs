namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// KilloWattHour: Implementation of IComparable<KilloWattHour>
    /// </summary>
    public readonly partial struct KilloWattHour : IComparable<KilloWattHour>
    {
        /// <summary>
        /// Implementation of ICompareable<KilloWattHour>.
        /// </summary>
        /// <param name="other">The other instance to be compared with current instance.</param>
        /// <returns>
        /// The comparision result value.
        /// </returns>
        public int CompareTo(KilloWattHour other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
}