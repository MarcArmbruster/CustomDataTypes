namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// Joule: Implementation of IEquatable<Joule>.
    /// </summary>
    public readonly partial struct Joule : IEquatable<Joule>
    {
        public bool Equals(Joule other)
        {
            return this.Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (obj is Joule otherJoule)
            {
                return this.Value == otherJoule.Value;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }
    }
}