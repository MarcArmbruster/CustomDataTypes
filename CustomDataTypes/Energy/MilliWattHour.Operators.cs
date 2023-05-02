namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// MilliWattHour: Implementation of operators
    /// </summary>
    /// <remarks>
    /// Overloading of operator + overloads also +=. Same for other operators.
    /// </remarks>
    public readonly partial struct MilliWattHour
    {    
        public static MilliWattHour operator +(MilliWattHour first, MilliWattHour second)
        {
            return new MilliWattHour(first.Value + second.Value);
        }

        public static MilliWattHour operator -(MilliWattHour first, MilliWattHour second)
        {
            return new MilliWattHour(first.Value - second.Value);
        }

        public static MilliWattHour operator *(MilliWattHour first, MilliWattHour second)
        {
            return new MilliWattHour(first.Value * second.Value);
        }

        public static MilliWattHour operator /(MilliWattHour first, MilliWattHour second)
        {
            return new MilliWattHour(first.Value / second.Value);
        }

        public static bool operator ==(MilliWattHour first, MilliWattHour second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(MilliWattHour first, MilliWattHour second)
        {
            return !first.Equals(second);
        }

        public static bool operator >(MilliWattHour first, MilliWattHour second)
        {
            return first.Value > second.Value;
        }

        public static bool operator >=(MilliWattHour first, MilliWattHour second)
        {
            return first.Value >= second.Value;
        }

        public static bool operator <(MilliWattHour first, MilliWattHour second)
        {
            return first.Value < second.Value;
        }

        public static bool operator <=(MilliWattHour first, MilliWattHour second)
        {
            return first.Value <= second.Value;
        }
    }
}