namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// MilliJoule: Implementation of operators
    /// </summary>
    /// <remarks>
    /// Overloading of operator + overloads also +=. Same for other operators.
    /// </remarks>
    public readonly partial struct MilliJoule
    {    
        public static MilliJoule operator +(MilliJoule first, MilliJoule second)
        {
            return new MilliJoule(first.Value + second.Value);
        }

        public static MilliJoule operator -(MilliJoule first, MilliJoule second)
        {
            return new MilliJoule(first.Value - second.Value);
        }

        public static MilliJoule operator *(MilliJoule first, MilliJoule second)
        {
            return new MilliJoule(first.Value * second.Value);
        }

        public static MilliJoule operator /(MilliJoule first, MilliJoule second)
        {
            return new MilliJoule(first.Value / second.Value);
        }

        public static bool operator ==(MilliJoule first, MilliJoule second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(MilliJoule first, MilliJoule second)
        {
            return !first.Equals(second);
        }

        public static bool operator >(MilliJoule first, MilliJoule second)
        {
            return first.Value > second.Value;
        }

        public static bool operator >=(MilliJoule first, MilliJoule second)
        {
            return first.Value >= second.Value;
        }

        public static bool operator <(MilliJoule first, MilliJoule second)
        {
            return first.Value < second.Value;
        }

        public static bool operator <=(MilliJoule first, MilliJoule second)
        {
            return first.Value <= second.Value;
        }
    }
}