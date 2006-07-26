using System;
using System.Data.SqlTypes;
using System.IO;
using System.Xml;

namespace BLToolkit.Common
{
	#region Nullable Types

	#region SByte?

	partial class ConvertPartial<T,P>: IConvertible<SByte?,P>
	{
		SByte? IConvertible<SByte?,P>.From(P p) { return Convert<SByte?,object>.Instance.From(p); }
	}

	partial class ConvertExplicit<T,P>:
		// Scalar Types.
		// 
		IConvertible<SByte?,SByte>, 
		IConvertible<SByte?,String>, 

		IConvertible<SByte?,Int16>, 
		IConvertible<SByte?,Int32>, 
		IConvertible<SByte?,Int64>, 

		IConvertible<SByte?,Byte>, 
		IConvertible<SByte?,UInt16>, 
		IConvertible<SByte?,UInt32>, 
		IConvertible<SByte?,UInt64>, 

		IConvertible<SByte?,Single>, 
		IConvertible<SByte?,Double>, 

		IConvertible<SByte?,Boolean>, 
		IConvertible<SByte?,Decimal>, 
		IConvertible<SByte?,Char>, 

		// Nullable Types.
		// 
		IConvertible<SByte?,Int16?>, 
		IConvertible<SByte?,Int32?>, 
		IConvertible<SByte?,Int64?>, 

		IConvertible<SByte?,Byte?>, 
		IConvertible<SByte?,UInt16?>, 
		IConvertible<SByte?,UInt32?>, 
		IConvertible<SByte?,UInt64?>, 

		IConvertible<SByte?,Single?>, 
		IConvertible<SByte?,Double?>, 

		IConvertible<SByte?,Boolean?>, 
		IConvertible<SByte?,Decimal?>, 
		IConvertible<SByte?,Char?>, 

		// SqlTypes.
		// 
		IConvertible<SByte?,SqlString>, 

		IConvertible<SByte?,SqlByte>, 
		IConvertible<SByte?,SqlInt16>, 
		IConvertible<SByte?,SqlInt32>, 
		IConvertible<SByte?,SqlInt64>, 

		IConvertible<SByte?,SqlSingle>, 
		IConvertible<SByte?,SqlDouble>, 
		IConvertible<SByte?,SqlDecimal>, 
		IConvertible<SByte?,SqlMoney>, 

		IConvertible<SByte?,SqlBoolean>, 

		IConvertible<SByte?,object>

	{
		// Scalar Types.
		// 
		SByte? IConvertible<SByte?,SByte>.      From(SByte p)       { return p; }
		SByte? IConvertible<SByte?,String>.     From(String p)      { return p == null? null: (SByte?)Convert.ToSByte(p); }

		SByte? IConvertible<SByte?,Int16>.      From(Int16 p)       { return Convert.ToSByte(p); }
		SByte? IConvertible<SByte?,Int32>.      From(Int32 p)       { return Convert.ToSByte(p); }
		SByte? IConvertible<SByte?,Int64>.      From(Int64 p)       { return Convert.ToSByte(p); }

		SByte? IConvertible<SByte?,Byte>.       From(Byte p)        { return Convert.ToSByte(p); }
		SByte? IConvertible<SByte?,UInt16>.     From(UInt16 p)      { return Convert.ToSByte(p); }
		SByte? IConvertible<SByte?,UInt32>.     From(UInt32 p)      { return Convert.ToSByte(p); }
		SByte? IConvertible<SByte?,UInt64>.     From(UInt64 p)      { return Convert.ToSByte(p); }

		SByte? IConvertible<SByte?,Single>.     From(Single p)      { return Convert.ToSByte(p); }
		SByte? IConvertible<SByte?,Double>.     From(Double p)      { return Convert.ToSByte(p); }

		SByte? IConvertible<SByte?,Boolean>.    From(Boolean p)     { return Convert.ToSByte(p); }
		SByte? IConvertible<SByte?,Decimal>.    From(Decimal p)     { return Convert.ToSByte(p); }
		SByte? IConvertible<SByte?,Char>.       From(Char p)        { return Convert.ToSByte(p); }

		// Nullable Types.
		// 
		SByte? IConvertible<SByte?,Int16?>.     From(Int16? p)      { return p.HasValue? (SByte?)Convert.ToSByte(p.Value) : null; }
		SByte? IConvertible<SByte?,Int32?>.     From(Int32? p)      { return p.HasValue? (SByte?)Convert.ToSByte(p.Value) : null; }
		SByte? IConvertible<SByte?,Int64?>.     From(Int64? p)      { return p.HasValue? (SByte?)Convert.ToSByte(p.Value) : null; }

		SByte? IConvertible<SByte?,Byte?>.      From(Byte? p)       { return p.HasValue? (SByte?)Convert.ToSByte(p.Value) : null; }
		SByte? IConvertible<SByte?,UInt16?>.    From(UInt16? p)     { return p.HasValue? (SByte?)Convert.ToSByte(p.Value) : null; }
		SByte? IConvertible<SByte?,UInt32?>.    From(UInt32? p)     { return p.HasValue? (SByte?)Convert.ToSByte(p.Value) : null; }
		SByte? IConvertible<SByte?,UInt64?>.    From(UInt64? p)     { return p.HasValue? (SByte?)Convert.ToSByte(p.Value) : null; }

		SByte? IConvertible<SByte?,Single?>.    From(Single? p)     { return p.HasValue? (SByte?)Convert.ToSByte(p.Value) : null; }
		SByte? IConvertible<SByte?,Double?>.    From(Double? p)     { return p.HasValue? (SByte?)Convert.ToSByte(p.Value) : null; }

		SByte? IConvertible<SByte?,Boolean?>.   From(Boolean? p)    { return p.HasValue? (SByte?)Convert.ToSByte(p.Value) : null; }
		SByte? IConvertible<SByte?,Decimal?>.   From(Decimal? p)    { return p.HasValue? (SByte?)Convert.ToSByte(p.Value) : null; }
		SByte? IConvertible<SByte?,Char?>.      From(Char? p)       { return p.HasValue? (SByte?)Convert.ToSByte(p.Value) : null; }

		// SqlTypes.
		// 
		SByte? IConvertible<SByte?,SqlString>.  From(SqlString p)   { return p.IsNull? null: (SByte?)Convert.ToSByte(p.Value); }

		SByte? IConvertible<SByte?,SqlByte>.    From(SqlByte p)     { return p.IsNull? null: (SByte?)Convert.ToSByte(p.Value); }
		SByte? IConvertible<SByte?,SqlInt16>.   From(SqlInt16 p)    { return p.IsNull? null: (SByte?)Convert.ToSByte(p.Value); }
		SByte? IConvertible<SByte?,SqlInt32>.   From(SqlInt32 p)    { return p.IsNull? null: (SByte?)Convert.ToSByte(p.Value); }
		SByte? IConvertible<SByte?,SqlInt64>.   From(SqlInt64 p)    { return p.IsNull? null: (SByte?)Convert.ToSByte(p.Value); }

		SByte? IConvertible<SByte?,SqlSingle>.  From(SqlSingle p)   { return p.IsNull? null: (SByte?)Convert.ToSByte(p.Value); }
		SByte? IConvertible<SByte?,SqlDouble>.  From(SqlDouble p)   { return p.IsNull? null: (SByte?)Convert.ToSByte(p.Value); }
		SByte? IConvertible<SByte?,SqlDecimal>. From(SqlDecimal p)  { return p.IsNull? null: (SByte?)Convert.ToSByte(p.Value); }
		SByte? IConvertible<SByte?,SqlMoney>.   From(SqlMoney p)    { return p.IsNull? null: (SByte?)Convert.ToSByte(p.Value); }

		SByte? IConvertible<SByte?,SqlBoolean>. From(SqlBoolean p)  { return p.IsNull? null: (SByte?)Convert.ToSByte(p.Value); }

		SByte? IConvertible<SByte?,object>.     From(object p)      { return Convert.ToSByte(p); }
	}

	#endregion

	#region Int16?

	partial class ConvertPartial<T,P>: IConvertible<Int16?,P>
	{
		Int16? IConvertible<Int16?,P>.From(P p) { return Convert<Int16?,object>.Instance.From(p); }
	}

	partial class ConvertExplicit<T,P>:
		// Scalar Types.
		// 
		IConvertible<Int16?,Int16>, 
		IConvertible<Int16?,String>, 

		IConvertible<Int16?,SByte>, 
		IConvertible<Int16?,Int32>, 
		IConvertible<Int16?,Int64>, 

		IConvertible<Int16?,Byte>, 
		IConvertible<Int16?,UInt16>, 
		IConvertible<Int16?,UInt32>, 
		IConvertible<Int16?,UInt64>, 

		IConvertible<Int16?,Single>, 
		IConvertible<Int16?,Double>, 

		IConvertible<Int16?,Boolean>, 
		IConvertible<Int16?,Decimal>, 
		IConvertible<Int16?,Char>, 

		// Nullable Types.
		// 
		IConvertible<Int16?,SByte?>, 
		IConvertible<Int16?,Int32?>, 
		IConvertible<Int16?,Int64?>, 

		IConvertible<Int16?,Byte?>, 
		IConvertible<Int16?,UInt16?>, 
		IConvertible<Int16?,UInt32?>, 
		IConvertible<Int16?,UInt64?>, 

		IConvertible<Int16?,Single?>, 
		IConvertible<Int16?,Double?>, 

		IConvertible<Int16?,Boolean?>, 
		IConvertible<Int16?,Decimal?>, 
		IConvertible<Int16?,Char?>, 

		// SqlTypes.
		// 
		IConvertible<Int16?,SqlInt16>, 
		IConvertible<Int16?,SqlString>, 

		IConvertible<Int16?,SqlByte>, 
		IConvertible<Int16?,SqlInt32>, 
		IConvertible<Int16?,SqlInt64>, 

		IConvertible<Int16?,SqlSingle>, 
		IConvertible<Int16?,SqlDouble>, 
		IConvertible<Int16?,SqlDecimal>, 
		IConvertible<Int16?,SqlMoney>, 

		IConvertible<Int16?,SqlBoolean>, 

		IConvertible<Int16?,object>

	{
		// Scalar Types.
		// 
		Int16? IConvertible<Int16?,Int16>.      From(Int16 p)       { return p; }
		Int16? IConvertible<Int16?,String>.     From(String p)      { return p == null? null: (Int16?)Convert.ToInt16(p); }

		Int16? IConvertible<Int16?,SByte>.      From(SByte p)       { return Convert.ToInt16(p); }
		Int16? IConvertible<Int16?,Int32>.      From(Int32 p)       { return Convert.ToInt16(p); }
		Int16? IConvertible<Int16?,Int64>.      From(Int64 p)       { return Convert.ToInt16(p); }

		Int16? IConvertible<Int16?,Byte>.       From(Byte p)        { return Convert.ToInt16(p); }
		Int16? IConvertible<Int16?,UInt16>.     From(UInt16 p)      { return Convert.ToInt16(p); }
		Int16? IConvertible<Int16?,UInt32>.     From(UInt32 p)      { return Convert.ToInt16(p); }
		Int16? IConvertible<Int16?,UInt64>.     From(UInt64 p)      { return Convert.ToInt16(p); }

		Int16? IConvertible<Int16?,Single>.     From(Single p)      { return Convert.ToInt16(p); }
		Int16? IConvertible<Int16?,Double>.     From(Double p)      { return Convert.ToInt16(p); }

		Int16? IConvertible<Int16?,Boolean>.    From(Boolean p)     { return Convert.ToInt16(p); }
		Int16? IConvertible<Int16?,Decimal>.    From(Decimal p)     { return Convert.ToInt16(p); }
		Int16? IConvertible<Int16?,Char>.       From(Char p)        { return Convert.ToInt16(p); }

		// Nullable Types.
		// 
		Int16? IConvertible<Int16?,SByte?>.     From(SByte? p)      { return p.HasValue? (Int16?)Convert.ToInt16(p.Value) : null; }
		Int16? IConvertible<Int16?,Int32?>.     From(Int32? p)      { return p.HasValue? (Int16?)Convert.ToInt16(p.Value) : null; }
		Int16? IConvertible<Int16?,Int64?>.     From(Int64? p)      { return p.HasValue? (Int16?)Convert.ToInt16(p.Value) : null; }

		Int16? IConvertible<Int16?,Byte?>.      From(Byte? p)       { return p.HasValue? (Int16?)Convert.ToInt16(p.Value) : null; }
		Int16? IConvertible<Int16?,UInt16?>.    From(UInt16? p)     { return p.HasValue? (Int16?)Convert.ToInt16(p.Value) : null; }
		Int16? IConvertible<Int16?,UInt32?>.    From(UInt32? p)     { return p.HasValue? (Int16?)Convert.ToInt16(p.Value) : null; }
		Int16? IConvertible<Int16?,UInt64?>.    From(UInt64? p)     { return p.HasValue? (Int16?)Convert.ToInt16(p.Value) : null; }

		Int16? IConvertible<Int16?,Single?>.    From(Single? p)     { return p.HasValue? (Int16?)Convert.ToInt16(p.Value) : null; }
		Int16? IConvertible<Int16?,Double?>.    From(Double? p)     { return p.HasValue? (Int16?)Convert.ToInt16(p.Value) : null; }

		Int16? IConvertible<Int16?,Boolean?>.   From(Boolean? p)    { return p.HasValue? (Int16?)Convert.ToInt16(p.Value) : null; }
		Int16? IConvertible<Int16?,Decimal?>.   From(Decimal? p)    { return p.HasValue? (Int16?)Convert.ToInt16(p.Value) : null; }
		Int16? IConvertible<Int16?,Char?>.      From(Char? p)       { return p.HasValue? (Int16?)Convert.ToInt16(p.Value) : null; }

		// SqlTypes.
		// 
		Int16? IConvertible<Int16?,SqlInt16>.   From(SqlInt16 p)    { return p.IsNull? null: (Int16?)                p.Value;  }
		Int16? IConvertible<Int16?,SqlString>.  From(SqlString p)   { return p.IsNull? null: (Int16?)Convert.ToInt16(p.Value); }

		Int16? IConvertible<Int16?,SqlByte>.    From(SqlByte p)     { return p.IsNull? null: (Int16?)Convert.ToInt16(p.Value); }
		Int16? IConvertible<Int16?,SqlInt32>.   From(SqlInt32 p)    { return p.IsNull? null: (Int16?)Convert.ToInt16(p.Value); }
		Int16? IConvertible<Int16?,SqlInt64>.   From(SqlInt64 p)    { return p.IsNull? null: (Int16?)Convert.ToInt16(p.Value); }

		Int16? IConvertible<Int16?,SqlSingle>.  From(SqlSingle p)   { return p.IsNull? null: (Int16?)Convert.ToInt16(p.Value); }
		Int16? IConvertible<Int16?,SqlDouble>.  From(SqlDouble p)   { return p.IsNull? null: (Int16?)Convert.ToInt16(p.Value); }
		Int16? IConvertible<Int16?,SqlDecimal>. From(SqlDecimal p)  { return p.IsNull? null: (Int16?)Convert.ToInt16(p.Value); }
		Int16? IConvertible<Int16?,SqlMoney>.   From(SqlMoney p)    { return p.IsNull? null: (Int16?)Convert.ToInt16(p.Value); }

		Int16? IConvertible<Int16?,SqlBoolean>. From(SqlBoolean p)  { return p.IsNull? null: (Int16?)Convert.ToInt16(p.Value); }

		Int16? IConvertible<Int16?,object>.     From(object p)      { return Convert.ToInt16(p); }
	}

