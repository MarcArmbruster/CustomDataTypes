namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// Vat: Implementation of operators
    /// </summary>
    /// <remarks>
    /// Overloading of operator + overloads also +=. Same for other operators.
    /// </remarks>
    public readonly partial struct Vat
    {    
        public static Vat operator +(Vat first, Vat second)
        {
            return new Vat(first.Percentage + second.Percentage);
        }

        public static Vat operator -(Vat first, Vat second)
        {
            return new Vat(first.Percentage - second.Percentage);
        }

        public static Vat operator *(Vat first, Vat second)
        {
            return new Vat(first.Percentage * second.Percentage);
        }

        public static Vat operator /(Vat first, Vat second)
        {
            return new Vat(first.Percentage / second.Percentage);
        }

        public static bool operator ==(Vat first, Vat second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Vat first, Vat second)
        {
            return !first.Equals(second);
        }

        public static bool operator >(Vat first, Vat second)
        {
            return first.Percentage > second.Percentage;
        }

        public static bool operator >=(Vat first, Vat second)
        {
            return first.Percentage >= second.Percentage;
        }

        public static bool operator <(Vat first, Vat second)
        {
            return first.Percentage < second.Percentage;
        }

        public static bool operator <=(Vat first, Vat second)
        {
            return first.Percentage <= second.Percentage;
        }
    }
}