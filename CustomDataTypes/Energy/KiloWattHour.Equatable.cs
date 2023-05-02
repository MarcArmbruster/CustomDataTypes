namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// KilloWattHour: Implementation of IEquatable<KilloWattHour>.
    /// </summary>
    public readonly partial struct KilloWattHour : IEquatable<KilloWattHour>
    {
        public bool Equals(KilloWattHour other)
        {
            return this.Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (obj is KilloWattHour otherKilloWattHour)
            {
                return this.Value == otherKilloWattHour.Value;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }
    }
}