	#endregion

	#region Int32?

	partial class ConvertPartial<T,P>: IConvertible<Int32?,P>
	{
		Int32? IConvertible<Int32?,P>.From(P p) { return Convert<Int32?,object>.Instance.From(p); }
	}

	partial class ConvertExplicit<T,P>:
		// Scalar Types.
		// 
		IConvertible<Int32?,Int32>, 
		IConvertible<Int32?,String>, 

		IConvertible<Int32?,SByte>, 
		IConvertible<Int32?,Int16>, 
		IConvertible<Int32?,Int64>, 

		IConvertible<Int32?,Byte>, 
		IConvertible<Int32?,UInt16>, 
		IConvertible<Int32?,UInt32>, 
		IConvertible<Int32?,UInt64>, 

		IConvertible<Int32?,Single>, 
		IConvertible<Int32?,Double>, 

		IConvertible<Int32?,Boolean>, 
		IConvertible<Int32?,Decimal>, 
		IConvertible<Int32?,Char>, 

		// Nullable Types.
		// 
		IConvertible<Int32?,SByte?>, 
		IConvertible<Int32?,Int16?>, 
		IConvertible<Int32?,Int64?>, 

		IConvertible<Int32?,Byte?>, 
		IConvertible<Int32?,UInt16?>, 
		IConvertible<Int32?,UInt32?>, 
		IConvertible<Int32?,UInt64?>, 

		IConvertible<Int32?,Single?>, 
		IConvertible<Int32?,Double?>, 

		IConvertible<Int32?,Boolean?>, 
		IConvertible<Int32?,Decimal?>, 
		IConvertible<Int32?,Char?>, 

		// SqlTypes.
		// 
		IConvertible<Int32?,SqlInt32>, 
		IConvertible<Int32?,SqlString>, 

		IConvertible<Int32?,SqlByte>, 
		IConvertible<Int32?,SqlInt16>, 
		IConvertible<Int32?,SqlInt64>, 

		IConvertible<Int32?,SqlSingle>, 
		IConvertible<Int32?,SqlDouble>, 
		IConvertible<Int32?,SqlDecimal>, 
		IConvertible<Int32?,SqlMoney>, 

		IConvertible<Int32?,SqlBoolean>, 

		IConvertible<Int32?,object>

	{
		// Scalar Types.
		// 
		Int32? IConvertible<Int32?,Int32>.      From(Int32 p)       { return p; }
		Int32? IConvertible<Int32?,String>.     From(String p)      { return p == null? null: (Int32?)Convert.ToInt32(p); }

		Int32? IConvertible<Int32?,SByte>.      From(SByte p)       { return Convert.ToInt32(p); }
		Int32? IConvertible<Int32?,Int16>.      From(Int16 p)       { return Convert.ToInt32(p); }
		Int32? IConvertible<Int32?,Int64>.      From(Int64 p)       { return Convert.ToInt32(p); }

		Int32? IConvertible<Int32?,Byte>.       From(Byte p)        { return Convert.ToInt32(p); }
		Int32? IConvertible<Int32?,UInt16>.     From(UInt16 p)      { return Convert.ToInt32(p); }
		Int32? IConvertible<Int32?,UInt32>.     From(UInt32 p)      { return Convert.ToInt32(p); }
		Int32? IConvertible<Int32?,UInt64>.     From(UInt64 p)      { return Convert.ToInt32(p); }

		Int32? IConvertible<Int32?,Single>.     From(Single p)      { return Convert.ToInt32(p); }
		Int32? IConvertible<Int32?,Double>.     From(Double p)      { return Convert.ToInt32(p); }

		Int32? IConvertible<Int32?,Boolean>.    From(Boolean p)     { return Convert.ToInt32(p); }
		Int32? IConvertible<Int32?,Decimal>.    From(Decimal p)     { return Convert.ToInt32(p); }
		Int32? IConvertible<Int32?,Char>.       From(Char p)        { return Convert.ToInt32(p); }

		// Nullable Types.
		// 
		Int32? IConvertible<Int32?,SByte?>.     From(SByte? p)      { return p.HasValue? (Int32?)Convert.ToInt32(p.Value) : null; }
		Int32? IConvertible<Int32?,Int16?>.     From(Int16? p)      { return p.HasValue? (Int32?)Convert.ToInt32(p.Value) : null; }
		Int32? IConvertible<Int32?,Int64?>.     From(Int64? p)      { return p.HasValue? (Int32?)Convert.ToInt32(p.Value) : null; }

		Int32? IConvertible<Int32?,Byte?>.      From(Byte? p)       { return p.HasValue? (Int32?)Convert.ToInt32(p.Value) : null; }
		Int32? IConvertible<Int32?,UInt16?>.    From(UInt16? p)     { return p.HasValue? (Int32?)Convert.ToInt32(p.Value) : null; }
		Int32? IConvertible<Int32?,UInt32?>.    From(UInt32? p)     { return p.HasValue? (Int32?)Convert.ToInt32(p.Value) : null; }
		Int32? IConvertible<Int32?,UInt64?>.    From(UInt64? p)     { return p.HasValue? (Int32?)Convert.ToInt32(p.Value) : null; }

		Int32? IConvertible<Int32?,Single?>.    From(Single? p)     { return p.HasValue? (Int32?)Convert.ToInt32(p.Value) : null; }
		Int32? IConvertible<Int32?,Double?>.    From(Double? p)     { return p.HasValue? (Int32?)Convert.ToInt32(p.Value) : null; }

		Int32? IConvertible<Int32?,Boolean?>.   From(Boolean? p)    { return p.HasValue? (Int32?)Convert.ToInt32(p.Value) : null; }
		Int32? IConvertible<Int32?,Decimal?>.   From(Decimal? p)    { return p.HasValue? (Int32?)Convert.ToInt32(p.Value) : null; }
		Int32? IConvertible<Int32?,Char?>.      From(Char? p)       { return p.HasValue? (Int32?)Convert.ToInt32(p.Value) : null; }

		// SqlTypes.
		// 
		Int32? IConvertible<Int32?,SqlInt32>.   From(SqlInt32 p)    { return p.IsNull? null: (Int32?)                p.Value;  }
		Int32? IConvertible<Int32?,SqlString>.  From(SqlString p)   { return p.IsNull? null: (Int32?)Convert.ToInt32(p.Value); }

		Int32? IConvertible<Int32?,SqlByte>.    From(SqlByte p)     { return p.IsNull? null: (Int32?)Convert.ToInt32(p.Value); }
		Int32? IConvertible<Int32?,SqlInt16>.   From(SqlInt16 p)    { return p.IsNull? null: (Int32?)Convert.ToInt32(p.Value); }
		Int32? IConvertible<Int32?,SqlInt64>.   From(SqlInt64 p)    { return p.IsNull? null: (Int32?)Convert.ToInt32(p.Value); }

		Int32? IConvertible<Int32?,SqlSingle>.  From(SqlSingle p)   { return p.IsNull? null: (Int32?)Convert.ToInt32(p.Value); }
		Int32? IConvertible<Int32?,SqlDouble>.  From(SqlDouble p)   { return p.IsNull? null: (Int32?)Convert.ToInt32(p.Value); }
		Int32? IConvertible<Int32?,SqlDecimal>. From(SqlDecimal p)  { return p.IsNull? null: (Int32?)Convert.ToInt32(p.Value); }
		Int32? IConvertible<Int32?,SqlMoney>.   From(SqlMoney p)    { return p.IsNull? null: (Int32?)Convert.ToInt32(p.Value); }

		Int32? IConvertible<Int32?,SqlBoolean>. From(SqlBoolean p)  { return p.IsNull? null: (Int32?)Convert.ToInt32(p.Value); }

		Int32? IConvertible<Int32?,object>.     From(object p)      { return Convert.ToInt32(p); }
	}

	#endregion

	#region Int64?

	partial class ConvertPartial<T,P>: IConvertible<Int64?,P>
	{
		Int64? IConvertible<Int64?,P>.From(P p) { return Convert<Int64?,object>.Instance.From(p); }
	}

	partial class ConvertExplicit<T,P>:
		// Scalar Types.
		// 
		IConvertible<Int64?,Int64>, 
		IConvertible<Int64?,String>, 

		IConvertible<Int64?,SByte>, 
		IConvertible<Int64?,Int16>, 
		IConvertible<Int64?,Int32>, 

		IConvertible<Int64?,Byte>, 
		IConvertible<Int64?,UInt16>, 
		IConvertible<Int64?,UInt32>, 
		IConvertible<Int64?,UInt64>, 

		IConvertible<Int64?,Single>, 
		IConvertible<Int64?,Double>, 

		IConvertible<Int64?,Boolean>, 
		IConvertible<Int64?,Decimal>, 
		IConvertible<Int64?,Char>, 

		// Nullable Types.
		// 
		IConvertible<Int64?,SByte?>, 
		IConvertible<Int64?,Int16?>, 
		IConvertible<Int64?,Int32?>, 

		IConvertible<Int64?,Byte?>, 
		IConvertible<Int64?,UInt16?>, 
		IConvertible<Int64?,UInt32?>, 
		IConvertible<Int64?,UInt64?>, 

		IConvertible<Int64?,Single?>, 
		IConvertible<Int64?,Double?>, 

		IConvertible<Int64?,Boolean?>, 
		IConvertible<Int64?,Decimal?>, 
		IConvertible<Int64?,Char?>, 

		// SqlTypes.
		// 
		IConvertible<Int64?,SqlInt64>, 
		IConvertible<Int64?,SqlString>, 

		IConvertible<Int64?,SqlByte>, 
		IConvertible<Int64?,SqlInt16>, 
		IConvertible<Int64?,SqlInt32>, 

		IConvertible<Int64?,SqlSingle>, 
		IConvertible<Int64?,SqlDouble>, 
		IConvertible<Int64?,SqlDecimal>, 
		IConvertible<Int64?,SqlMoney>, 

		IConvertible<Int64?,SqlBoolean>, 

		IConvertible<Int64?,object>

