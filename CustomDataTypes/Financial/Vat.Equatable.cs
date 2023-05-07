namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// Vat: Implementation of IEquatable<Vat>.
    /// </summary>
    public readonly partial struct Vat : IEquatable<Vat>
    {
        public bool Equals(Vat other)
        {
            return this.Percentage == other.Percentage;
        }

        public override bool Equals(object obj)
        {
            if (obj is Vat other)
            {
                return this.Percentage == other.Percentage;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.Percentage.GetHashCode();
        }
    }
}