namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// Joule: Implementation of operators
    /// </summary>
    /// <remarks>
    /// Overloading of operator + overloads also +=. Same for other operators.
    /// </remarks>
    public readonly partial struct Joule
    {    
        public static Joule operator +(Joule first, Joule second)
        {
            return new Joule(first.Value + second.Value);
        }

        public static Joule operator -(Joule first, Joule second)
        {
            return new Joule(first.Value - second.Value);
        }

        public static Joule operator *(Joule first, Joule second)
        {
            return new Joule(first.Value * second.Value);
        }

        public static Joule operator /(Joule first, Joule second)
        {
            return new Joule(first.Value / second.Value);
        }

        public static bool operator ==(Joule first, Joule second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Joule first, Joule second)
        {
            return !first.Equals(second);
        }

        public static bool operator >(Joule first, Joule second)
        {
            return first.Value > second.Value;
        }

        public static bool operator >=(Joule first, Joule second)
        {
            return first.Value >= second.Value;
        }

        public static bool operator <(Joule first, Joule second)
        {
            return first.Value < second.Value;
        }

        public static bool operator <=(Joule first, Joule second)
        {
            return first.Value <= second.Value;
        }
    }
}