	{
		// Scalar Types.
		// 
		Int64? IConvertible<Int64?,Int64>.      From(Int64 p)       { return p; }
		Int64? IConvertible<Int64?,String>.     From(String p)      { return p == null? null: (Int64?)Convert.ToInt64(p); }

		Int64? IConvertible<Int64?,SByte>.      From(SByte p)       { return Convert.ToInt64(p); }
		Int64? IConvertible<Int64?,Int16>.      From(Int16 p)       { return Convert.ToInt64(p); }
		Int64? IConvertible<Int64?,Int32>.      From(Int32 p)       { return Convert.ToInt64(p); }

		Int64? IConvertible<Int64?,Byte>.       From(Byte p)        { return Convert.ToInt64(p); }
		Int64? IConvertible<Int64?,UInt16>.     From(UInt16 p)      { return Convert.ToInt64(p); }
		Int64? IConvertible<Int64?,UInt32>.     From(UInt32 p)      { return Convert.ToInt64(p); }
		Int64? IConvertible<Int64?,UInt64>.     From(UInt64 p)      { return Convert.ToInt64(p); }

		Int64? IConvertible<Int64?,Single>.     From(Single p)      { return Convert.ToInt64(p); }
		Int64? IConvertible<Int64?,Double>.     From(Double p)      { return Convert.ToInt64(p); }

		Int64? IConvertible<Int64?,Boolean>.    From(Boolean p)     { return Convert.ToInt64(p); }
		Int64? IConvertible<Int64?,Decimal>.    From(Decimal p)     { return Convert.ToInt64(p); }
		Int64? IConvertible<Int64?,Char>.       From(Char p)        { return Convert.ToInt64(p); }

		// Nullable Types.
		// 
		Int64? IConvertible<Int64?,SByte?>.     From(SByte? p)      { return p.HasValue? (Int64?)Convert.ToInt64(p.Value) : null; }
		Int64? IConvertible<Int64?,Int16?>.     From(Int16? p)      { return p.HasValue? (Int64?)Convert.ToInt64(p.Value) : null; }
		Int64? IConvertible<Int64?,Int32?>.     From(Int32? p)      { return p.HasValue? (Int64?)Convert.ToInt64(p.Value) : null; }

		Int64? IConvertible<Int64?,Byte?>.      From(Byte? p)       { return p.HasValue? (Int64?)Convert.ToInt64(p.Value) : null; }
		Int64? IConvertible<Int64?,UInt16?>.    From(UInt16? p)     { return p.HasValue? (Int64?)Convert.ToInt64(p.Value) : null; }
		Int64? IConvertible<Int64?,UInt32?>.    From(UInt32? p)     { return p.HasValue? (Int64?)Convert.ToInt64(p.Value) : null; }
		Int64? IConvertible<Int64?,UInt64?>.    From(UInt64? p)     { return p.HasValue? (Int64?)Convert.ToInt64(p.Value) : null; }

		Int64? IConvertible<Int64?,Single?>.    From(Single? p)     { return p.HasValue? (Int64?)Convert.ToInt64(p.Value) : null; }
		Int64? IConvertible<Int64?,Double?>.    From(Double? p)     { return p.HasValue? (Int64?)Convert.ToInt64(p.Value) : null; }

		Int64? IConvertible<Int64?,Boolean?>.   From(Boolean? p)    { return p.HasValue? (Int64?)Convert.ToInt64(p.Value) : null; }
		Int64? IConvertible<Int64?,Decimal?>.   From(Decimal? p)    { return p.HasValue? (Int64?)Convert.ToInt64(p.Value) : null; }
		Int64? IConvertible<Int64?,Char?>.      From(Char? p)       { return p.HasValue? (Int64?)Convert.ToInt64(p.Value) : null; }

		// SqlTypes.
		// 
		Int64? IConvertible<Int64?,SqlInt64>.   From(SqlInt64 p)    { return p.IsNull? null: (Int64?)                p.Value;  }
		Int64? IConvertible<Int64?,SqlString>.  From(SqlString p)   { return p.IsNull? null: (Int64?)Convert.ToInt64(p.Value); }

		Int64? IConvertible<Int64?,SqlByte>.    From(SqlByte p)     { return p.IsNull? null: (Int64?)Convert.ToInt64(p.Value); }
		Int64? IConvertible<Int64?,SqlInt16>.   From(SqlInt16 p)    { return p.IsNull? null: (Int64?)Convert.ToInt64(p.Value); }
		Int64? IConvertible<Int64?,SqlInt32>.   From(SqlInt32 p)    { return p.IsNull? null: (Int64?)Convert.ToInt64(p.Value); }

		Int64? IConvertible<Int64?,SqlSingle>.  From(SqlSingle p)   { return p.IsNull? null: (Int64?)Convert.ToInt64(p.Value); }
		Int64? IConvertible<Int64?,SqlDouble>.  From(SqlDouble p)   { return p.IsNull? null: (Int64?)Convert.ToInt64(p.Value); }
		Int64? IConvertible<Int64?,SqlDecimal>. From(SqlDecimal p)  { return p.IsNull? null: (Int64?)Convert.ToInt64(p.Value); }
		Int64? IConvertible<Int64?,SqlMoney>.   From(SqlMoney p)    { return p.IsNull? null: (Int64?)Convert.ToInt64(p.Value); }

		Int64? IConvertible<Int64?,SqlBoolean>. From(SqlBoolean p)  { return p.IsNull? null: (Int64?)Convert.ToInt64(p.Value); }

		Int64? IConvertible<Int64?,object>.     From(object p)      { return Convert.ToInt64(p); }
	}

	#endregion

	#region Byte?

	partial class ConvertPartial<T,P>: IConvertible<Byte?,P>
	{
		Byte? IConvertible<Byte?,P>.From(P p) { return Convert<Byte?,object>.Instance.From(p); }
	}

	partial class ConvertExplicit<T,P>:
		// Scalar Types.
		// 
		IConvertible<Byte?,Byte>, 
		IConvertible<Byte?,String>, 

		IConvertible<Byte?,SByte>, 
		IConvertible<Byte?,Int16>, 
		IConvertible<Byte?,Int32>, 
		IConvertible<Byte?,Int64>, 

		IConvertible<Byte?,UInt16>, 
		IConvertible<Byte?,UInt32>, 
		IConvertible<Byte?,UInt64>, 

		IConvertible<Byte?,Single>, 
		IConvertible<Byte?,Double>, 

		IConvertible<Byte?,Boolean>, 
		IConvertible<Byte?,Decimal>, 
		IConvertible<Byte?,Char>, 

		// Nullable Types.
		// 
		IConvertible<Byte?,SByte?>, 
		IConvertible<Byte?,Int16?>, 
		IConvertible<Byte?,Int32?>, 
		IConvertible<Byte?,Int64?>, 

		IConvertible<Byte?,UInt16?>, 
		IConvertible<Byte?,UInt32?>, 
		IConvertible<Byte?,UInt64?>, 

		IConvertible<Byte?,Single?>, 
		IConvertible<Byte?,Double?>, 

		IConvertible<Byte?,Boolean?>, 
		IConvertible<Byte?,Decimal?>, 
		IConvertible<Byte?,Char?>, 

		// SqlTypes.
		// 
		IConvertible<Byte?,SqlByte>, 
		IConvertible<Byte?,SqlString>, 

		IConvertible<Byte?,SqlInt16>, 
		IConvertible<Byte?,SqlInt32>, 
		IConvertible<Byte?,SqlInt64>, 

		IConvertible<Byte?,SqlSingle>, 
		IConvertible<Byte?,SqlDouble>, 
		IConvertible<Byte?,SqlDecimal>, 
		IConvertible<Byte?,SqlMoney>, 

		IConvertible<Byte?,SqlBoolean>, 

		IConvertible<Byte?,object>

	{
		// Scalar Types.
		// 
		Byte? IConvertible<Byte?,Byte>.       From(Byte p)        { return p; }
		Byte? IConvertible<Byte?,String>.     From(String p)      { return p == null? null: (Byte?)Convert.ToByte(p); }

		Byte? IConvertible<Byte?,SByte>.      From(SByte p)       { return Convert.ToByte(p); }
		Byte? IConvertible<Byte?,Int16>.      From(Int16 p)       { return Convert.ToByte(p); }
		Byte? IConvertible<Byte?,Int32>.      From(Int32 p)       { return Convert.ToByte(p); }
		Byte? IConvertible<Byte?,Int64>.      From(Int64 p)       { return Convert.ToByte(p); }

		Byte? IConvertible<Byte?,UInt16>.     From(UInt16 p)      { return Convert.ToByte(p); }
		Byte? IConvertible<Byte?,UInt32>.     From(UInt32 p)      { return Convert.ToByte(p); }
		Byte? IConvertible<Byte?,UInt64>.     From(UInt64 p)      { return Convert.ToByte(p); }

		Byte? IConvertible<Byte?,Single>.     From(Single p)      { return Convert.ToByte(p); }
		Byte? IConvertible<Byte?,Double>.     From(Double p)      { return Convert.ToByte(p); }

		Byte? IConvertible<Byte?,Boolean>.    From(Boolean p)     { return Convert.ToByte(p); }
		Byte? IConvertible<Byte?,Decimal>.    From(Decimal p)     { return Convert.ToByte(p); }
		Byte? IConvertible<Byte?,Char>.       From(Char p)        { return Convert.ToByte(p); }

		// Nullable Types.
		// 
		Byte? IConvertible<Byte?,SByte?>.     From(SByte? p)      { return p.HasValue? (Byte?)Convert.ToByte(p.Value) : null; }
		Byte? IConvertible<Byte?,Int16?>.     From(Int16? p)      { return p.HasValue? (Byte?)Convert.ToByte(p.Value) : null; }
		Byte? IConvertible<Byte?,Int32?>.     From(Int32? p)      { return p.HasValue? (Byte?)Convert.ToByte(p.Value) : null; }
		Byte? IConvertible<Byte?,Int64?>.     From(Int64? p)      { return p.HasValue? (Byte?)Convert.ToByte(p.Value) : null; }

		Byte? IConvertible<Byte?,UInt16?>.    From(UInt16? p)     { return p.HasValue? (Byte?)Convert.ToByte(p.Value) : null; }
		Byte? IConvertible<Byte?,UInt32?>.    From(UInt32? p)     { return p.HasValue? (Byte?)Convert.ToByte(p.Value) : null; }
		Byte? IConvertible<Byte?,UInt64?>.    From(UInt64? p)     { return p.HasValue? (Byte?)Convert.ToByte(p.Value) : null; }

		Byte? IConvertible<Byte?,Single?>.    From(Single? p)     { return p.HasValue? (Byte?)Convert.ToByte(p.Value) : null; }
		Byte? IConvertible<Byte?,Double?>.    From(Double? p)     { return p.HasValue? (Byte?)Convert.ToByte(p.Value) : null; }

		Byte? IConvertible<Byte?,Boolean?>.   From(Boolean? p)    { return p.HasValue? (Byte?)Convert.ToByte(p.Value) : null; }
		Byte? IConvertible<Byte?,Decimal?>.   From(Decimal? p)    { return p.HasValue? (Byte?)Convert.ToByte(p.Value) : null; }
		Byte? IConvertible<Byte?,Char?>.      From(Char? p)       { return p.HasValue? (Byte?)Convert.ToByte(p.Value) : null; }

		// SqlTypes.
		// 
		Byte? IConvertible<Byte?,SqlByte>.    From(SqlByte p)     { return p.IsNull? null: (Byte?)               p.Value;  }
		Byte? IConvertible<Byte?,SqlString>.  From(SqlString p)   { return p.IsNull? null: (Byte?)Convert.ToByte(p.Value); }

		Byte? IConvertible<Byte?,SqlInt16>.   From(SqlInt16 p)    { return p.IsNull? null: (Byte?)Convert.ToByte(p.Value); }
		Byte? IConvertible<Byte?,SqlInt32>.   From(SqlInt32 p)    { return p.IsNull? null: (Byte?)Convert.ToByte(p.Value); }
		Byte? IConvertible<Byte?,SqlInt64>.   From(SqlInt64 p)    { return p.IsNull? null: (Byte?)Convert.ToByte(p.Value); }

		Byte? IConvertible<Byte?,SqlSingle>.  From(SqlSingle p)   { return p.IsNull? null: (Byte?)Convert.ToByte(p.Value); }
		Byte? IConvertible<Byte?,SqlDouble>.  From(SqlDouble p)   { return p.IsNull? null: (Byte?)Convert.ToByte(p.Value); }
		Byte? IConvertible<Byte?,SqlDecimal>. From(SqlDecimal p)  { return p.IsNull? null: (Byte?)Convert.ToByte(p.Value); }
		Byte? IConvertible<Byte?,SqlMoney>.   From(SqlMoney p)    { return p.IsNull? null: (Byte?)Convert.ToByte(p.Value); }

		Byte? IConvertible<Byte?,SqlBoolean>. From(SqlBoolean p)  { return p.IsNull? null: (Byte?)Convert.ToByte(p.Value); }

		Byte? IConvertible<Byte?,object>.     From(object p)      { return Convert.ToByte(p); }
	}

	#endregion

	#region UInt16?

	partial class ConvertPartial<T,P>: IConvertible<UInt16?,P>
	{
		UInt16? IConvertible<UInt16?,P>.From(P p) { return Convert<UInt16?,object>.Instance.From(p); }
	}

	partial class ConvertExplicit<T,P>:
		// Scalar Types.
		// 
		IConvertible<UInt16?,UInt16>, 
		IConvertible<UInt16?,String>, 

		IConvertible<UInt16?,SByte>, 
		IConvertible<UInt16?,Int16>, 
		IConvertible<UInt16?,Int32>, 
		IConvertible<UInt16?,Int64>, 

		IConvertible<UInt16?,Byte>, 
		IConvertible<UInt16?,UInt32>, 
		IConvertible<UInt16?,UInt64>, 

		IConvertible<UInt16?,Single>, 
		IConvertible<UInt16?,Double>, 

		IConvertible<UInt16?,Boolean>, 
		IConvertible<UInt16?,Decimal>, 
		IConvertible<UInt16?,Char>, 

		// Nullable Types.
		// 
		IConvertible<UInt16?,SByte?>, 
		IConvertible<UInt16?,Int16?>, 
		IConvertible<UInt16?,Int32?>, 
		IConvertible<UInt16?,Int64?>, 

		IConvertible<UInt16?,Byte?>, 
		IConvertible<UInt16?,UInt32?>, 
		IConvertible<UInt16?,UInt64?>, 

		IConvertible<UInt16?,Single?>, 
		IConvertible<UInt16?,Double?>, 

		IConvertible<UInt16?,Boolean?>, 
		IConvertible<UInt16?,Decimal?>, 
		IConvertible<UInt16?,Char?>, 

		// SqlTypes.
		// 
		IConvertible<UInt16?,SqlString>, 

		IConvertible<UInt16?,SqlByte>, 
		IConvertible<UInt16?,SqlInt16>, 
		IConvertible<UInt16?,SqlInt32>, 
		IConvertible<UInt16?,SqlInt64>, 

		IConvertible<UInt16?,SqlSingle>, 
		IConvertible<UInt16?,SqlDouble>, 
		IConvertible<UInt16?,SqlDecimal>, 
		IConvertible<UInt16?,SqlMoney>, 

		IConvertible<UInt16?,SqlBoolean>, 

		IConvertible<UInt16?,object>

