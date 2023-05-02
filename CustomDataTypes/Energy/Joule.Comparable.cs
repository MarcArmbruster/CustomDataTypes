namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// Joule: Implementation of IComparable<Joule>
    /// </summary>
    public readonly partial struct Joule : IComparable<Joule>
    {
        /// <summary>
        /// Implementation of ICompareable<Joule>.
        /// </summary>
        /// <param name="other">The other instance to be compared with current instance.</param>
        /// <returns>
        /// The comparision result value.
        /// </returns>
        public int CompareTo(Joule other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
}