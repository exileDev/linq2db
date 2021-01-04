﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------

#pragma warning disable 1591
#nullable enable

using System;
using System.Collections.Generic;
using System.Data;

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Configuration;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace AccessODBCDataContext
{
	public partial class TestDataDB : LinqToDB.Data.DataConnection
	{
		public ITable<AllType>             AllTypes             { get { return this.GetTable<AllType>(); } }
		public ITable<Child>               Children             { get { return this.GetTable<Child>(); } }
		public ITable<DataTypeTest>        DataTypeTests        { get { return this.GetTable<DataTypeTest>(); } }
		public ITable<Doctor>              Doctors              { get { return this.GetTable<Doctor>(); } }
		public ITable<Dual>                Duals                { get { return this.GetTable<Dual>(); } }
		public ITable<GrandChild>          GrandChildren        { get { return this.GetTable<GrandChild>(); } }
		public ITable<InheritanceChild>    InheritanceChildren  { get { return this.GetTable<InheritanceChild>(); } }
		public ITable<InheritanceParent>   InheritanceParents   { get { return this.GetTable<InheritanceParent>(); } }
		public ITable<LinqDataType>        LinqDataTypes        { get { return this.GetTable<LinqDataType>(); } }
		public ITable<LinqDataTypesQuery>  LinqDataTypesQueries { get { return this.GetTable<LinqDataTypesQuery>(); } }
		public ITable<LinqDataTypesQuery1> LinqDataTypesQuery1  { get { return this.GetTable<LinqDataTypesQuery1>(); } }
		public ITable<LinqDataTypesQuery2> LinqDataTypesQuery2  { get { return this.GetTable<LinqDataTypesQuery2>(); } }
		public ITable<Parent>              Parents              { get { return this.GetTable<Parent>(); } }
		public ITable<Patient>             Patients             { get { return this.GetTable<Patient>(); } }
		public ITable<PatientSelectAll>    PatientSelectAll     { get { return this.GetTable<PatientSelectAll>(); } }
		public ITable<Person>              People               { get { return this.GetTable<Person>(); } }
		public ITable<PersonSelectAll>     PersonSelectAll      { get { return this.GetTable<PersonSelectAll>(); } }
		public ITable<ScalarDataReader>    ScalarDataReaders    { get { return this.GetTable<ScalarDataReader>(); } }
		public ITable<TestIdentity>        TestIdentities       { get { return this.GetTable<TestIdentity>(); } }
		public ITable<TestMerge1>          TestMerge1           { get { return this.GetTable<TestMerge1>(); } }
		public ITable<TestMerge2>          TestMerge2           { get { return this.GetTable<TestMerge2>(); } }

		public TestDataDB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestDataDB(LinqToDbConnectionOptions options)
			: base(options)
		{
			InitDataContext();
			InitMappingSchema();
		}

		partial void InitDataContext  ();
		partial void InitMappingSchema();
	}

	[Table("AllTypes")]
	public partial class AllType
	{
		[Column(                            DbType="COUNTER",        DataType=LinqToDB.DataType.Int32),                            Identity   ] public int       ID                       { get; set; } // COUNTER
		[Column("bitDataType",              DbType="BIT",            DataType=LinqToDB.DataType.Boolean),                          NotNull    ] public bool      BitDataType              { get; set; } // BIT
		[Column("smallintDataType",         DbType="SMALLINT",       DataType=LinqToDB.DataType.Int16),                               Nullable] public short?    SmallintDataType         { get; set; } // SMALLINT
		[Column("decimalDataType",          DbType="DECIMAL(18, 0)", DataType=LinqToDB.DataType.Decimal,   Precision=18, Scale=0),    Nullable] public decimal?  DecimalDataType          { get; set; } // DECIMAL(18, 0)
		[Column("intDataType",              DbType="INTEGER",        DataType=LinqToDB.DataType.Int32),                               Nullable] public int?      IntDataType              { get; set; } // INTEGER
		[Column("tinyintDataType",          DbType="BYTE",           DataType=LinqToDB.DataType.Byte),                                Nullable] public byte?     TinyintDataType          { get; set; } // BYTE
		[Column("moneyDataType",            DbType="CURRENCY",       DataType=LinqToDB.DataType.Money),                               Nullable] public decimal?  MoneyDataType            { get; set; } // CURRENCY
		[Column("floatDataType",            DbType="DOUBLE",         DataType=LinqToDB.DataType.Double),                              Nullable] public double?   FloatDataType            { get; set; } // DOUBLE
		[Column("realDataType",             DbType="REAL",           DataType=LinqToDB.DataType.Single),                              Nullable] public float?    RealDataType             { get; set; } // REAL
		[Column("datetimeDataType",         DbType="DATETIME",       DataType=LinqToDB.DataType.DateTime),                            Nullable] public DateTime? DatetimeDataType         { get; set; } // DATETIME
		[Column("charDataType",             DbType="CHAR(1)",        DataType=LinqToDB.DataType.Char,      Length=1),                 Nullable] public char?     CharDataType             { get; set; } // CHAR(1)
		[Column("char20DataType",           DbType="CHAR(20)",       DataType=LinqToDB.DataType.Char,      Length=20),                Nullable] public string?   Char20DataType           { get; set; } // CHAR(20)
		[Column("varcharDataType",          DbType="VARCHAR(20)",    DataType=LinqToDB.DataType.VarChar,   Length=20),                Nullable] public string?   VarcharDataType          { get; set; } // VARCHAR(20)
		[Column("textDataType",             DbType="LONGCHAR",       DataType=LinqToDB.DataType.NText),                               Nullable] public string?   TextDataType             { get; set; } // LONGCHAR
		[Column("ncharDataType",            DbType="CHAR(20)",       DataType=LinqToDB.DataType.Char,      Length=20),                Nullable] public string?   NcharDataType            { get; set; } // CHAR(20)
		[Column("nvarcharDataType",         DbType="VARCHAR(20)",    DataType=LinqToDB.DataType.VarChar,   Length=20),                Nullable] public string?   NvarcharDataType         { get; set; } // VARCHAR(20)
		[Column("ntextDataType",            DbType="LONGCHAR",       DataType=LinqToDB.DataType.NText),                               Nullable] public string?   NtextDataType            { get; set; } // LONGCHAR
		[Column("binaryDataType",           DbType="BINARY(10)",     DataType=LinqToDB.DataType.Binary,    Length=10),                Nullable] public byte[]?   BinaryDataType           { get; set; } // BINARY(10)
		[Column("varbinaryDataType",        DbType="VARBINARY(510)", DataType=LinqToDB.DataType.VarBinary, Length=510),               Nullable] public byte[]?   VarbinaryDataType        { get; set; } // VARBINARY(510)
		[Column("imageDataType",            DbType="LONGBINARY",     DataType=LinqToDB.DataType.Image),                               Nullable] public byte[]?   ImageDataType            { get; set; } // LONGBINARY
		[Column("oleObjectDataType",        DbType="LONGBINARY",     DataType=LinqToDB.DataType.Image),                               Nullable] public byte[]?   OleObjectDataType        { get; set; } // LONGBINARY
		[Column("uniqueidentifierDataType", DbType="GUID",           DataType=LinqToDB.DataType.Guid),                                Nullable] public Guid?     UniqueidentifierDataType { get; set; } // GUID
	}

	[Table("Child")]
	public partial class Child
	{
		[Column(DbType="INTEGER", DataType=LinqToDB.DataType.Int32), Nullable] public int? ParentID { get; set; } // INTEGER
		[Column(DbType="INTEGER", DataType=LinqToDB.DataType.Int32), Nullable] public int? ChildID  { get; set; } // INTEGER
	}

	[Table("DataTypeTest")]
	public partial class DataTypeTest
	{
		[Column(             DbType="COUNTER",     DataType=LinqToDB.DataType.Int32),               Identity] public int       DataTypeID { get; set; } // COUNTER
		[Column("Binary_",   DbType="LONGBINARY",  DataType=LinqToDB.DataType.Image),               Nullable] public byte[]?   Binary     { get; set; } // LONGBINARY
		[Column("Boolean_",  DbType="INTEGER",     DataType=LinqToDB.DataType.Int32),               Nullable] public int?      Boolean    { get; set; } // INTEGER
		[Column("Byte_",     DbType="BYTE",        DataType=LinqToDB.DataType.Byte),                Nullable] public byte?     Byte       { get; set; } // BYTE
		[Column("Bytes_",    DbType="LONGBINARY",  DataType=LinqToDB.DataType.Image),               Nullable] public byte[]?   Bytes      { get; set; } // LONGBINARY
		[Column("Char_",     DbType="VARCHAR(1)",  DataType=LinqToDB.DataType.VarChar,  Length=1),  Nullable] public char?     Char       { get; set; } // VARCHAR(1)
		[Column("DateTime_", DbType="DATETIME",    DataType=LinqToDB.DataType.DateTime),            Nullable] public DateTime? DateTime   { get; set; } // DATETIME
		[Column("Decimal_",  DbType="CURRENCY",    DataType=LinqToDB.DataType.Money),               Nullable] public decimal?  Decimal    { get; set; } // CURRENCY
		[Column("Double_",   DbType="DOUBLE",      DataType=LinqToDB.DataType.Double),              Nullable] public double?   Double     { get; set; } // DOUBLE
		[Column("Guid_",     DbType="GUID",        DataType=LinqToDB.DataType.Guid),                Nullable] public Guid?     Guid       { get; set; } // GUID
		[Column("Int16_",    DbType="SMALLINT",    DataType=LinqToDB.DataType.Int16),               Nullable] public short?    Int16      { get; set; } // SMALLINT
		[Column("Int32_",    DbType="INTEGER",     DataType=LinqToDB.DataType.Int32),               Nullable] public int?      Int32      { get; set; } // INTEGER
		[Column("Int64_",    DbType="INTEGER",     DataType=LinqToDB.DataType.Int32),               Nullable] public int?      Int64      { get; set; } // INTEGER
		[Column("Money_",    DbType="CURRENCY",    DataType=LinqToDB.DataType.Money),               Nullable] public decimal?  Money      { get; set; } // CURRENCY
		[Column("SByte_",    DbType="BYTE",        DataType=LinqToDB.DataType.Byte),                Nullable] public byte?     SByte      { get; set; } // BYTE
		[Column("Single_",   DbType="REAL",        DataType=LinqToDB.DataType.Single),              Nullable] public float?    Single     { get; set; } // REAL
		[Column("Stream_",   DbType="LONGBINARY",  DataType=LinqToDB.DataType.Image),               Nullable] public byte[]?   Stream     { get; set; } // LONGBINARY
		[Column("String_",   DbType="VARCHAR(50)", DataType=LinqToDB.DataType.VarChar,  Length=50), Nullable] public string?   String     { get; set; } // VARCHAR(50)
		[Column("UInt16_",   DbType="SMALLINT",    DataType=LinqToDB.DataType.Int16),               Nullable] public short?    UInt16     { get; set; } // SMALLINT
		[Column("UInt32_",   DbType="INTEGER",     DataType=LinqToDB.DataType.Int32),               Nullable] public int?      UInt32     { get; set; } // INTEGER
		[Column("UInt64_",   DbType="INTEGER",     DataType=LinqToDB.DataType.Int32),               Nullable] public int?      UInt64     { get; set; } // INTEGER
		[Column("Xml_",      DbType="LONGCHAR",    DataType=LinqToDB.DataType.NText),               Nullable] public string?   Xml        { get; set; } // LONGCHAR
	}

	[Table("Doctor")]
	public partial class Doctor
	{
		[Column(DbType="INTEGER",     DataType=LinqToDB.DataType.Int32),              Nullable] public int?    PersonID { get; set; } // INTEGER
		[Column(DbType="VARCHAR(50)", DataType=LinqToDB.DataType.VarChar, Length=50), Nullable] public string? Taxonomy { get; set; } // VARCHAR(50)
	}

	[Table("Dual")]
	public partial class Dual
	{
		[Column(DbType="VARCHAR(10)", DataType=LinqToDB.DataType.VarChar, Length=10), Nullable] public string? Dummy { get; set; } // VARCHAR(10)
	}

	[Table("GrandChild")]
	public partial class GrandChild
	{
		[Column(DbType="INTEGER", DataType=LinqToDB.DataType.Int32), Nullable] public int? ParentID     { get; set; } // INTEGER
		[Column(DbType="INTEGER", DataType=LinqToDB.DataType.Int32), Nullable] public int? ChildID      { get; set; } // INTEGER
		[Column(DbType="INTEGER", DataType=LinqToDB.DataType.Int32), Nullable] public int? GrandChildID { get; set; } // INTEGER
	}

	[Table("InheritanceChild")]
	public partial class InheritanceChild
	{
		[Column(DbType="INTEGER",     DataType=LinqToDB.DataType.Int32),              Nullable] public int?    InheritanceChildId  { get; set; } // INTEGER
		[Column(DbType="INTEGER",     DataType=LinqToDB.DataType.Int32),              Nullable] public int?    InheritanceParentId { get; set; } // INTEGER
		[Column(DbType="INTEGER",     DataType=LinqToDB.DataType.Int32),              Nullable] public int?    TypeDiscriminator   { get; set; } // INTEGER
		[Column(DbType="VARCHAR(50)", DataType=LinqToDB.DataType.VarChar, Length=50), Nullable] public string? Name                { get; set; } // VARCHAR(50)
	}

	[Table("InheritanceParent")]
	public partial class InheritanceParent
	{
		[Column(DbType="INTEGER",     DataType=LinqToDB.DataType.Int32),              Nullable] public int?    InheritanceParentId { get; set; } // INTEGER
		[Column(DbType="INTEGER",     DataType=LinqToDB.DataType.Int32),              Nullable] public int?    TypeDiscriminator   { get; set; } // INTEGER
		[Column(DbType="VARCHAR(50)", DataType=LinqToDB.DataType.VarChar, Length=50), Nullable] public string? Name                { get; set; } // VARCHAR(50)
	}

	[Table("LinqDataTypes")]
	public partial class LinqDataType
	{
		[Column(DbType="INTEGER",        DataType=LinqToDB.DataType.Int32),                              Nullable] public int?      ID             { get; set; } // INTEGER
		[Column(DbType="DECIMAL(10, 4)", DataType=LinqToDB.DataType.Decimal,  Precision=10, Scale=4),    Nullable] public decimal?  MoneyValue     { get; set; } // DECIMAL(10, 4)
		[Column(DbType="DATETIME",       DataType=LinqToDB.DataType.DateTime),                           Nullable] public DateTime? DateTimeValue  { get; set; } // DATETIME
		[Column(DbType="DATETIME",       DataType=LinqToDB.DataType.DateTime),                           Nullable] public DateTime? DateTimeValue2 { get; set; } // DATETIME
		[Column(DbType="BIT",            DataType=LinqToDB.DataType.Boolean),                         NotNull    ] public bool      BoolValue      { get; set; } // BIT
		[Column(DbType="GUID",           DataType=LinqToDB.DataType.Guid),                               Nullable] public Guid?     GuidValue      { get; set; } // GUID
		[Column(DbType="LONGBINARY",     DataType=LinqToDB.DataType.Image),                              Nullable] public byte[]?   BinaryValue    { get; set; } // LONGBINARY
		[Column(DbType="SMALLINT",       DataType=LinqToDB.DataType.Int16),                              Nullable] public short?    SmallIntValue  { get; set; } // SMALLINT
		[Column(DbType="INTEGER",        DataType=LinqToDB.DataType.Int32),                              Nullable] public int?      IntValue       { get; set; } // INTEGER
		[Column(DbType="INTEGER",        DataType=LinqToDB.DataType.Int32),                              Nullable] public int?      BigIntValue    { get; set; } // INTEGER
		[Column(DbType="VARCHAR(50)",    DataType=LinqToDB.DataType.VarChar,  Length=50),                Nullable] public string?   StringValue    { get; set; } // VARCHAR(50)
	}

	[Table("LinqDataTypes Query", IsView=true)]
	public partial class LinqDataTypesQuery
	{
		[Column(DbType="DATETIME", DataType=LinqToDB.DataType.DateTime), Nullable] public DateTime? DateTimeValue { get; set; } // DATETIME
	}

	[Table("LinqDataTypes Query1", IsView=true)]
	public partial class LinqDataTypesQuery1
	{
		[Column(DbType="INTEGER", DataType=LinqToDB.DataType.Int32), Nullable] public int? ID { get; set; } // INTEGER
	}

	[Table("LinqDataTypes Query2", IsView=true)]
	public partial class LinqDataTypesQuery2
	{
		[Column(DbType="INTEGER", DataType=LinqToDB.DataType.Int32), Nullable] public int? ID { get; set; } // INTEGER
	}

	[Table("Parent")]
	public partial class Parent
	{
		[Column(DbType="INTEGER", DataType=LinqToDB.DataType.Int32), Nullable] public int? ParentID { get; set; } // INTEGER
		[Column(DbType="INTEGER", DataType=LinqToDB.DataType.Int32), Nullable] public int? Value1   { get; set; } // INTEGER
	}

	[Table("Patient")]
	public partial class Patient
	{
		[Column(DbType="INTEGER",      DataType=LinqToDB.DataType.Int32),               Nullable] public int?    PersonID  { get; set; } // INTEGER
		[Column(DbType="VARCHAR(255)", DataType=LinqToDB.DataType.VarChar, Length=255), Nullable] public string? Diagnosis { get; set; } // VARCHAR(255)
	}

	[Table("Patient_SelectAll", IsView=true)]
	public partial class PatientSelectAll
	{
		[Column(DbType="COUNTER",      DataType=LinqToDB.DataType.Int32),               Identity] public int     PersonID   { get; set; } // COUNTER
		[Column(DbType="VARCHAR(50)",  DataType=LinqToDB.DataType.VarChar, Length=50),  Nullable] public string? FirstName  { get; set; } // VARCHAR(50)
		[Column(DbType="VARCHAR(50)",  DataType=LinqToDB.DataType.VarChar, Length=50),  Nullable] public string? LastName   { get; set; } // VARCHAR(50)
		[Column(DbType="VARCHAR(50)",  DataType=LinqToDB.DataType.VarChar, Length=50),  Nullable] public string? MiddleName { get; set; } // VARCHAR(50)
		[Column(DbType="VARCHAR(1)",   DataType=LinqToDB.DataType.VarChar, Length=1),   Nullable] public char?   Gender     { get; set; } // VARCHAR(1)
		[Column(DbType="VARCHAR(255)", DataType=LinqToDB.DataType.VarChar, Length=255), Nullable] public string? Diagnosis  { get; set; } // VARCHAR(255)
	}

	[Table("Person")]
	public partial class Person
	{
		[Column(DbType="COUNTER",     DataType=LinqToDB.DataType.Int32),              Identity] public int     PersonID   { get; set; } // COUNTER
		[Column(DbType="VARCHAR(50)", DataType=LinqToDB.DataType.VarChar, Length=50), Nullable] public string? FirstName  { get; set; } // VARCHAR(50)
		[Column(DbType="VARCHAR(50)", DataType=LinqToDB.DataType.VarChar, Length=50), Nullable] public string? LastName   { get; set; } // VARCHAR(50)
		[Column(DbType="VARCHAR(50)", DataType=LinqToDB.DataType.VarChar, Length=50), Nullable] public string? MiddleName { get; set; } // VARCHAR(50)
		[Column(DbType="VARCHAR(1)",  DataType=LinqToDB.DataType.VarChar, Length=1),  Nullable] public char?   Gender     { get; set; } // VARCHAR(1)
	}

	[Table("Person_SelectAll", IsView=true)]
	public partial class PersonSelectAll
	{
		[Column(DbType="COUNTER",     DataType=LinqToDB.DataType.Int32),              Identity] public int     PersonID   { get; set; } // COUNTER
		[Column(DbType="VARCHAR(50)", DataType=LinqToDB.DataType.VarChar, Length=50), Nullable] public string? FirstName  { get; set; } // VARCHAR(50)
		[Column(DbType="VARCHAR(50)", DataType=LinqToDB.DataType.VarChar, Length=50), Nullable] public string? LastName   { get; set; } // VARCHAR(50)
		[Column(DbType="VARCHAR(50)", DataType=LinqToDB.DataType.VarChar, Length=50), Nullable] public string? MiddleName { get; set; } // VARCHAR(50)
		[Column(DbType="VARCHAR(1)",  DataType=LinqToDB.DataType.VarChar, Length=1),  Nullable] public char?   Gender     { get; set; } // VARCHAR(1)
	}

	[Table("Scalar_DataReader", IsView=true)]
	public partial class ScalarDataReader
	{
		[Column("intField",    DbType="INTEGER", DataType=LinqToDB.DataType.Int32),   Nullable] public int?    IntField    { get; set; } // INTEGER
		[Column("stringField", DbType="VARCHAR", DataType=LinqToDB.DataType.VarChar), Nullable] public string? StringField { get; set; } // VARCHAR
	}

	[Table("TestIdentity")]
	public partial class TestIdentity
	{
		[Column(DbType="COUNTER", DataType=LinqToDB.DataType.Int32), Identity] public int ID { get; set; } // COUNTER
	}

	[Table("TestMerge1")]
	public partial class TestMerge1
	{
		[Column(DbType="INTEGER",         DataType=LinqToDB.DataType.Int32),                                Nullable] public int?      Id              { get; set; } // INTEGER
		[Column(DbType="INTEGER",         DataType=LinqToDB.DataType.Int32),                                Nullable] public int?      Field1          { get; set; } // INTEGER
		[Column(DbType="INTEGER",         DataType=LinqToDB.DataType.Int32),                                Nullable] public int?      Field2          { get; set; } // INTEGER
		[Column(DbType="INTEGER",         DataType=LinqToDB.DataType.Int32),                                Nullable] public int?      Field3          { get; set; } // INTEGER
		[Column(DbType="INTEGER",         DataType=LinqToDB.DataType.Int32),                                Nullable] public int?      Field4          { get; set; } // INTEGER
		[Column(DbType="INTEGER",         DataType=LinqToDB.DataType.Int32),                                Nullable] public int?      Field5          { get; set; } // INTEGER
		[Column(DbType="BIT",             DataType=LinqToDB.DataType.Boolean),                           NotNull    ] public bool      FieldBoolean    { get; set; } // BIT
		[Column(DbType="VARCHAR(20)",     DataType=LinqToDB.DataType.VarChar,   Length=20),                 Nullable] public string?   FieldString     { get; set; } // VARCHAR(20)
		[Column(DbType="VARCHAR(20)",     DataType=LinqToDB.DataType.VarChar,   Length=20),                 Nullable] public string?   FieldNString    { get; set; } // VARCHAR(20)
		[Column(DbType="CHAR(1)",         DataType=LinqToDB.DataType.Char,      Length=1),                  Nullable] public char?     FieldChar       { get; set; } // CHAR(1)
		[Column(DbType="CHAR(1)",         DataType=LinqToDB.DataType.Char,      Length=1),                  Nullable] public char?     FieldNChar      { get; set; } // CHAR(1)
		[Column(DbType="REAL",            DataType=LinqToDB.DataType.Single),                               Nullable] public float?    FieldFloat      { get; set; } // REAL
		[Column(DbType="DOUBLE",          DataType=LinqToDB.DataType.Double),                               Nullable] public double?   FieldDouble     { get; set; } // DOUBLE
		[Column(DbType="DATETIME",        DataType=LinqToDB.DataType.DateTime),                             Nullable] public DateTime? FieldDateTime   { get; set; } // DATETIME
		[Column(DbType="VARBINARY(20)",   DataType=LinqToDB.DataType.VarBinary, Length=20),                 Nullable] public byte[]?   FieldBinary     { get; set; } // VARBINARY(20)
		[Column(DbType="GUID",            DataType=LinqToDB.DataType.Guid),                                 Nullable] public Guid?     FieldGuid       { get; set; } // GUID
		[Column(DbType="DECIMAL(24, 10)", DataType=LinqToDB.DataType.Decimal,   Precision=24, Scale=10),    Nullable] public decimal?  FieldDecimal    { get; set; } // DECIMAL(24, 10)
		[Column(DbType="DATETIME",        DataType=LinqToDB.DataType.DateTime),                             Nullable] public DateTime? FieldDate       { get; set; } // DATETIME
		[Column(DbType="DATETIME",        DataType=LinqToDB.DataType.DateTime),                             Nullable] public DateTime? FieldTime       { get; set; } // DATETIME
		[Column(DbType="VARCHAR(20)",     DataType=LinqToDB.DataType.VarChar,   Length=20),                 Nullable] public string?   FieldEnumString { get; set; } // VARCHAR(20)
		[Column(DbType="INTEGER",         DataType=LinqToDB.DataType.Int32),                                Nullable] public int?      FieldEnumNumber { get; set; } // INTEGER
	}

	[Table("TestMerge2")]
	public partial class TestMerge2
	{
		[Column(DbType="INTEGER",         DataType=LinqToDB.DataType.Int32),                                Nullable] public int?      Id              { get; set; } // INTEGER
		[Column(DbType="INTEGER",         DataType=LinqToDB.DataType.Int32),                                Nullable] public int?      Field1          { get; set; } // INTEGER
		[Column(DbType="INTEGER",         DataType=LinqToDB.DataType.Int32),                                Nullable] public int?      Field2          { get; set; } // INTEGER
		[Column(DbType="INTEGER",         DataType=LinqToDB.DataType.Int32),                                Nullable] public int?      Field3          { get; set; } // INTEGER
		[Column(DbType="INTEGER",         DataType=LinqToDB.DataType.Int32),                                Nullable] public int?      Field4          { get; set; } // INTEGER
		[Column(DbType="INTEGER",         DataType=LinqToDB.DataType.Int32),                                Nullable] public int?      Field5          { get; set; } // INTEGER
		[Column(DbType="BIT",             DataType=LinqToDB.DataType.Boolean),                           NotNull    ] public bool      FieldBoolean    { get; set; } // BIT
		[Column(DbType="VARCHAR(20)",     DataType=LinqToDB.DataType.VarChar,   Length=20),                 Nullable] public string?   FieldString     { get; set; } // VARCHAR(20)
		[Column(DbType="VARCHAR(20)",     DataType=LinqToDB.DataType.VarChar,   Length=20),                 Nullable] public string?   FieldNString    { get; set; } // VARCHAR(20)
		[Column(DbType="CHAR(1)",         DataType=LinqToDB.DataType.Char,      Length=1),                  Nullable] public char?     FieldChar       { get; set; } // CHAR(1)
		[Column(DbType="CHAR(1)",         DataType=LinqToDB.DataType.Char,      Length=1),                  Nullable] public char?     FieldNChar      { get; set; } // CHAR(1)
		[Column(DbType="REAL",            DataType=LinqToDB.DataType.Single),                               Nullable] public float?    FieldFloat      { get; set; } // REAL
		[Column(DbType="DOUBLE",          DataType=LinqToDB.DataType.Double),                               Nullable] public double?   FieldDouble     { get; set; } // DOUBLE
		[Column(DbType="DATETIME",        DataType=LinqToDB.DataType.DateTime),                             Nullable] public DateTime? FieldDateTime   { get; set; } // DATETIME
		[Column(DbType="VARBINARY(20)",   DataType=LinqToDB.DataType.VarBinary, Length=20),                 Nullable] public byte[]?   FieldBinary     { get; set; } // VARBINARY(20)
		[Column(DbType="GUID",            DataType=LinqToDB.DataType.Guid),                                 Nullable] public Guid?     FieldGuid       { get; set; } // GUID
		[Column(DbType="DECIMAL(24, 10)", DataType=LinqToDB.DataType.Decimal,   Precision=24, Scale=10),    Nullable] public decimal?  FieldDecimal    { get; set; } // DECIMAL(24, 10)
		[Column(DbType="DATETIME",        DataType=LinqToDB.DataType.DateTime),                             Nullable] public DateTime? FieldDate       { get; set; } // DATETIME
		[Column(DbType="DATETIME",        DataType=LinqToDB.DataType.DateTime),                             Nullable] public DateTime? FieldTime       { get; set; } // DATETIME
		[Column(DbType="VARCHAR(20)",     DataType=LinqToDB.DataType.VarChar,   Length=20),                 Nullable] public string?   FieldEnumString { get; set; } // VARCHAR(20)
		[Column(DbType="INTEGER",         DataType=LinqToDB.DataType.Int32),                                Nullable] public int?      FieldEnumNumber { get; set; } // INTEGER
	}

	public static partial class TestDataDBStoredProcedures
	{
		#region PatientSelectByName

		public static IEnumerable<PatientSelectByNameResult> PatientSelectByName(this TestDataDB dataConnection, string? @firstName, string? @lastName)
		{
			return dataConnection.QueryProc<PatientSelectByNameResult>("[Patient_SelectByName]",
				new DataParameter("@firstName", @firstName, LinqToDB.DataType.VarChar),
				new DataParameter("@lastName",  @lastName,  LinqToDB.DataType.VarChar));
		}

		public partial class PatientSelectByNameResult
		{
			public int     PersonID   { get; set; }
			public string? FirstName  { get; set; }
			public string? LastName   { get; set; }
			public string? MiddleName { get; set; }
			public string? Gender     { get; set; }
			public string? Diagnosis  { get; set; }
		}

		#endregion

		#region PersonDelete

		public static int PersonDelete(this TestDataDB dataConnection, int? @PersonID)
		{
			return dataConnection.ExecuteProc("[Person_Delete]",
				new DataParameter("@PersonID", @PersonID, LinqToDB.DataType.Int32));
		}

		#endregion

		#region PersonInsert

		public static int PersonInsert(this TestDataDB dataConnection, string? @FirstName, string? @MiddleName, string? @LastName, string? @Gender)
		{
			return dataConnection.ExecuteProc("[Person_Insert]",
				new DataParameter("@FirstName",  @FirstName,  LinqToDB.DataType.VarChar),
				new DataParameter("@MiddleName", @MiddleName, LinqToDB.DataType.VarChar),
				new DataParameter("@LastName",   @LastName,   LinqToDB.DataType.VarChar),
				new DataParameter("@Gender",     @Gender,     LinqToDB.DataType.VarChar));
		}

		#endregion

		#region PersonSelectByKey

		public static IEnumerable<PersonSelectByKeyResult> PersonSelectByKey(this TestDataDB dataConnection, int? @id)
		{
			return dataConnection.QueryProc<PersonSelectByKeyResult>("[Person_SelectByKey]",
				new DataParameter("@id", @id, LinqToDB.DataType.Int32));
		}

		public partial class PersonSelectByKeyResult
		{
			public int     PersonID   { get; set; }
			public string? FirstName  { get; set; }
			public string? LastName   { get; set; }
			public string? MiddleName { get; set; }
			public string? Gender     { get; set; }
		}

		#endregion

		#region PersonSelectByName

		public static IEnumerable<PersonSelectByNameResult> PersonSelectByName(this TestDataDB dataConnection, string? @firstName, string? @lastName)
		{
			return dataConnection.QueryProc<PersonSelectByNameResult>("[Person_SelectByName]",
				new DataParameter("@firstName", @firstName, LinqToDB.DataType.VarChar),
				new DataParameter("@lastName",  @lastName,  LinqToDB.DataType.VarChar));
		}

		public partial class PersonSelectByNameResult
		{
			public int     PersonID   { get; set; }
			public string? FirstName  { get; set; }
			public string? LastName   { get; set; }
			public string? MiddleName { get; set; }
			public string? Gender     { get; set; }
		}

		#endregion

		#region PersonSelectListByName

		public static IEnumerable<PersonSelectListByNameResult> PersonSelectListByName(this TestDataDB dataConnection, string? @firstName, string? @lastName)
		{
			return dataConnection.QueryProc<PersonSelectListByNameResult>("[Person_SelectListByName]",
				new DataParameter("@firstName", @firstName, LinqToDB.DataType.VarChar),
				new DataParameter("@lastName",  @lastName,  LinqToDB.DataType.VarChar));
		}

		public partial class PersonSelectListByNameResult
		{
			public int     PersonID   { get; set; }
			public string? FirstName  { get; set; }
			public string? LastName   { get; set; }
			public string? MiddleName { get; set; }
			public string? Gender     { get; set; }
		}

		#endregion

		#region PersonUpdate

		public static int PersonUpdate(this TestDataDB dataConnection, int? @id, int? @PersonID, string? @FirstName, string? @MiddleName, string? @LastName, string? @Gender)
		{
			return dataConnection.ExecuteProc("[Person_Update]",
				new DataParameter("@id",         @id,         LinqToDB.DataType.Int32),
				new DataParameter("@PersonID",   @PersonID,   LinqToDB.DataType.Int32),
				new DataParameter("@FirstName",  @FirstName,  LinqToDB.DataType.VarChar),
				new DataParameter("@MiddleName", @MiddleName, LinqToDB.DataType.VarChar),
				new DataParameter("@LastName",   @LastName,   LinqToDB.DataType.VarChar),
				new DataParameter("@Gender",     @Gender,     LinqToDB.DataType.VarChar));
		}

		#endregion
	}
}

#pragma warning restore 1591