	{
		// Scalar Types.
		// 
		UInt16? IConvertible<UInt16?,UInt16>.     From(UInt16 p)      { return p; }
		UInt16? IConvertible<UInt16?,String>.     From(String p)      { return p == null? null: (UInt16?)Convert.ToUInt16(p); }

		UInt16? IConvertible<UInt16?,SByte>.      From(SByte p)       { return Convert.ToUInt16(p); }
		UInt16? IConvertible<UInt16?,Int16>.      From(Int16 p)       { return Convert.ToUInt16(p); }
		UInt16? IConvertible<UInt16?,Int32>.      From(Int32 p)       { return Convert.ToUInt16(p); }
		UInt16? IConvertible<UInt16?,Int64>.      From(Int64 p)       { return Convert.ToUInt16(p); }

		UInt16? IConvertible<UInt16?,Byte>.       From(Byte p)        { return Convert.ToUInt16(p); }
		UInt16? IConvertible<UInt16?,UInt32>.     From(UInt32 p)      { return Convert.ToUInt16(p); }
		UInt16? IConvertible<UInt16?,UInt64>.     From(UInt64 p)      { return Convert.ToUInt16(p); }

		UInt16? IConvertible<UInt16?,Single>.     From(Single p)      { return Convert.ToUInt16(p); }
		UInt16? IConvertible<UInt16?,Double>.     From(Double p)      { return Convert.ToUInt16(p); }

		UInt16? IConvertible<UInt16?,Boolean>.    From(Boolean p)     { return Convert.ToUInt16(p); }
		UInt16? IConvertible<UInt16?,Decimal>.    From(Decimal p)     { return Convert.ToUInt16(p); }
		UInt16? IConvertible<UInt16?,Char>.       From(Char p)        { return Convert.ToUInt16(p); }

		// Nullable Types.
		// 
		UInt16? IConvertible<UInt16?,SByte?>.     From(SByte? p)      { return p.HasValue? (UInt16?)Convert.ToUInt16(p.Value) : null; }
		UInt16? IConvertible<UInt16?,Int16?>.     From(Int16? p)      { return p.HasValue? (UInt16?)Convert.ToUInt16(p.Value) : null; }
		UInt16? IConvertible<UInt16?,Int32?>.     From(Int32? p)      { return p.HasValue? (UInt16?)Convert.ToUInt16(p.Value) : null; }
		UInt16? IConvertible<UInt16?,Int64?>.     From(Int64? p)      { return p.HasValue? (UInt16?)Convert.ToUInt16(p.Value) : null; }

		UInt16? IConvertible<UInt16?,Byte?>.      From(Byte? p)       { return p.HasValue? (UInt16?)Convert.ToUInt16(p.Value) : null; }
		UInt16? IConvertible<UInt16?,UInt32?>.    From(UInt32? p)     { return p.HasValue? (UInt16?)Convert.ToUInt16(p.Value) : null; }
		UInt16? IConvertible<UInt16?,UInt64?>.    From(UInt64? p)     { return p.HasValue? (UInt16?)Convert.ToUInt16(p.Value) : null; }

		UInt16? IConvertible<UInt16?,Single?>.    From(Single? p)     { return p.HasValue? (UInt16?)Convert.ToUInt16(p.Value) : null; }
		UInt16? IConvertible<UInt16?,Double?>.    From(Double? p)     { return p.HasValue? (UInt16?)Convert.ToUInt16(p.Value) : null; }

		UInt16? IConvertible<UInt16?,Boolean?>.   From(Boolean? p)    { return p.HasValue? (UInt16?)Convert.ToUInt16(p.Value) : null; }
		UInt16? IConvertible<UInt16?,Decimal?>.   From(Decimal? p)    { return p.HasValue? (UInt16?)Convert.ToUInt16(p.Value) : null; }
		UInt16? IConvertible<UInt16?,Char?>.      From(Char? p)       { return p.HasValue? (UInt16?)Convert.ToUInt16(p.Value) : null; }

		// SqlTypes.
		// 
		UInt16? IConvertible<UInt16?,SqlString>.  From(SqlString p)   { return p.IsNull? null: (UInt16?)Convert.ToUInt16(p.Value); }

		UInt16? IConvertible<UInt16?,SqlByte>.    From(SqlByte p)     { return p.IsNull? null: (UInt16?)Convert.ToUInt16(p.Value); }
		UInt16? IConvertible<UInt16?,SqlInt16>.   From(SqlInt16 p)    { return p.IsNull? null: (UInt16?)Convert.ToUInt16(p.Value); }
		UInt16? IConvertible<UInt16?,SqlInt32>.   From(SqlInt32 p)    { return p.IsNull? null: (UInt16?)Convert.ToUInt16(p.Value); }
		UInt16? IConvertible<UInt16?,SqlInt64>.   From(SqlInt64 p)    { return p.IsNull? null: (UInt16?)Convert.ToUInt16(p.Value); }

		UInt16? IConvertible<UInt16?,SqlSingle>.  From(SqlSingle p)   { return p.IsNull? null: (UInt16?)Convert.ToUInt16(p.Value); }
		UInt16? IConvertible<UInt16?,SqlDouble>.  From(SqlDouble p)   { return p.IsNull? null: (UInt16?)Convert.ToUInt16(p.Value); }
		UInt16? IConvertible<UInt16?,SqlDecimal>. From(SqlDecimal p)  { return p.IsNull? null: (UInt16?)Convert.ToUInt16(p.Value); }
		UInt16? IConvertible<UInt16?,SqlMoney>.   From(SqlMoney p)    { return p.IsNull? null: (UInt16?)Convert.ToUInt16(p.Value); }

		UInt16? IConvertible<UInt16?,SqlBoolean>. From(SqlBoolean p)  { return p.IsNull? null: (UInt16?)Convert.ToUInt16(p.Value); }

		UInt16? IConvertible<UInt16?,object>.     From(object p)      { return Convert.ToUInt16(p); }
	}

	#endregion

	#region UInt32?

	partial class ConvertPartial<T,P>: IConvertible<UInt32?,P>
	{
		UInt32? IConvertible<UInt32?,P>.From(P p) { return Convert<UInt32?,object>.Instance.From(p); }
	}

	partial class ConvertExplicit<T,P>:
		// Scalar Types.
		// 
		IConvertible<UInt32?,UInt32>, 
		IConvertible<UInt32?,String>, 

		IConvertible<UInt32?,SByte>, 
		IConvertible<UInt32?,Int16>, 
		IConvertible<UInt32?,Int32>, 
		IConvertible<UInt32?,Int64>, 

		IConvertible<UInt32?,Byte>, 
		IConvertible<UInt32?,UInt16>, 
		IConvertible<UInt32?,UInt64>, 

		IConvertible<UInt32?,Single>, 
		IConvertible<UInt32?,Double>, 

		IConvertible<UInt32?,Boolean>, 
		IConvertible<UInt32?,Decimal>, 
		IConvertible<UInt32?,Char>, 

		// Nullable Types.
		// 
		IConvertible<UInt32?,SByte?>, 
		IConvertible<UInt32?,Int16?>, 
		IConvertible<UInt32?,Int32?>, 
		IConvertible<UInt32?,Int64?>, 

		IConvertible<UInt32?,Byte?>, 
		IConvertible<UInt32?,UInt16?>, 
		IConvertible<UInt32?,UInt64?>, 

		IConvertible<UInt32?,Single?>, 
		IConvertible<UInt32?,Double?>, 

		IConvertible<UInt32?,Boolean?>, 
		IConvertible<UInt32?,Decimal?>, 
		IConvertible<UInt32?,Char?>, 

		// SqlTypes.
		// 
		IConvertible<UInt32?,SqlString>, 

		IConvertible<UInt32?,SqlByte>, 
		IConvertible<UInt32?,SqlInt16>, 
		IConvertible<UInt32?,SqlInt32>, 
		IConvertible<UInt32?,SqlInt64>, 

		IConvertible<UInt32?,SqlSingle>, 
		IConvertible<UInt32?,SqlDouble>, 
		IConvertible<UInt32?,SqlDecimal>, 
		IConvertible<UInt32?,SqlMoney>, 

		IConvertible<UInt32?,SqlBoolean>, 

		IConvertible<UInt32?,object>

	{
		// Scalar Types.
		// 
		UInt32? IConvertible<UInt32?,UInt32>.     From(UInt32 p)      { return p; }
		UInt32? IConvertible<UInt32?,String>.     From(String p)      { return p == null? null: (UInt32?)Convert.ToUInt32(p); }

		UInt32? IConvertible<UInt32?,SByte>.      From(SByte p)       { return Convert.ToUInt32(p); }
		UInt32? IConvertible<UInt32?,Int16>.      From(Int16 p)       { return Convert.ToUInt32(p); }
		UInt32? IConvertible<UInt32?,Int32>.      From(Int32 p)       { return Convert.ToUInt32(p); }
		UInt32? IConvertible<UInt32?,Int64>.      From(Int64 p)       { return Convert.ToUInt32(p); }

		UInt32? IConvertible<UInt32?,Byte>.       From(Byte p)        { return Convert.ToUInt32(p); }
		UInt32? IConvertible<UInt32?,UInt16>.     From(UInt16 p)      { return Convert.ToUInt32(p); }
		UInt32? IConvertible<UInt32?,UInt64>.     From(UInt64 p)      { return Convert.ToUInt32(p); }

		UInt32? IConvertible<UInt32?,Single>.     From(Single p)      { return Convert.ToUInt32(p); }
		UInt32? IConvertible<UInt32?,Double>.     From(Double p)      { return Convert.ToUInt32(p); }

		UInt32? IConvertible<UInt32?,Boolean>.    From(Boolean p)     { return Convert.ToUInt32(p); }
		UInt32? IConvertible<UInt32?,Decimal>.    From(Decimal p)     { return Convert.ToUInt32(p); }
		UInt32? IConvertible<UInt32?,Char>.       From(Char p)        { return Convert.ToUInt32(p); }

		// Nullable Types.
		// 
		UInt32? IConvertible<UInt32?,SByte?>.     From(SByte? p)      { return p.HasValue? (UInt32?)Convert.ToUInt32(p.Value) : null; }
		UInt32? IConvertible<UInt32?,Int16?>.     From(Int16? p)      { return p.HasValue? (UInt32?)Convert.ToUInt32(p.Value) : null; }
		UInt32? IConvertible<UInt32?,Int32?>.     From(Int32? p)      { return p.HasValue? (UInt32?)Convert.ToUInt32(p.Value) : null; }
		UInt32? IConvertible<UInt32?,Int64?>.     From(Int64? p)      { return p.HasValue? (UInt32?)Convert.ToUInt32(p.Value) : null; }

		UInt32? IConvertible<UInt32?,Byte?>.      From(Byte? p)       { return p.HasValue? (UInt32?)Convert.ToUInt32(p.Value) : null; }
		UInt32? IConvertible<UInt32?,UInt16?>.    From(UInt16? p)     { return p.HasValue? (UInt32?)Convert.ToUInt32(p.Value) : null; }
		UInt32? IConvertible<UInt32?,UInt64?>.    From(UInt64? p)     { return p.HasValue? (UInt32?)Convert.ToUInt32(p.Value) : null; }

		UInt32? IConvertible<UInt32?,Single?>.    From(Single? p)     { return p.HasValue? (UInt32?)Convert.ToUInt32(p.Value) : null; }
		UInt32? IConvertible<UInt32?,Double?>.    From(Double? p)     { return p.HasValue? (UInt32?)Convert.ToUInt32(p.Value) : null; }

		UInt32? IConvertible<UInt32?,Boolean?>.   From(Boolean? p)    { return p.HasValue? (UInt32?)Convert.ToUInt32(p.Value) : null; }
		UInt32? IConvertible<UInt32?,Decimal?>.   From(Decimal? p)    { return p.HasValue? (UInt32?)Convert.ToUInt32(p.Value) : null; }
		UInt32? IConvertible<UInt32?,Char?>.      From(Char? p)       { return p.HasValue? (UInt32?)Convert.ToUInt32(p.Value) : null; }

		// SqlTypes.
		// 
		UInt32? IConvertible<UInt32?,SqlString>.  From(SqlString p)   { return p.IsNull? null: (UInt32?)Convert.ToUInt32(p.Value); }

		UInt32? IConvertible<UInt32?,SqlByte>.    From(SqlByte p)     { return p.IsNull? null: (UInt32?)Convert.ToUInt32(p.Value); }
		UInt32? IConvertible<UInt32?,SqlInt16>.   From(SqlInt16 p)    { return p.IsNull? null: (UInt32?)Convert.ToUInt32(p.Value); }
		UInt32? IConvertible<UInt32?,SqlInt32>.   From(SqlInt32 p)    { return p.IsNull? null: (UInt32?)Convert.ToUInt32(p.Value); }
		UInt32? IConvertible<UInt32?,SqlInt64>.   From(SqlInt64 p)    { return p.IsNull? null: (UInt32?)Convert.ToUInt32(p.Value); }

		UInt32? IConvertible<UInt32?,SqlSingle>.  From(SqlSingle p)   { return p.IsNull? null: (UInt32?)Convert.ToUInt32(p.Value); }
		UInt32? IConvertible<UInt32?,SqlDouble>.  From(SqlDouble p)   { return p.IsNull? null: (UInt32?)Convert.ToUInt32(p.Value); }
		UInt32? IConvertible<UInt32?,SqlDecimal>. From(SqlDecimal p)  { return p.IsNull? null: (UInt32?)Convert.ToUInt32(p.Value); }
		UInt32? IConvertible<UInt32?,SqlMoney>.   From(SqlMoney p)    { return p.IsNull? null: (UInt32?)Convert.ToUInt32(p.Value); }

		UInt32? IConvertible<UInt32?,SqlBoolean>. From(SqlBoolean p)  { return p.IsNull? null: (UInt32?)Convert.ToUInt32(p.Value); }

		UInt32? IConvertible<UInt32?,object>.     From(object p)      { return Convert.ToUInt32(p); }
	}

	#endregion

	#region UInt64?

	partial class ConvertPartial<T,P>: IConvertible<UInt64?,P>
	{
		UInt64? IConvertible<UInt64?,P>.From(P p) { return Convert<UInt64?,object>.Instance.From(p); }
	}

	partial class ConvertExplicit<T,P>:
		// Scalar Types.
		// 
		IConvertible<UInt64?,UInt64>, 
		IConvertible<UInt64?,String>, 

		IConvertible<UInt64?,SByte>, 
		IConvertible<UInt64?,Int16>, 
		IConvertible<UInt64?,Int32>, 
		IConvertible<UInt64?,Int64>, 

		IConvertible<UInt64?,Byte>, 
		IConvertible<UInt64?,UInt16>, 
		IConvertible<UInt64?,UInt32>, 

		IConvertible<UInt64?,Single>, 
		IConvertible<UInt64?,Double>, 

		IConvertible<UInt64?,Boolean>, 
		IConvertible<UInt64?,Decimal>, 
		IConvertible<UInt64?,Char>, 

		// Nullable Types.
		// 
		IConvertible<UInt64?,SByte?>, 
		IConvertible<UInt64?,Int16?>, 
		IConvertible<UInt64?,Int32?>, 
		IConvertible<UInt64?,Int64?>, 

		IConvertible<UInt64?,Byte?>, 
		IConvertible<UInt64?,UInt16?>, 
		IConvertible<UInt64?,UInt32?>, 

