namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// MilliWattHour: Implementation of IComparable<MilliWattHour>
    /// </summary>
    public readonly partial struct MilliWattHour : IComparable<MilliWattHour>
    {
        /// <summary>
        /// Implementation of ICompareable<MilliWattHour>.
        /// </summary>
        /// <param name="other">The other instance to be compared with current instance.</param>
        /// <returns>
        /// The comparision result value.
        /// </returns>
        public int CompareTo(MilliWattHour other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
}