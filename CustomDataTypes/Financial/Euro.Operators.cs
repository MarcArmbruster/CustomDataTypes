namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// Euro: Implementation of operators
    /// </summary>
    /// <remarks>
    /// Overloading of operator + overloads also +=. Same for other operators.
    /// </remarks>
    public readonly partial struct Euro
    {    
        public static Euro operator +(Euro first, Euro second)
        {
            return new Euro(first.ValueExact + second.ValueExact);
        }

        public static Euro operator -(Euro first, Euro second)
        {
            return new Euro(first.ValueExact - second.ValueExact);
        }

        public static Euro operator *(Euro first, Euro second)
        {
            return new Euro(first.ValueExact * second.ValueExact);
        }

        public static Euro operator /(Euro first, Euro second)
        {
            return new Euro(first.ValueExact / second.ValueExact);
        }

        public static bool operator ==(Euro first, Euro second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Euro first, Euro second)
        {
            return !first.Equals(second);
        }

        public static bool operator >(Euro first, Euro second)
        {
            return first.ValueExact > second.ValueExact;
        }

        public static bool operator >=(Euro first, Euro second)
        {
            return first.ValueExact >= second.ValueExact;
        }

        public static bool operator <(Euro first, Euro second)
        {
            return first.ValueExact < second.ValueExact;
        }

        public static bool operator <=(Euro first, Euro second)
        {
            return first.ValueExact <= second.ValueExact;
        }
    }
}