		IConvertible<UInt64?,Single?>, 
		IConvertible<UInt64?,Double?>, 

		IConvertible<UInt64?,Boolean?>, 
		IConvertible<UInt64?,Decimal?>, 
		IConvertible<UInt64?,Char?>, 

		// SqlTypes.
		// 
		IConvertible<UInt64?,SqlString>, 

		IConvertible<UInt64?,SqlByte>, 
		IConvertible<UInt64?,SqlInt16>, 
		IConvertible<UInt64?,SqlInt32>, 
		IConvertible<UInt64?,SqlInt64>, 

		IConvertible<UInt64?,SqlSingle>, 
		IConvertible<UInt64?,SqlDouble>, 
		IConvertible<UInt64?,SqlDecimal>, 
		IConvertible<UInt64?,SqlMoney>, 

		IConvertible<UInt64?,SqlBoolean>, 

		IConvertible<UInt64?,object>

	{
		// Scalar Types.
		// 
		UInt64? IConvertible<UInt64?,UInt64>.     From(UInt64 p)      { return p; }
		UInt64? IConvertible<UInt64?,String>.     From(String p)      { return p == null? null: (UInt64?)Convert.ToUInt64(p); }

		UInt64? IConvertible<UInt64?,SByte>.      From(SByte p)       { return Convert.ToUInt64(p); }
		UInt64? IConvertible<UInt64?,Int16>.      From(Int16 p)       { return Convert.ToUInt64(p); }
		UInt64? IConvertible<UInt64?,Int32>.      From(Int32 p)       { return Convert.ToUInt64(p); }
		UInt64? IConvertible<UInt64?,Int64>.      From(Int64 p)       { return Convert.ToUInt64(p); }

		UInt64? IConvertible<UInt64?,Byte>.       From(Byte p)        { return Convert.ToUInt64(p); }
		UInt64? IConvertible<UInt64?,UInt16>.     From(UInt16 p)      { return Convert.ToUInt64(p); }
		UInt64? IConvertible<UInt64?,UInt32>.     From(UInt32 p)      { return Convert.ToUInt64(p); }

		UInt64? IConvertible<UInt64?,Single>.     From(Single p)      { return Convert.ToUInt64(p); }
		UInt64? IConvertible<UInt64?,Double>.     From(Double p)      { return Convert.ToUInt64(p); }

		UInt64? IConvertible<UInt64?,Boolean>.    From(Boolean p)     { return Convert.ToUInt64(p); }
		UInt64? IConvertible<UInt64?,Decimal>.    From(Decimal p)     { return Convert.ToUInt64(p); }
		UInt64? IConvertible<UInt64?,Char>.       From(Char p)        { return Convert.ToUInt64(p); }

		// Nullable Types.
		// 
		UInt64? IConvertible<UInt64?,SByte?>.     From(SByte? p)      { return p.HasValue? (UInt64?)Convert.ToUInt64(p.Value) : null; }
		UInt64? IConvertible<UInt64?,Int16?>.     From(Int16? p)      { return p.HasValue? (UInt64?)Convert.ToUInt64(p.Value) : null; }
		UInt64? IConvertible<UInt64?,Int32?>.     From(Int32? p)      { return p.HasValue? (UInt64?)Convert.ToUInt64(p.Value) : null; }
		UInt64? IConvertible<UInt64?,Int64?>.     From(Int64? p)      { return p.HasValue? (UInt64?)Convert.ToUInt64(p.Value) : null; }

		UInt64? IConvertible<UInt64?,Byte?>.      From(Byte? p)       { return p.HasValue? (UInt64?)Convert.ToUInt64(p.Value) : null; }
		UInt64? IConvertible<UInt64?,UInt16?>.    From(UInt16? p)     { return p.HasValue? (UInt64?)Convert.ToUInt64(p.Value) : null; }
		UInt64? IConvertible<UInt64?,UInt32?>.    From(UInt32? p)     { return p.HasValue? (UInt64?)Convert.ToUInt64(p.Value) : null; }

		UInt64? IConvertible<UInt64?,Single?>.    From(Single? p)     { return p.HasValue? (UInt64?)Convert.ToUInt64(p.Value) : null; }
		UInt64? IConvertible<UInt64?,Double?>.    From(Double? p)     { return p.HasValue? (UInt64?)Convert.ToUInt64(p.Value) : null; }

		UInt64? IConvertible<UInt64?,Boolean?>.   From(Boolean? p)    { return p.HasValue? (UInt64?)Convert.ToUInt64(p.Value) : null; }
		UInt64? IConvertible<UInt64?,Decimal?>.   From(Decimal? p)    { return p.HasValue? (UInt64?)Convert.ToUInt64(p.Value) : null; }
		UInt64? IConvertible<UInt64?,Char?>.      From(Char? p)       { return p.HasValue? (UInt64?)Convert.ToUInt64(p.Value) : null; }

		// SqlTypes.
		// 
		UInt64? IConvertible<UInt64?,SqlString>.  From(SqlString p)   { return p.IsNull? null: (UInt64?)Convert.ToUInt64(p.Value); }

		UInt64? IConvertible<UInt64?,SqlByte>.    From(SqlByte p)     { return p.IsNull? null: (UInt64?)Convert.ToUInt64(p.Value); }
		UInt64? IConvertible<UInt64?,SqlInt16>.   From(SqlInt16 p)    { return p.IsNull? null: (UInt64?)Convert.ToUInt64(p.Value); }
		UInt64? IConvertible<UInt64?,SqlInt32>.   From(SqlInt32 p)    { return p.IsNull? null: (UInt64?)Convert.ToUInt64(p.Value); }
		UInt64? IConvertible<UInt64?,SqlInt64>.   From(SqlInt64 p)    { return p.IsNull? null: (UInt64?)Convert.ToUInt64(p.Value); }

		UInt64? IConvertible<UInt64?,SqlSingle>.  From(SqlSingle p)   { return p.IsNull? null: (UInt64?)Convert.ToUInt64(p.Value); }
		UInt64? IConvertible<UInt64?,SqlDouble>.  From(SqlDouble p)   { return p.IsNull? null: (UInt64?)Convert.ToUInt64(p.Value); }
		UInt64? IConvertible<UInt64?,SqlDecimal>. From(SqlDecimal p)  { return p.IsNull? null: (UInt64?)Convert.ToUInt64(p.Value); }
		UInt64? IConvertible<UInt64?,SqlMoney>.   From(SqlMoney p)    { return p.IsNull? null: (UInt64?)Convert.ToUInt64(p.Value); }

		UInt64? IConvertible<UInt64?,SqlBoolean>. From(SqlBoolean p)  { return p.IsNull? null: (UInt64?)Convert.ToUInt64(p.Value); }

		UInt64? IConvertible<UInt64?,object>.     From(object p)      { return Convert.ToUInt64(p); }
	}

	#endregion

	#region Char?

	partial class ConvertPartial<T,P>: IConvertible<Char?,P>
	{
		Char? IConvertible<Char?,P>.From(P p) { return Convert<Char?,object>.Instance.From(p); }
	}

	partial class ConvertExplicit<T,P>:
		// Scalar Types.
		// 
		IConvertible<Char?,Char>, 
		IConvertible<Char?,String>, 

		IConvertible<Char?,SByte>, 
		IConvertible<Char?,Int16>, 
		IConvertible<Char?,Int32>, 
		IConvertible<Char?,Int64>, 

		IConvertible<Char?,Byte>, 
		IConvertible<Char?,UInt16>, 
		IConvertible<Char?,UInt32>, 
		IConvertible<Char?,UInt64>, 
		IConvertible<Char?,Boolean>, 

		// Nullable Types.
		// 
		IConvertible<Char?,SByte?>, 
		IConvertible<Char?,Int16?>, 
		IConvertible<Char?,Int32?>, 
		IConvertible<Char?,Int64?>, 

		IConvertible<Char?,Byte?>, 
		IConvertible<Char?,UInt16?>, 
		IConvertible<Char?,UInt32?>, 
		IConvertible<Char?,UInt64?>, 
		IConvertible<Char?,Boolean?>, 

		// SqlTypes.
		// 
		IConvertible<Char?,SqlByte>, 
		IConvertible<Char?,SqlInt16>, 
		IConvertible<Char?,SqlInt32>, 
		IConvertible<Char?,SqlInt64>, 
		IConvertible<Char?,SqlBoolean>, 

		IConvertible<Char?,object>

	{
		// Scalar Types.
		// 
		Char? IConvertible<Char?,Char>.       From(Char p)        { return p; }
		Char? IConvertible<Char?,String>.     From(String p)      { return p == null? null: (Char?)Convert.ToChar(p); }

		Char? IConvertible<Char?,SByte>.      From(SByte p)       { return Convert.ToChar(p); }
		Char? IConvertible<Char?,Int16>.      From(Int16 p)       { return Convert.ToChar(p); }
		Char? IConvertible<Char?,Int32>.      From(Int32 p)       { return Convert.ToChar(p); }
		Char? IConvertible<Char?,Int64>.      From(Int64 p)       { return Convert.ToChar(p); }

		Char? IConvertible<Char?,Byte>.       From(Byte p)        { return Convert.ToChar(p); }
		Char? IConvertible<Char?,UInt16>.     From(UInt16 p)      { return Convert.ToChar(p); }
		Char? IConvertible<Char?,UInt32>.     From(UInt32 p)      { return Convert.ToChar(p); }
		Char? IConvertible<Char?,UInt64>.     From(UInt64 p)      { return Convert.ToChar(p); }
		Char? IConvertible<Char?,Boolean>.    From(Boolean p)     { return p? '1':'0'; }

		// Nullable Types.
		// 
		Char? IConvertible<Char?,SByte?>.     From(SByte? p)      { return p.HasValue? (Char?)Convert.ToChar(p.Value) : null; }
		Char? IConvertible<Char?,Int16?>.     From(Int16? p)      { return p.HasValue? (Char?)Convert.ToChar(p.Value) : null; }
		Char? IConvertible<Char?,Int32?>.     From(Int32? p)      { return p.HasValue? (Char?)Convert.ToChar(p.Value) : null; }
		Char? IConvertible<Char?,Int64?>.     From(Int64? p)      { return p.HasValue? (Char?)Convert.ToChar(p.Value) : null; }

		Char? IConvertible<Char?,Byte?>.      From(Byte? p)       { return p.HasValue? (Char?)Convert.ToChar(p.Value) : null; }
		Char? IConvertible<Char?,UInt16?>.    From(UInt16? p)     { return p.HasValue? (Char?)Convert.ToChar(p.Value) : null; }
		Char? IConvertible<Char?,UInt32?>.    From(UInt32? p)     { return p.HasValue? (Char?)Convert.ToChar(p.Value) : null; }
		Char? IConvertible<Char?,UInt64?>.    From(UInt64? p)     { return p.HasValue? (Char?)Convert.ToChar(p.Value) : null; }
		Char? IConvertible<Char?,Boolean?>.   From(Boolean? p)    { return p.HasValue? (Char?)(p.Value? '1':'0')      : null; }

		// SqlTypes.
		// 
		Char? IConvertible<Char?,SqlByte>.    From(SqlByte p)     { return p.IsNull? null: (Char?)Convert.ToChar(p.Value); }
		Char? IConvertible<Char?,SqlInt16>.   From(SqlInt16 p)    { return p.IsNull? null: (Char?)Convert.ToChar(p.Value); }
		Char? IConvertible<Char?,SqlInt32>.   From(SqlInt32 p)    { return p.IsNull? null: (Char?)Convert.ToChar(p.Value); }
		Char? IConvertible<Char?,SqlInt64>.   From(SqlInt64 p)    { return p.IsNull? null: (Char?)Convert.ToChar(p.Value); }
		Char? IConvertible<Char?,SqlBoolean>. From(SqlBoolean p)  { return p.IsNull? null: (Char?)(p.Value? '1':'0'); }

		Char? IConvertible<Char?,object>.     From(object p)      { return Convert.ToChar(p); }
	}

	#endregion

	#region Single?

	partial class ConvertPartial<T,P>: IConvertible<Single?,P>
	{
		Single? IConvertible<Single?,P>.From(P p) { return Convert<Single?,object>.Instance.From(p); }
	}

	partial class ConvertExplicit<T,P>:
		// Scalar Types.
		// 
		IConvertible<Single?,Single>, 
		IConvertible<Single?,String>, 

		IConvertible<Single?,SByte>, 
		IConvertible<Single?,Int16>, 
		IConvertible<Single?,Int32>, 
		IConvertible<Single?,Int64>, 

		IConvertible<Single?,Byte>, 
		IConvertible<Single?,UInt16>, 
		IConvertible<Single?,UInt32>, 
		IConvertible<Single?,UInt64>, 

		IConvertible<Single?,Double>, 

		IConvertible<Single?,Boolean>, 
		IConvertible<Single?,Decimal>, 

		// Nullable Types.
		// 
		IConvertible<Single?,SByte?>, 
		IConvertible<Single?,Int16?>, 
		IConvertible<Single?,Int32?>, 
		IConvertible<Single?,Int64?>, 

		IConvertible<Single?,Byte?>, 
		IConvertible<Single?,UInt16?>, 
		IConvertible<Single?,UInt32?>, 
		IConvertible<Single?,UInt64?>, 

		IConvertible<Single?,Double?>, 

		IConvertible<Single?,Boolean?>, 
		IConvertible<Single?,Decimal?>, 

		// SqlTypes.
		// 
		IConvertible<Single?,SqlSingle>, 
		IConvertible<Single?,SqlString>, 

		IConvertible<Single?,SqlByte>, 
		IConvertible<Single?,SqlInt16>, 
		IConvertible<Single?,SqlInt32>, 
		IConvertible<Single?,SqlInt64>, 

		IConvertible<Single?,SqlDouble>, 
		IConvertible<Single?,SqlDecimal>, 
		IConvertible<Single?,SqlMoney>, 

		IConvertible<Single?,SqlBoolean>, 

		IConvertible<Single?,object>

