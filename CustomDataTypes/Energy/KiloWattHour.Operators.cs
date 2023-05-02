namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// KilloWattHour: Implementation of operators
    /// </summary>
    /// <remarks>
    /// Overloading of operator + overloads also +=. Same for other operators.
    /// </remarks>
    public readonly partial struct KilloWattHour
    {    
        public static KilloWattHour operator +(KilloWattHour first, KilloWattHour second)
        {
            return new KilloWattHour(first.Value + second.Value);
        }

        public static KilloWattHour operator -(KilloWattHour first, KilloWattHour second)
        {
            return new KilloWattHour(first.Value - second.Value);
        }

        public static KilloWattHour operator *(KilloWattHour first, KilloWattHour second)
        {
            return new KilloWattHour(first.Value * second.Value);
        }

        public static KilloWattHour operator /(KilloWattHour first, KilloWattHour second)
        {
            return new KilloWattHour(first.Value / second.Value);
        }

        public static bool operator ==(KilloWattHour first, KilloWattHour second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(KilloWattHour first, KilloWattHour second)
        {
            return !first.Equals(second);
        }

        public static bool operator >(KilloWattHour first, KilloWattHour second)
        {
            return first.Value > second.Value;
        }

        public static bool operator >=(KilloWattHour first, KilloWattHour second)
        {
            return first.Value >= second.Value;
        }

        public static bool operator <(KilloWattHour first, KilloWattHour second)
        {
            return first.Value < second.Value;
        }

        public static bool operator <=(KilloWattHour first, KilloWattHour second)
        {
            return first.Value <= second.Value;
        }
    }
}