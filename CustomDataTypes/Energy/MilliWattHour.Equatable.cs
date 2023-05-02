namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// MilliWattHour: Implementation of IEquatable<MilliWattHour>.
    /// </summary>
    public readonly partial struct MilliWattHour : IEquatable<MilliWattHour>
    {
        public bool Equals(MilliWattHour other)
        {
            return this.Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (obj is MilliWattHour otherMilliWattHour)
            {
                return this.Value == otherMilliWattHour.Value;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }
    }
}