namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// MilliJoule: Implementation of IEquatable<MilliJoule>.
    /// </summary>
    public readonly partial struct MilliJoule : IEquatable<MilliJoule>
    {
        public bool Equals(MilliJoule other)
        {
            return this.Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (obj is MilliJoule otherMilliJoule)
            {
                return this.Value == otherMilliJoule.Value;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }
    }
}