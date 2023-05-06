namespace System.CustomDataTypes
{
    /// <summary>
    /// CHF: Implementation of operators
    /// </summary>
    /// <remarks>
    /// Overloading of operator + overloads also +=. Same for other operators.
    /// </remarks>
    public partial class CHF
    {    
        public static CHF operator +(CHF first, CHF second)
        {
            return new CHF(first.ValueExact + second.ValueExact);
        }

        public static CHF operator -(CHF first, CHF second)
        {
            return new CHF(first.ValueExact - second.ValueExact);
        }

        public static CHF operator *(CHF first, CHF second)
        {
            return new CHF(first.ValueExact * second.ValueExact);
        }

        public static CHF operator /(CHF first, CHF second)
        {
            return new CHF(first.ValueExact / second.ValueExact);
        }

        public static bool operator ==(CHF first, CHF second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(CHF first, CHF second)
        {
            return !first.Equals(second);
        }

        public static bool operator >(CHF first, CHF second)
        {
            return first.ValueExact > second.ValueExact;
        }

        public static bool operator >=(CHF first, CHF second)
        {
            return first.ValueExact >= second.ValueExact;
        }

        public static bool operator <(CHF first, CHF second)
        {
            return first.ValueExact < second.ValueExact;
        }

        public static bool operator <=(CHF first, CHF second)
        {
            return first.ValueExact <= second.ValueExact;
        }
    }
}