	{
		// Scalar Types.
		// 
		Single? IConvertible<Single?,Single>.     From(Single p)      { return p; }
		Single? IConvertible<Single?,String>.     From(String p)      { return p == null? null: (Single?)Convert.ToSingle(p); }

		Single? IConvertible<Single?,SByte>.      From(SByte p)       { return Convert.ToSingle(p); }
		Single? IConvertible<Single?,Int16>.      From(Int16 p)       { return Convert.ToSingle(p); }
		Single? IConvertible<Single?,Int32>.      From(Int32 p)       { return Convert.ToSingle(p); }
		Single? IConvertible<Single?,Int64>.      From(Int64 p)       { return Convert.ToSingle(p); }

		Single? IConvertible<Single?,Byte>.       From(Byte p)        { return Convert.ToSingle(p); }
		Single? IConvertible<Single?,UInt16>.     From(UInt16 p)      { return Convert.ToSingle(p); }
		Single? IConvertible<Single?,UInt32>.     From(UInt32 p)      { return Convert.ToSingle(p); }
		Single? IConvertible<Single?,UInt64>.     From(UInt64 p)      { return Convert.ToSingle(p); }

		Single? IConvertible<Single?,Double>.     From(Double p)      { return Convert.ToSingle(p); }

		Single? IConvertible<Single?,Boolean>.    From(Boolean p)     { return Convert.ToSingle(p); }
		Single? IConvertible<Single?,Decimal>.    From(Decimal p)     { return Convert.ToSingle(p); }

		// Nullable Types.
		// 
		Single? IConvertible<Single?,SByte?>.     From(SByte? p)      { return p.HasValue? (Single?)Convert.ToSingle(p.Value) : null; }
		Single? IConvertible<Single?,Int16?>.     From(Int16? p)      { return p.HasValue? (Single?)Convert.ToSingle(p.Value) : null; }
		Single? IConvertible<Single?,Int32?>.     From(Int32? p)      { return p.HasValue? (Single?)Convert.ToSingle(p.Value) : null; }
		Single? IConvertible<Single?,Int64?>.     From(Int64? p)      { return p.HasValue? (Single?)Convert.ToSingle(p.Value) : null; }

		Single? IConvertible<Single?,Byte?>.      From(Byte? p)       { return p.HasValue? (Single?)Convert.ToSingle(p.Value) : null; }
		Single? IConvertible<Single?,UInt16?>.    From(UInt16? p)     { return p.HasValue? (Single?)Convert.ToSingle(p.Value) : null; }
		Single? IConvertible<Single?,UInt32?>.    From(UInt32? p)     { return p.HasValue? (Single?)Convert.ToSingle(p.Value) : null; }
		Single? IConvertible<Single?,UInt64?>.    From(UInt64? p)     { return p.HasValue? (Single?)Convert.ToSingle(p.Value) : null; }

		Single? IConvertible<Single?,Double?>.    From(Double? p)     { return p.HasValue? (Single?)Convert.ToSingle(p.Value) : null; }

		Single? IConvertible<Single?,Boolean?>.   From(Boolean? p)    { return p.HasValue? (Single?)Convert.ToSingle(p.Value) : null; }
		Single? IConvertible<Single?,Decimal?>.   From(Decimal? p)    { return p.HasValue? (Single?)Convert.ToSingle(p.Value) : null; }

		// SqlTypes.
		// 
		Single? IConvertible<Single?,SqlSingle>.  From(SqlSingle p)   { return p.IsNull? null: (Single?)                 p.Value;  }
		Single? IConvertible<Single?,SqlString>.  From(SqlString p)   { return p.IsNull? null: (Single?)Convert.ToSingle(p.Value); }

		Single? IConvertible<Single?,SqlByte>.    From(SqlByte p)     { return p.IsNull? null: (Single?)Convert.ToSingle(p.Value); }
		Single? IConvertible<Single?,SqlInt16>.   From(SqlInt16 p)    { return p.IsNull? null: (Single?)Convert.ToSingle(p.Value); }
		Single? IConvertible<Single?,SqlInt32>.   From(SqlInt32 p)    { return p.IsNull? null: (Single?)Convert.ToSingle(p.Value); }
		Single? IConvertible<Single?,SqlInt64>.   From(SqlInt64 p)    { return p.IsNull? null: (Single?)Convert.ToSingle(p.Value); }

		Single? IConvertible<Single?,SqlDouble>.  From(SqlDouble p)   { return p.IsNull? null: (Single?)Convert.ToSingle(p.Value); }
		Single? IConvertible<Single?,SqlDecimal>. From(SqlDecimal p)  { return p.IsNull? null: (Single?)Convert.ToSingle(p.Value); }
		Single? IConvertible<Single?,SqlMoney>.   From(SqlMoney p)    { return p.IsNull? null: (Single?)Convert.ToSingle(p.Value); }

		Single? IConvertible<Single?,SqlBoolean>. From(SqlBoolean p)  { return p.IsNull? null: (Single?)Convert.ToSingle(p.Value); }

		Single? IConvertible<Single?,object>.     From(object p)      { return Convert.ToSingle(p); }
	}

	#endregion

	#region Double?

	partial class ConvertPartial<T,P>: IConvertible<Double?,P>
	{
		Double? IConvertible<Double?,P>.From(P p) { return Convert<Double?,object>.Instance.From(p); }
	}

	partial class ConvertExplicit<T,P>:
		// Scalar Types.
		// 
		IConvertible<Double?,Double>, 
		IConvertible<Double?,String>, 

		IConvertible<Double?,SByte>, 
		IConvertible<Double?,Int16>, 
		IConvertible<Double?,Int32>, 
		IConvertible<Double?,Int64>, 

		IConvertible<Double?,Byte>, 
		IConvertible<Double?,UInt16>, 
		IConvertible<Double?,UInt32>, 
		IConvertible<Double?,UInt64>, 

		IConvertible<Double?,Single>, 

		IConvertible<Double?,Boolean>, 
		IConvertible<Double?,Decimal>, 

		// Nullable Types.
		// 
		IConvertible<Double?,SByte?>, 
		IConvertible<Double?,Int16?>, 
		IConvertible<Double?,Int32?>, 
		IConvertible<Double?,Int64?>, 

		IConvertible<Double?,Byte?>, 
		IConvertible<Double?,UInt16?>, 
		IConvertible<Double?,UInt32?>, 
		IConvertible<Double?,UInt64?>, 

		IConvertible<Double?,Single?>, 

		IConvertible<Double?,Boolean?>, 
		IConvertible<Double?,Decimal?>, 

		// SqlTypes.
		// 
		IConvertible<Double?,SqlDouble>, 
		IConvertible<Double?,SqlString>, 

		IConvertible<Double?,SqlByte>, 
		IConvertible<Double?,SqlInt16>, 
		IConvertible<Double?,SqlInt32>, 
		IConvertible<Double?,SqlInt64>, 

		IConvertible<Double?,SqlSingle>, 
		IConvertible<Double?,SqlDecimal>, 
		IConvertible<Double?,SqlMoney>, 

		IConvertible<Double?,SqlBoolean>, 

		IConvertible<Double?,object>

	{
		// Scalar Types.
		// 
		Double? IConvertible<Double?,Double>.     From(Double p)      { return p; }
		Double? IConvertible<Double?,String>.     From(String p)      { return p == null? null: (Double?)Convert.ToDouble(p); }

		Double? IConvertible<Double?,SByte>.      From(SByte p)       { return Convert.ToDouble(p); }
		Double? IConvertible<Double?,Int16>.      From(Int16 p)       { return Convert.ToDouble(p); }
		Double? IConvertible<Double?,Int32>.      From(Int32 p)       { return Convert.ToDouble(p); }
		Double? IConvertible<Double?,Int64>.      From(Int64 p)       { return Convert.ToDouble(p); }

		Double? IConvertible<Double?,Byte>.       From(Byte p)        { return Convert.ToDouble(p); }
		Double? IConvertible<Double?,UInt16>.     From(UInt16 p)      { return Convert.ToDouble(p); }
		Double? IConvertible<Double?,UInt32>.     From(UInt32 p)      { return Convert.ToDouble(p); }
		Double? IConvertible<Double?,UInt64>.     From(UInt64 p)      { return Convert.ToDouble(p); }

		Double? IConvertible<Double?,Single>.     From(Single p)      { return Convert.ToDouble(p); }

		Double? IConvertible<Double?,Boolean>.    From(Boolean p)     { return Convert.ToDouble(p); }
		Double? IConvertible<Double?,Decimal>.    From(Decimal p)     { return Convert.ToDouble(p); }

		// Nullable Types.
		// 
		Double? IConvertible<Double?,SByte?>.     From(SByte? p)      { return p.HasValue? (Double?)Convert.ToDouble(p.Value) : null; }
		Double? IConvertible<Double?,Int16?>.     From(Int16? p)      { return p.HasValue? (Double?)Convert.ToDouble(p.Value) : null; }
		Double? IConvertible<Double?,Int32?>.     From(Int32? p)      { return p.HasValue? (Double?)Convert.ToDouble(p.Value) : null; }
		Double? IConvertible<Double?,Int64?>.     From(Int64? p)      { return p.HasValue? (Double?)Convert.ToDouble(p.Value) : null; }

		Double? IConvertible<Double?,Byte?>.      From(Byte? p)       { return p.HasValue? (Double?)Convert.ToDouble(p.Value) : null; }
		Double? IConvertible<Double?,UInt16?>.    From(UInt16? p)     { return p.HasValue? (Double?)Convert.ToDouble(p.Value) : null; }
		Double? IConvertible<Double?,UInt32?>.    From(UInt32? p)     { return p.HasValue? (Double?)Convert.ToDouble(p.Value) : null; }
		Double? IConvertible<Double?,UInt64?>.    From(UInt64? p)     { return p.HasValue? (Double?)Convert.ToDouble(p.Value) : null; }

		Double? IConvertible<Double?,Single?>.    From(Single? p)     { return p.HasValue? (Double?)Convert.ToDouble(p.Value) : null; }

		Double? IConvertible<Double?,Boolean?>.   From(Boolean? p)    { return p.HasValue? (Double?)Convert.ToDouble(p.Value) : null; }
		Double? IConvertible<Double?,Decimal?>.   From(Decimal? p)    { return p.HasValue? (Double?)Convert.ToDouble(p.Value) : null; }

		// SqlTypes.
		// 
		Double? IConvertible<Double?,SqlDouble>.  From(SqlDouble p)   { return p.IsNull? null: (Double?)                 p.Value;  }
		Double? IConvertible<Double?,SqlString>.  From(SqlString p)   { return p.IsNull? null: (Double?)Convert.ToDouble(p.Value); }

		Double? IConvertible<Double?,SqlByte>.    From(SqlByte p)     { return p.IsNull? null: (Double?)Convert.ToDouble(p.Value); }
		Double? IConvertible<Double?,SqlInt16>.   From(SqlInt16 p)    { return p.IsNull? null: (Double?)Convert.ToDouble(p.Value); }
		Double? IConvertible<Double?,SqlInt32>.   From(SqlInt32 p)    { return p.IsNull? null: (Double?)Convert.ToDouble(p.Value); }
		Double? IConvertible<Double?,SqlInt64>.   From(SqlInt64 p)    { return p.IsNull? null: (Double?)Convert.ToDouble(p.Value); }

		Double? IConvertible<Double?,SqlSingle>.  From(SqlSingle p)   { return p.IsNull? null: (Double?)Convert.ToDouble(p.Value); }
		Double? IConvertible<Double?,SqlDecimal>. From(SqlDecimal p)  { return p.IsNull? null: (Double?)Convert.ToDouble(p.Value); }
		Double? IConvertible<Double?,SqlMoney>.   From(SqlMoney p)    { return p.IsNull? null: (Double?)Convert.ToDouble(p.Value); }

		Double? IConvertible<Double?,SqlBoolean>. From(SqlBoolean p)  { return p.IsNull? null: (Double?)Convert.ToDouble(p.Value); }

		Double? IConvertible<Double?,object>.     From(object p)      { return Convert.ToDouble(p); }
	}

	#endregion

	#region Boolean?

	partial class ConvertPartial<T,P>: IConvertible<Boolean?,P>
	{
		Boolean? IConvertible<Boolean?,P>.From(P p) { return Convert<Boolean?,object>.Instance.From(p); }
	}

	partial class ConvertExplicit<T,P>:
		// Scalar Types.
		// 
		IConvertible<Boolean?,Boolean>, 
		IConvertible<Boolean?,String>, 

		IConvertible<Boolean?,SByte>, 
		IConvertible<Boolean?,Int16>, 
		IConvertible<Boolean?,Int32>, 
		IConvertible<Boolean?,Int64>, 

		IConvertible<Boolean?,Byte>, 
		IConvertible<Boolean?,UInt16>, 
		IConvertible<Boolean?,UInt32>, 
		IConvertible<Boolean?,UInt64>, 

		IConvertible<Boolean?,Single>, 
		IConvertible<Boolean?,Double>, 

		IConvertible<Boolean?,Decimal>, 

		IConvertible<Boolean?,Char>, 

		// Nullable Types.
		// 
		IConvertible<Boolean?,SByte?>, 
		IConvertible<Boolean?,Int16?>, 
		IConvertible<Boolean?,Int32?>, 
		IConvertible<Boolean?,Int64?>, 

		IConvertible<Boolean?,Byte?>, 
		IConvertible<Boolean?,UInt16?>, 
		IConvertible<Boolean?,UInt32?>, 
		IConvertible<Boolean?,UInt64?>, 

		IConvertible<Boolean?,Single?>, 
		IConvertible<Boolean?,Double?>, 

		IConvertible<Boolean?,Decimal?>, 

		IConvertible<Boolean?,Char?>, 

		// SqlTypes.
		// 
		IConvertible<Boolean?,SqlBoolean>, 
		IConvertible<Boolean?,SqlString>, 

		IConvertible<Boolean?,SqlByte>, 
		IConvertible<Boolean?,SqlInt16>, 
		IConvertible<Boolean?,SqlInt32>, 
		IConvertible<Boolean?,SqlInt64>, 

