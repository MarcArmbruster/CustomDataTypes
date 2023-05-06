namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// CHF: Implementation of IEquatable<CHF>.
    /// </summary>
    public partial class CHF : IEquatable<CHF>
    {
        public bool Equals(CHF other)
        {
            return this.ValueExact == other.ValueExact;
        }

        public override bool Equals(object obj)
        {
            if (obj is CHF otherChf)
            {
                return this.ValueExact == otherChf.ValueExact;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.ValueExact.GetHashCode();
        }
    }
}