namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// Euro: Implementation of IEquatable<Euro>.
    /// </summary>
    public readonly partial struct Euro : IEquatable<Euro>
    {
        public bool Equals(Euro other)
        {
            return this.ValueExact == other.ValueExact;
        }

        public override bool Equals(object obj)
        {
            if (obj is Euro otherEuro)
            {
                return this.ValueExact == otherEuro.ValueExact;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.ValueExact.GetHashCode();
        }
    }
}