		IConvertible<Boolean?,SqlSingle>, 
		IConvertible<Boolean?,SqlDouble>, 
		IConvertible<Boolean?,SqlDecimal>, 
		IConvertible<Boolean?,SqlMoney>, 


		IConvertible<Boolean?,object>

	{
		// Scalar Types.
		// 
		Boolean? IConvertible<Boolean?,Boolean>.    From(Boolean p)     { return p; }
		Boolean? IConvertible<Boolean?,String>.     From(String p)      { return Convert.ToBoolean(p); }

		Boolean? IConvertible<Boolean?,SByte>.      From(SByte p)       { return Convert.ToBoolean(p); }
		Boolean? IConvertible<Boolean?,Int16>.      From(Int16 p)       { return Convert.ToBoolean(p); }
		Boolean? IConvertible<Boolean?,Int32>.      From(Int32 p)       { return Convert.ToBoolean(p); }
		Boolean? IConvertible<Boolean?,Int64>.      From(Int64 p)       { return Convert.ToBoolean(p); }

		Boolean? IConvertible<Boolean?,Byte>.       From(Byte p)        { return Convert.ToBoolean(p); }
		Boolean? IConvertible<Boolean?,UInt16>.     From(UInt16 p)      { return Convert.ToBoolean(p); }
		Boolean? IConvertible<Boolean?,UInt32>.     From(UInt32 p)      { return Convert.ToBoolean(p); }
		Boolean? IConvertible<Boolean?,UInt64>.     From(UInt64 p)      { return Convert.ToBoolean(p); }

		Boolean? IConvertible<Boolean?,Single>.     From(Single p)      { return Convert.ToBoolean(p); }
		Boolean? IConvertible<Boolean?,Double>.     From(Double p)      { return Convert.ToBoolean(p); }

		Boolean? IConvertible<Boolean?,Decimal>.    From(Decimal p)     { return Convert.ToBoolean(p); }

		Boolean? IConvertible<Boolean?,Char>.       From(Char p)        { return Convert<Boolean,Char>.Instance.From(p); }

		// Nullable Types.
		// 
		Boolean? IConvertible<Boolean?,SByte?>.     From(SByte? p)      { return p.HasValue? (Boolean?)Convert.ToBoolean(p.Value): null; }
		Boolean? IConvertible<Boolean?,Int16?>.     From(Int16? p)      { return p.HasValue? (Boolean?)Convert.ToBoolean(p.Value): null; }
		Boolean? IConvertible<Boolean?,Int32?>.     From(Int32? p)      { return p.HasValue? (Boolean?)Convert.ToBoolean(p.Value): null; }
		Boolean? IConvertible<Boolean?,Int64?>.     From(Int64? p)      { return p.HasValue? (Boolean?)Convert.ToBoolean(p.Value): null; }

		Boolean? IConvertible<Boolean?,Byte?>.      From(Byte? p)       { return p.HasValue? (Boolean?)Convert.ToBoolean(p.Value): null; }
		Boolean? IConvertible<Boolean?,UInt16?>.    From(UInt16? p)     { return p.HasValue? (Boolean?)Convert.ToBoolean(p.Value): null; }
		Boolean? IConvertible<Boolean?,UInt32?>.    From(UInt32? p)     { return p.HasValue? (Boolean?)Convert.ToBoolean(p.Value): null; }
		Boolean? IConvertible<Boolean?,UInt64?>.    From(UInt64? p)     { return p.HasValue? (Boolean?)Convert.ToBoolean(p.Value): null; }

		Boolean? IConvertible<Boolean?,Single?>.    From(Single? p)     { return p.HasValue? (Boolean?)Convert.ToBoolean(p.Value): null; }
		Boolean? IConvertible<Boolean?,Double?>.    From(Double? p)     { return p.HasValue? (Boolean?)Convert.ToBoolean(p.Value): null; }

		Boolean? IConvertible<Boolean?,Decimal?>.   From(Decimal? p)    { return p.HasValue? (Boolean?)Convert.ToBoolean(p.Value): null; }

		Boolean? IConvertible<Boolean?,Char?>.      From(Char? p)       { return p.HasValue? (Boolean?)Convert<Boolean,Char>.Instance.From(p.Value): null; }

		// SqlTypes.
		// 
		Boolean? IConvertible<Boolean?,SqlBoolean>. From(SqlBoolean p)  { return p.IsNull? null: (Boolean?)                  p.Value;  }
		Boolean? IConvertible<Boolean?,SqlString>.  From(SqlString p)   { return p.IsNull? null: (Boolean?)Convert.ToBoolean(p.Value); }

		Boolean? IConvertible<Boolean?,SqlByte>.    From(SqlByte p)     { return p.IsNull? null: (Boolean?)Convert.ToBoolean(p.Value); }
		Boolean? IConvertible<Boolean?,SqlInt16>.   From(SqlInt16 p)    { return p.IsNull? null: (Boolean?)Convert.ToBoolean(p.Value); }
		Boolean? IConvertible<Boolean?,SqlInt32>.   From(SqlInt32 p)    { return p.IsNull? null: (Boolean?)Convert.ToBoolean(p.Value); }
		Boolean? IConvertible<Boolean?,SqlInt64>.   From(SqlInt64 p)    { return p.IsNull? null: (Boolean?)Convert.ToBoolean(p.Value); }

		Boolean? IConvertible<Boolean?,SqlSingle>.  From(SqlSingle p)   { return p.IsNull? null: (Boolean?)Convert.ToBoolean(p.Value); }
		Boolean? IConvertible<Boolean?,SqlDouble>.  From(SqlDouble p)   { return p.IsNull? null: (Boolean?)Convert.ToBoolean(p.Value); }
		Boolean? IConvertible<Boolean?,SqlDecimal>. From(SqlDecimal p)  { return p.IsNull? null: (Boolean?)Convert.ToBoolean(p.Value); }
		Boolean? IConvertible<Boolean?,SqlMoney>.   From(SqlMoney p)    { return p.IsNull? null: (Boolean?)Convert.ToBoolean(p.Value); }


		Boolean? IConvertible<Boolean?,object>.     From(object p)      { return Convert.ToBoolean(p); }
	}

	#endregion

	#region Decimal?

	partial class ConvertPartial<T,P>: IConvertible<Decimal?,P>
	{
		Decimal? IConvertible<Decimal?,P>.From(P p) { return Convert<Decimal?,object>.Instance.From(p); }
	}

	partial class ConvertExplicit<T,P>:
		// Scalar Types.
		// 
		IConvertible<Decimal?,Decimal>, 
		IConvertible<Decimal?,String>, 

		IConvertible<Decimal?,SByte>, 
		IConvertible<Decimal?,Int16>, 
		IConvertible<Decimal?,Int32>, 
		IConvertible<Decimal?,Int64>, 

		IConvertible<Decimal?,Byte>, 
		IConvertible<Decimal?,UInt16>, 
		IConvertible<Decimal?,UInt32>, 
		IConvertible<Decimal?,UInt64>, 

		IConvertible<Decimal?,Single>, 
		IConvertible<Decimal?,Double>, 

		IConvertible<Decimal?,Boolean>, 

		// Nullable Types.
		// 
		IConvertible<Decimal?,SByte?>, 
		IConvertible<Decimal?,Int16?>, 
		IConvertible<Decimal?,Int32?>, 
		IConvertible<Decimal?,Int64?>, 

		IConvertible<Decimal?,Byte?>, 
		IConvertible<Decimal?,UInt16?>, 
		IConvertible<Decimal?,UInt32?>, 
		IConvertible<Decimal?,UInt64?>, 

		IConvertible<Decimal?,Single?>, 
		IConvertible<Decimal?,Double?>, 

		IConvertible<Decimal?,Boolean?>, 

		// SqlTypes.
		// 
		IConvertible<Decimal?,SqlDecimal>, 
		IConvertible<Decimal?,SqlMoney>, 
		IConvertible<Decimal?,SqlString>, 

		IConvertible<Decimal?,SqlByte>, 
		IConvertible<Decimal?,SqlInt16>, 
		IConvertible<Decimal?,SqlInt32>, 
		IConvertible<Decimal?,SqlInt64>, 

		IConvertible<Decimal?,SqlSingle>, 
		IConvertible<Decimal?,SqlDouble>, 

		IConvertible<Decimal?,SqlBoolean>, 

		IConvertible<Decimal?,object>

	{
		// Scalar Types.
		// 
		Decimal? IConvertible<Decimal?,Decimal>.    From(Decimal p)     { return p; }
		Decimal? IConvertible<Decimal?,String>.     From(String p)      { return p == null? null: (Decimal?)Convert.ToDecimal(p); }

		Decimal? IConvertible<Decimal?,SByte>.      From(SByte p)       { return Convert.ToDecimal(p); }
		Decimal? IConvertible<Decimal?,Int16>.      From(Int16 p)       { return Convert.ToDecimal(p); }
		Decimal? IConvertible<Decimal?,Int32>.      From(Int32 p)       { return Convert.ToDecimal(p); }
		Decimal? IConvertible<Decimal?,Int64>.      From(Int64 p)       { return Convert.ToDecimal(p); }

		Decimal? IConvertible<Decimal?,Byte>.       From(Byte p)        { return Convert.ToDecimal(p); }
		Decimal? IConvertible<Decimal?,UInt16>.     From(UInt16 p)      { return Convert.ToDecimal(p); }
		Decimal? IConvertible<Decimal?,UInt32>.     From(UInt32 p)      { return Convert.ToDecimal(p); }
		Decimal? IConvertible<Decimal?,UInt64>.     From(UInt64 p)      { return Convert.ToDecimal(p); }

		Decimal? IConvertible<Decimal?,Single>.     From(Single p)      { return Convert.ToDecimal(p); }
		Decimal? IConvertible<Decimal?,Double>.     From(Double p)      { return Convert.ToDecimal(p); }

		Decimal? IConvertible<Decimal?,Boolean>.    From(Boolean p)     { return Convert.ToDecimal(p); }

		// Nullable Types.
		// 
		Decimal? IConvertible<Decimal?,SByte?>.     From(SByte? p)      { return p.HasValue? (Decimal?)Convert.ToDecimal(p.Value) : null; }
		Decimal? IConvertible<Decimal?,Int16?>.     From(Int16? p)      { return p.HasValue? (Decimal?)Convert.ToDecimal(p.Value) : null; }
		Decimal? IConvertible<Decimal?,Int32?>.     From(Int32? p)      { return p.HasValue? (Decimal?)Convert.ToDecimal(p.Value) : null; }
		Decimal? IConvertible<Decimal?,Int64?>.     From(Int64? p)      { return p.HasValue? (Decimal?)Convert.ToDecimal(p.Value) : null; }

		Decimal? IConvertible<Decimal?,Byte?>.      From(Byte? p)       { return p.HasValue? (Decimal?)Convert.ToDecimal(p.Value) : null; }
		Decimal? IConvertible<Decimal?,UInt16?>.    From(UInt16? p)     { return p.HasValue? (Decimal?)Convert.ToDecimal(p.Value) : null; }
		Decimal? IConvertible<Decimal?,UInt32?>.    From(UInt32? p)     { return p.HasValue? (Decimal?)Convert.ToDecimal(p.Value) : null; }
		Decimal? IConvertible<Decimal?,UInt64?>.    From(UInt64? p)     { return p.HasValue? (Decimal?)Convert.ToDecimal(p.Value) : null; }

		Decimal? IConvertible<Decimal?,Single?>.    From(Single? p)     { return p.HasValue? (Decimal?)Convert.ToDecimal(p.Value) : null; }
		Decimal? IConvertible<Decimal?,Double?>.    From(Double? p)     { return p.HasValue? (Decimal?)Convert.ToDecimal(p.Value) : null; }

		Decimal? IConvertible<Decimal?,Boolean?>.   From(Boolean? p)    { return p.HasValue? (Decimal?)Convert.ToDecimal(p.Value) : null; }

		// SqlTypes.
		// 
		Decimal? IConvertible<Decimal?,SqlDecimal>. From(SqlDecimal p)  { return p.IsNull? null: (Decimal?)                  p.Value;  }
		Decimal? IConvertible<Decimal?,SqlMoney>.   From(SqlMoney p)    { return p.IsNull? null: (Decimal?)                  p.Value;  }
		Decimal? IConvertible<Decimal?,SqlString>.  From(SqlString p)   { return p.IsNull? null: (Decimal?)Convert.ToDecimal(p.Value); }

		Decimal? IConvertible<Decimal?,SqlByte>.    From(SqlByte p)     { return p.IsNull? null: (Decimal?)Convert.ToDecimal(p.Value); }
		Decimal? IConvertible<Decimal?,SqlInt16>.   From(SqlInt16 p)    { return p.IsNull? null: (Decimal?)Convert.ToDecimal(p.Value); }
		Decimal? IConvertible<Decimal?,SqlInt32>.   From(SqlInt32 p)    { return p.IsNull? null: (Decimal?)Convert.ToDecimal(p.Value); }
		Decimal? IConvertible<Decimal?,SqlInt64>.   From(SqlInt64 p)    { return p.IsNull? null: (Decimal?)Convert.ToDecimal(p.Value); }

		Decimal? IConvertible<Decimal?,SqlSingle>.  From(SqlSingle p)   { return p.IsNull? null: (Decimal?)Convert.ToDecimal(p.Value); }
		Decimal? IConvertible<Decimal?,SqlDouble>.  From(SqlDouble p)   { return p.IsNull? null: (Decimal?)Convert.ToDecimal(p.Value); }

		Decimal? IConvertible<Decimal?,SqlBoolean>. From(SqlBoolean p)  { return p.IsNull? null: (Decimal?)Convert.ToDecimal(p.Value); }

		Decimal? IConvertible<Decimal?,object>.     From(object p)      { return Convert.ToDecimal(p); }
	}

	#endregion

	#region DateTime?

	partial class ConvertPartial<T,P>: IConvertible<DateTime?,P>
	{
		DateTime? IConvertible<DateTime?,P>.From(P p) { return Convert<DateTime?,object>.Instance.From(p); }
	}

