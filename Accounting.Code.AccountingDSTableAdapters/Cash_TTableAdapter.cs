using System.ComponentModel;
using System.ComponentModel.Design;
using System.CodeDom.Compiler;
using System.Data.SqlClient;
using System;
using System.Diagnostics;
using System.Data;
using System.Data.Common;
using Accounting.Properties;
using Accounting.Code;

namespace Accounting.Code.AccountingDSTableAdapters
{
[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapter")]
[DesignerCategory("code")]
[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class Cash_TTableAdapter : Component
{
	private SqlDataAdapter _adapter;

	private bool _clearBeforeFill;

	private SqlCommand[] _commandCollection;

	private SqlConnection _connection;

	private SqlTransaction _transaction;

	[DebuggerNonUserCode]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (this._adapter == null)
			{
				this.InitAdapter();
			}
			return this._adapter;
		}
	}

	[DebuggerNonUserCode]
	public bool ClearBeforeFill
	{
		get
		{
			return this._clearBeforeFill;
		}
		set
		{
			this._clearBeforeFill = value;
		}
	}

	[DebuggerNonUserCode]
	protected SqlCommand[] CommandCollection
	{
		get
		{
			if (this._commandCollection == null)
			{
				this.InitCommandCollection();
			}
			return this._commandCollection;
		}
	}

	[DebuggerNonUserCode]
	internal SqlConnection Connection
	{
		get
		{
			if (this._connection == null)
			{
				this.InitConnection();
			}
			return this._connection;
		}
		set
		{
			this._connection = value;
			if (this.Adapter.InsertCommand != null)
			{
				this.Adapter.InsertCommand.Connection = value;
			}
			if (this.Adapter.DeleteCommand != null)
			{
				this.Adapter.DeleteCommand.Connection = value;
			}
			if (this.Adapter.UpdateCommand != null)
			{
				this.Adapter.UpdateCommand.Connection = value;
			}
			for (int i = 0; i < (int)this.CommandCollection.Length; i++)
			{
				if (this.CommandCollection[i] != null)
				{
					this.CommandCollection[i].Connection = value;
				}
			}
		}
	}

	[DebuggerNonUserCode]
	internal SqlTransaction Transaction
	{
		get
		{
			return this._transaction;
		}
		set
		{
			this._transaction = value;
			for (int i = 0; i < (int)this.CommandCollection.Length; i++)
			{
				this.CommandCollection[i].Transaction = this._transaction;
			}
			if (this.Adapter && this.Adapter.DeleteCommand != null)
			{
				this.Adapter.DeleteCommand.Transaction = this._transaction;
			}
			if (this.Adapter && this.Adapter.InsertCommand != null)
			{
				this.Adapter.InsertCommand.Transaction = this._transaction;
			}
			if (this.Adapter && this.Adapter.UpdateCommand != null)
			{
				this.Adapter.UpdateCommand.Transaction = this._transaction;
			}
		}
	}

	[DebuggerNonUserCode]
	public Cash_TTableAdapter()
	{
		this.ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Delete(int Original_Code)
	{
		int num1;
		this.Adapter.DeleteCommand.Parameters[0].Value = Original_Code;
		ConnectionState state = this.Adapter.DeleteCommand.Connection.State;
		if ((this.Adapter.DeleteCommand.Connection.State & 1) != 1)
		{
			this.Adapter.DeleteCommand.Connection.Open();
		}
		try
		{
			int num2 = this.Adapter.DeleteCommand.ExecuteNonQuery();
			num1 = num2;
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				this.Adapter.DeleteCommand.Connection.Close();
			}
		}
		return num1;
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Fill(Cash_TDataTable dataTable)
	{
		this.Adapter.SelectCommand = this.CommandCollection[0];
		if (this.ClearBeforeFill)
		{
			dataTable.Clear();
		}
		int num = this.Adapter.Fill(dataTable);
		return num;
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual Cash_TDataTable GetData()
	{
		this.Adapter.SelectCommand = this.CommandCollection[0];
		Cash_TDataTable cashTDataTable = new Cash_TDataTable();
		this.Adapter.Fill(cashTDataTable);
		return cashTDataTable;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int? getMax()
	{
		object obj;
		SqlCommand commandCollection = this.CommandCollection[1];
		ConnectionState state = commandCollection.Connection.State;
		if ((commandCollection.Connection.State & 1) != 1)
		{
			commandCollection.Connection.Open();
		}
		try
		{
			obj = commandCollection.ExecuteScalar();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				commandCollection.Connection.Close();
			}
		}
		if (obj == null || obj.GetType() == typeof(DBNull))
		{
			int? nullable = null;
			return nullable;
		}
		return new int?((int)obj);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual string GetType(int Code)
	{
		object obj;
		SqlCommand commandCollection = this.CommandCollection[2];
		commandCollection.Parameters[0].Value = Code;
		ConnectionState state = commandCollection.Connection.State;
		if ((commandCollection.Connection.State & 1) != 1)
		{
			commandCollection.Connection.Open();
		}
		try
		{
			obj = commandCollection.ExecuteScalar();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				commandCollection.Connection.Close();
			}
		}
		if (obj == null || obj.GetType() == typeof(DBNull))
		{
			return null;
		}
		return (string)obj;
	}

	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		this._adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Cash_T";
		dataTableMapping.ColumnMappings.Add("Code", "Code");
		dataTableMapping.ColumnMappings.Add("Type", "Type");
		dataTableMapping.ColumnMappings.Add("BankCode", "BankCode");
		dataTableMapping.ColumnMappings.Add("chkNumber", "chkNumber");
		this._adapter.TableMappings.Add(dataTableMapping);
		this._adapter.DeleteCommand = new SqlCommand();
		this._adapter.DeleteCommand.Connection = this.Connection;
		this._adapter.DeleteCommand.CommandText = "DELETE FROM Cash_T\r\nWHERE        (Code = @Original_Code)";
		this._adapter.DeleteCommand.CommandType = CommandType.Text;
		this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Code", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Code", DataRowVersion.Original, false, null, "", "", ""));
		this._adapter.InsertCommand = new SqlCommand();
		this._adapter.InsertCommand.Connection = this.Connection;
		this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Cash_T] ([Code], [Type], [BankCode], [chkNumber]) VALUES (@Code, @Type, @BankCode, @chkNumber);\r\nSELECT Code, Type, BankCode, chkNumber FROM Cash_T WHERE (Code = @Code)";
		this._adapter.InsertCommand.CommandType = CommandType.Text;
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Code", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Code", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Type", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BankCode", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "BankCode", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@chkNumber", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "chkNumber", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand = new SqlCommand();
		this._adapter.UpdateCommand.Connection = this.Connection;
		this._adapter.UpdateCommand.CommandText = "UPDATE       Cash_T\r\nSET                Code = @Code, Type = @Type, BankCode = @BankCode, chkNumber = @chkNumber\r\nWHERE        (Code = @Original_Code); \r\nSELECT Code, Type, BankCode, chkNumber FROM Cash_T WHERE (Code = @Code)";
		this._adapter.UpdateCommand.CommandType = CommandType.Text;
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Code", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Code", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, "Type", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BankCode", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "BankCode", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@chkNumber", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "chkNumber", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Code", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Code", DataRowVersion.Original, false, null, "", "", ""));
	}

	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		this._commandCollection = new SqlCommand[3];
		this._commandCollection[0] = new SqlCommand();
		this._commandCollection[0].Connection = this.Connection;
		this._commandCollection[0].CommandText = "SELECT Code, Type, BankCode, chkNumber FROM dbo.Cash_T";
		this._commandCollection[0].CommandType = CommandType.Text;
		this._commandCollection[1] = new SqlCommand();
		this._commandCollection[1].Connection = this.Connection;
		this._commandCollection[1].CommandText = "SELECT        MAX(Code) AS code\r\nFROM            Cash_T";
		this._commandCollection[1].CommandType = CommandType.Text;
		this._commandCollection[2] = new SqlCommand();
		this._commandCollection[2].Connection = this.Connection;
		this._commandCollection[2].CommandText = "SELECT        Type\r\nFROM            Cash_T\r\nWHERE        (Code = @Code)";
		this._commandCollection[2].CommandType = CommandType.Text;
		this._commandCollection[2].Parameters.Add(new SqlParameter("@Code", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Code", DataRowVersion.Current, false, null, "", "", ""));
	}

	[DebuggerNonUserCode]
	private void InitConnection()
	{
		this._connection = new SqlConnection();
		this._connection.ConnectionString = Settings.Default.AccountingDBConnectionString;
	}

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Insert(int Code, string Type, int? BankCode, int? chkNumber)
	{
		int num1;
		this.Adapter.InsertCommand.Parameters[0].Value = Code;
		if (Type == null)
		{
			throw new ArgumentNullException("Type");
		}
		this.Adapter.InsertCommand.Parameters[1].Value = Type;
		if (&BankCode.HasValue)
		{
			this.Adapter.InsertCommand.Parameters[2].Value = &BankCode.Value;
		}
		else
		{
			this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		if (&chkNumber.HasValue)
		{
			this.Adapter.InsertCommand.Parameters[3].Value = &chkNumber.Value;
		}
		else
		{
			this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
		}
		ConnectionState state = this.Adapter.InsertCommand.Connection.State;
		if ((this.Adapter.InsertCommand.Connection.State & 1) != 1)
		{
			this.Adapter.InsertCommand.Connection.Open();
		}
		try
		{
			int num2 = this.Adapter.InsertCommand.ExecuteNonQuery();
			num1 = num2;
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				this.Adapter.InsertCommand.Connection.Close();
			}
		}
		return num1;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Update(Cash_TDataTable dataTable)
	{
		return this.Adapter.Update(dataTable);
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(AccountingDS dataSet)
	{
		return this.Adapter.Update(dataSet, "Cash_T");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Update(DataRow dataRow)
	{
		DataRow[] dataRowArray;
		return this.Adapter.Update(new DataRow[] { dataRow });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Update(DataRow[] dataRows)
	{
		return this.Adapter.Update(dataRows);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int Update(int Code, string Type, int? BankCode, int? chkNumber, int Original_Code)
	{
		int num1;
		this.Adapter.UpdateCommand.Parameters[0].Value = Code;
		if (Type == null)
		{
			throw new ArgumentNullException("Type");
		}
		this.Adapter.UpdateCommand.Parameters[1].Value = Type;
		if (&BankCode.HasValue)
		{
			this.Adapter.UpdateCommand.Parameters[2].Value = &BankCode.Value;
		}
		else
		{
			this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		if (&chkNumber.HasValue)
		{
			this.Adapter.UpdateCommand.Parameters[3].Value = &chkNumber.Value;
		}
		else
		{
			this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
		}
		this.Adapter.UpdateCommand.Parameters[4].Value = Original_Code;
		ConnectionState state = this.Adapter.UpdateCommand.Connection.State;
		if ((this.Adapter.UpdateCommand.Connection.State & 1) != 1)
		{
			this.Adapter.UpdateCommand.Connection.Open();
		}
		try
		{
			int num2 = this.Adapter.UpdateCommand.ExecuteNonQuery();
			num1 = num2;
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				this.Adapter.UpdateCommand.Connection.Close();
			}
		}
		return num1;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int Update(string Type, int? BankCode, int? chkNumber, int Original_Code)
	{
		return this.Update(Original_Code, Type, BankCode, chkNumber, Original_Code);
	}
}
}