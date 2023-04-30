namespace System.CustomDataTypes
{
    using System;

    /// <summary>
    /// Money: Implementation of IConvertible
    /// </summary>
    public readonly partial struct Money : IConvertible
    {
        // implicit operator is complex, because Value AND CurrencyCode are required
        public static implicit operator Money((decimal, string) data) => new Money(data.Item1, data.Item2);
        public static explicit operator decimal(Money money) => money.ValueExact;

        public TypeCode GetTypeCode()
        {
            return TypeCode.Decimal;
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            return this.ValueExact != 0m;
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
            return this.ValueExact;
        }

        public double ToDouble(IFormatProvider provider)
        {
            return (double)this.ValueExact;
        }

        public short ToInt16(IFormatProvider provider)
        {
            return (short)this.ValueExact;
        }

        public int ToInt32(IFormatProvider provider)
        {
            return (int)this.ValueExact;
        }

        public long ToInt64(IFormatProvider provider)
        {
            return (long)this.ValueExact;
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