	partial class ConvertExplicit<T,P>:
		// Scalar Types.
		// 
		IConvertible<DateTime?,DateTime>, 
		IConvertible<DateTime?,String>, 

		IConvertible<DateTime?,SByte>, 
		IConvertible<DateTime?,Int16>, 
		IConvertible<DateTime?,Int32>, 
		IConvertible<DateTime?,Int64>, 

		IConvertible<DateTime?,Byte>, 
		IConvertible<DateTime?,UInt16>, 
		IConvertible<DateTime?,UInt32>, 
		IConvertible<DateTime?,UInt64>, 

		IConvertible<DateTime?,Single>, 
		IConvertible<DateTime?,Double>, 

		IConvertible<DateTime?,Boolean>, 
		IConvertible<DateTime?,Decimal>, 

		// Nullable Types.
		// 
		IConvertible<DateTime?,SByte?>, 
		IConvertible<DateTime?,Int16?>, 
		IConvertible<DateTime?,Int32?>, 
		IConvertible<DateTime?,Int64?>, 

		IConvertible<DateTime?,Byte?>, 
		IConvertible<DateTime?,UInt16?>, 
		IConvertible<DateTime?,UInt32?>, 
		IConvertible<DateTime?,UInt64?>, 

		IConvertible<DateTime?,Single?>, 
		IConvertible<DateTime?,Double?>, 

		IConvertible<DateTime?,Boolean?>, 
		IConvertible<DateTime?,Decimal?>, 

		// SqlTypes.
		// 
		IConvertible<DateTime?,SqlString>, 

		IConvertible<DateTime?,SqlByte>, 
		IConvertible<DateTime?,SqlInt16>, 
		IConvertible<DateTime?,SqlInt32>, 
		IConvertible<DateTime?,SqlInt64>, 

		IConvertible<DateTime?,SqlSingle>, 
		IConvertible<DateTime?,SqlDouble>, 
		IConvertible<DateTime?,SqlDecimal>, 
		IConvertible<DateTime?,SqlMoney>, 

		IConvertible<DateTime?,SqlBoolean>, 
		IConvertible<DateTime?,SqlDateTime>, 

		IConvertible<DateTime?,object>

	{
		// Scalar Types.
		// 
		DateTime? IConvertible<DateTime?,DateTime>.   From(DateTime p)    { return p; }
		DateTime? IConvertible<DateTime?,String>.     From(String p)      { return p == null? null: (DateTime?)Convert.ToDateTime(p); }

		DateTime? IConvertible<DateTime?,SByte>.      From(SByte p)       { return Convert.ToDateTime(p); }
		DateTime? IConvertible<DateTime?,Int16>.      From(Int16 p)       { return Convert.ToDateTime(p); }
		DateTime? IConvertible<DateTime?,Int32>.      From(Int32 p)       { return Convert.ToDateTime(p); }
		DateTime? IConvertible<DateTime?,Int64>.      From(Int64 p)       { return Convert.ToDateTime(p); }

		DateTime? IConvertible<DateTime?,Byte>.       From(Byte p)        { return Convert.ToDateTime(p); }
		DateTime? IConvertible<DateTime?,UInt16>.     From(UInt16 p)      { return Convert.ToDateTime(p); }
		DateTime? IConvertible<DateTime?,UInt32>.     From(UInt32 p)      { return Convert.ToDateTime(p); }
		DateTime? IConvertible<DateTime?,UInt64>.     From(UInt64 p)      { return Convert.ToDateTime(p); }

		DateTime? IConvertible<DateTime?,Single>.     From(Single p)      { return Convert.ToDateTime(p); }
		DateTime? IConvertible<DateTime?,Double>.     From(Double p)      { return Convert.ToDateTime(p); }

		DateTime? IConvertible<DateTime?,Boolean>.    From(Boolean p)     { return Convert.ToDateTime(p); }
		DateTime? IConvertible<DateTime?,Decimal>.    From(Decimal p)     { return Convert.ToDateTime(p); }

		// Nullable Types.
		// 
		DateTime? IConvertible<DateTime?,SByte?>.     From(SByte? p)      { return p.HasValue? (DateTime?)Convert.ToDateTime(p.Value) : null; }
		DateTime? IConvertible<DateTime?,Int16?>.     From(Int16? p)      { return p.HasValue? (DateTime?)Convert.ToDateTime(p.Value) : null; }
		DateTime? IConvertible<DateTime?,Int32?>.     From(Int32? p)      { return p.HasValue? (DateTime?)Convert.ToDateTime(p.Value) : null; }
		DateTime? IConvertible<DateTime?,Int64?>.     From(Int64? p)      { return p.HasValue? (DateTime?)Convert.ToDateTime(p.Value) : null; }

		DateTime? IConvertible<DateTime?,Byte?>.      From(Byte? p)       { return p.HasValue? (DateTime?)Convert.ToDateTime(p.Value) : null; }
		DateTime? IConvertible<DateTime?,UInt16?>.    From(UInt16? p)     { return p.HasValue? (DateTime?)Convert.ToDateTime(p.Value) : null; }
		DateTime? IConvertible<DateTime?,UInt32?>.    From(UInt32? p)     { return p.HasValue? (DateTime?)Convert.ToDateTime(p.Value) : null; }
		DateTime? IConvertible<DateTime?,UInt64?>.    From(UInt64? p)     { return p.HasValue? (DateTime?)Convert.ToDateTime(p.Value) : null; }

		DateTime? IConvertible<DateTime?,Single?>.    From(Single? p)     { return p.HasValue? (DateTime?)Convert.ToDateTime(p.Value) : null; }
		DateTime? IConvertible<DateTime?,Double?>.    From(Double? p)     { return p.HasValue? (DateTime?)Convert.ToDateTime(p.Value) : null; }

		DateTime? IConvertible<DateTime?,Boolean?>.   From(Boolean? p)    { return p.HasValue? (DateTime?)Convert.ToDateTime(p.Value) : null; }
		DateTime? IConvertible<DateTime?,Decimal?>.   From(Decimal? p)    { return p.HasValue? (DateTime?)Convert.ToDateTime(p.Value) : null; }

		// SqlTypes.
		// 
		DateTime? IConvertible<DateTime?,SqlString>.  From(SqlString p)   { return p.IsNull? null: (DateTime?)Convert.ToDateTime(p.Value); }

		DateTime? IConvertible<DateTime?,SqlByte>.    From(SqlByte p)     { return p.IsNull? null: (DateTime?)Convert.ToDateTime(p.Value); }
		DateTime? IConvertible<DateTime?,SqlInt16>.   From(SqlInt16 p)    { return p.IsNull? null: (DateTime?)Convert.ToDateTime(p.Value); }
		DateTime? IConvertible<DateTime?,SqlInt32>.   From(SqlInt32 p)    { return p.IsNull? null: (DateTime?)Convert.ToDateTime(p.Value); }
		DateTime? IConvertible<DateTime?,SqlInt64>.   From(SqlInt64 p)    { return p.IsNull? null: (DateTime?)Convert.ToDateTime(p.Value); }

		DateTime? IConvertible<DateTime?,SqlSingle>.  From(SqlSingle p)   { return p.IsNull? null: (DateTime?)Convert.ToDateTime(p.Value); }
		DateTime? IConvertible<DateTime?,SqlDouble>.  From(SqlDouble p)   { return p.IsNull? null: (DateTime?)Convert.ToDateTime(p.Value); }
		DateTime? IConvertible<DateTime?,SqlDecimal>. From(SqlDecimal p)  { return p.IsNull? null: (DateTime?)Convert.ToDateTime(p.Value); }
		DateTime? IConvertible<DateTime?,SqlMoney>.   From(SqlMoney p)    { return p.IsNull? null: (DateTime?)Convert.ToDateTime(p.Value); }

		DateTime? IConvertible<DateTime?,SqlBoolean>. From(SqlBoolean p)  { return p.IsNull? null: (DateTime?)Convert.ToDateTime(p.Value); }
		DateTime? IConvertible<DateTime?,SqlDateTime>.From(SqlDateTime p) { return p.IsNull? null: (DateTime?)                   p.Value;  }

		DateTime? IConvertible<DateTime?,object>.     From(object p)      { return Convert.ToDateTime(p); }
	}

	#endregion

	#region TimeSpan?

	partial class ConvertPartial<T,P>: IConvertible<TimeSpan?,P>
	{
		TimeSpan? IConvertible<TimeSpan?,P>.From(P p) { return Convert<TimeSpan?,object>.Instance.From(p); }
	}

	partial class ConvertExplicit<T,P>:
		// Scalar Types.
		// 
		IConvertible<TimeSpan?,TimeSpan>, 
		IConvertible<TimeSpan?,String>, 
		IConvertible<TimeSpan?,DateTime>, 

		// Nullable Types.
		// 
		IConvertible<TimeSpan?,DateTime?>, 

		// SqlTypes.
		// 
		IConvertible<TimeSpan?,SqlString>, 
		IConvertible<TimeSpan?,SqlDateTime>, 

		IConvertible<TimeSpan?,object>

	{
		// Scalar Types.
		// 
		TimeSpan? IConvertible<TimeSpan?,TimeSpan>.   From(TimeSpan p)    { return p; }
		TimeSpan? IConvertible<TimeSpan?,String>.     From(String p)      { return p == null? null: (TimeSpan?)TimeSpan.Parse(p); }
		TimeSpan? IConvertible<TimeSpan?,DateTime>.   From(DateTime p)    { return p - DateTime.MinValue; }

		// Nullable Types.
		// 
		TimeSpan? IConvertible<TimeSpan?,DateTime?>.  From(DateTime? p)   { return p.HasValue? (TimeSpan?)(p.Value - DateTime.MinValue) : null; }

		// SqlTypes.
		// 
		TimeSpan? IConvertible<TimeSpan?,SqlString>.  From(SqlString p)   { return p.IsNull? null: (TimeSpan?)TimeSpan.Parse(p.Value);       }
		TimeSpan? IConvertible<TimeSpan?,SqlDateTime>.From(SqlDateTime p) { return p.IsNull? null: (TimeSpan?)(p.Value - DateTime.MinValue); }

		TimeSpan? IConvertible<TimeSpan?,object>.     From(object p)     
		{
			if (p == null) return null;

			// Scalar Types.
			//
			if (p is TimeSpan)    return Convert<TimeSpan?,TimeSpan>   .Instance.From((TimeSpan)p);
			if (p is String)      return Convert<TimeSpan?,String>     .Instance.From((String)p);
			if (p is DateTime)    return Convert<TimeSpan?,DateTime>   .Instance.From((DateTime)p);

			// Nullable Types.
			//
			if (p is DateTime?)   return Convert<TimeSpan?,DateTime?>  .Instance.From((DateTime?)p);

			// SqlTypes.
			//
			if (p is SqlString)   return Convert<TimeSpan?,SqlString>  .Instance.From((SqlString)p);
			if (p is SqlDateTime) return Convert<TimeSpan?,SqlDateTime>.Instance.From((SqlDateTime)p);

			throw new InvalidCastException(string.Format(
				"Invalid cast from {0} to {1}", p.GetType().FullName, typeof(T).FullName));
		}
	}

	#endregion

	#region Guid?

	partial class ConvertPartial<T,P>: IConvertible<Guid?,P>
	{
		Guid? IConvertible<Guid?,P>.From(P p) { return Convert<Guid?,object>.Instance.From(p); }
	}

	partial class ConvertExplicit<T,P>:
		// Scalar Types.
		// 
		IConvertible<Guid?,Guid>, 
		IConvertible<Guid?,String>, 

		// Nullable Types.
		// 

		// SqlTypes.
		// 
		IConvertible<Guid?,SqlGuid>, 
		IConvertible<Guid?,SqlString>, 
		IConvertible<Guid?,SqlBinary>, 

		// Other Types.
		// 
		IConvertible<Guid?,Type>, 
		IConvertible<Guid?,Byte[]>, 

		IConvertible<Guid?,object>

	{
		// Scalar Types.
		// 
		Guid? IConvertible<Guid?,Guid>.       From(Guid p)        { return p; }
		Guid? IConvertible<Guid?,String>.     From(String p)      { return p == null? null: (Guid?)new Guid(p); }

		// Nullable Types.
		// 

		// SqlTypes.
		// 
		Guid? IConvertible<Guid?,SqlGuid>.    From(SqlGuid p)     { return p.IsNull? null: (Guid?)p.Value;             }
		Guid? IConvertible<Guid?,SqlString>.  From(SqlString p)   { return p.IsNull? null: (Guid?)new Guid(p.Value);   }
		Guid? IConvertible<Guid?,SqlBinary>.  From(SqlBinary p)   { return p.IsNull? null: (Guid?)p.ToSqlGuid().Value; }

		// Other Types.
		// 
		Guid? IConvertible<Guid?,Type>.       From(Type p)        { return p == null? null: (Guid?)p.GUID; }
		Guid? IConvertible<Guid?,Byte[]>.     From(Byte[] p)      { return p == null? null: (Guid?)new Guid(p); }

		Guid? IConvertible<Guid?,object>.     From(object p)     
		{
			if (p == null) return null;

			// Scalar Types.
			//
			if (p is Guid)        return Convert<Guid?,Guid>       .Instance.From((Guid)p);
			if (p is String)      return Convert<Guid?,String>     .Instance.From((String)p);

			// Nullable Types.
			//

			// SqlTypes.
			//
			if (p is SqlGuid)     return Convert<Guid?,SqlGuid>    .Instance.From((SqlGuid)p);
			if (p is SqlString)   return Convert<Guid?,SqlString>  .Instance.From((SqlString)p);
			if (p is SqlBinary)   return Convert<Guid?,SqlBinary>  .Instance.From((SqlBinary)p);

			// Other Types.
			//
			if (p is Type)        return Convert<Guid?,Type>       .Instance.From((Type)p);
			if (p is Byte[])      return Convert<Guid?,Byte[]>     .Instance.From((Byte[])p);

			throw new InvalidCastException(string.Format(
				"Invalid cast from {0} to {1}", p.GetType().FullName, typeof(T).FullName));
		}
	}

	#endregion

	#endregion


}
