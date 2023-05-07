namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// Vat: Implementation of IConvertible
    /// </summary>
    public readonly partial struct Vat : IConvertible
    {
        public static implicit operator Vat(decimal percentage) => new Vat(percentage);
        public static explicit operator decimal(Vat vat) => vat.Percentage;

        public TypeCode GetTypeCode()
        {
            return TypeCode.Decimal;
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            return this.Percentage != 0m;
        }

        public byte ToByte(IFormatProvider provider)
        {
            throw new InvalidCastException("Conversion to Byte is not possible");
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException("Conversion to Char is not possible");
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException("Conversion to DateTime is not possible");
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            return this.Percentage;
        }

        public double ToDouble(IFormatProvider provider)
        {
            return (double)this.Percentage;
        }

        public short ToInt16(IFormatProvider provider)
        {
            return (short)this.Percentage;
        }

        public int ToInt32(IFormatProvider provider)
        {
            return (int)this.Percentage;
        }

        public long ToInt64(IFormatProvider provider)
        {
            return (long)this.Percentage;
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new InvalidCastException("Conversion is not possible");
        }

        public float ToSingle(IFormatProvider provider)
        {
            throw new InvalidCastException("Conversion is not possible");
        }

        public string ToString(IFormatProvider provider)
        {
            return this.ToString(provider);
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new InvalidCastException("Conversion is not possible");
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new InvalidCastException("Conversion is not possible");
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            throw new InvalidCastException("Conversion is not possible");
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new InvalidCastException("Conversion is not possible");
        }
    }
}