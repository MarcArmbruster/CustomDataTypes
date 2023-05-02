namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// MilliJoule: Implementation of IComparable<MilliJoule>
    /// </summary>
    public readonly partial struct MilliJoule : IComparable<MilliJoule>
    {
        /// <summary>
        /// Implementation of ICompareable<MilliJoule>.
        /// </summary>
        /// <param name="other">The other instance to be compared with current instance.</param>
        /// <returns>
        /// The comparision result value.
        /// </returns>
        public int CompareTo(MilliJoule other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
}