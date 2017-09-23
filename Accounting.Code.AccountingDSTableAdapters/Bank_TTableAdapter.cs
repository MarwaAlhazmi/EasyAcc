using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System;
using System.Diagnostics;
using System.Data;
using System.Data.Common;
using Accounting.Properties;
using Accounting.Code;

namespace Accounting.Code.AccountingDSTableAdapters
{
[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
[DesignerCategory("code")]
[ToolboxItem(true)]
public class Bank_TTableAdapter : Component
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
	public Bank_TTableAdapter()
	{
		this.ClearBeforeFill = true;
	}

	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Delete(int AccCode)
	{
		int num1;
		this.Adapter.DeleteCommand.Parameters[0].Value = AccCode;
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

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[DebuggerNonUserCode]
	public virtual int Fill(Bank_TDataTable dataTable)
	{
		this.Adapter.SelectCommand = this.CommandCollection[0];
		if (this.ClearBeforeFill)
		{
			dataTable.Clear();
		}
		int num = this.Adapter.Fill(dataTable);
		return num;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int? GetAccountCode(int code)
	{
		object obj;
		SqlCommand commandCollection = this.CommandCollection[1];
		commandCollection.Parameters[0].Value = code;
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

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual Bank_TDataTable GetData()
	{
		this.Adapter.SelectCommand = this.CommandCollection[0];
		Bank_TDataTable bankTDataTable = new Bank_TDataTable();
		this.Adapter.Fill(bankTDataTable);
		return bankTDataTable;
	}

	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		this._adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Bank_T";
		dataTableMapping.ColumnMappings.Add("Code", "Code");
		dataTableMapping.ColumnMappings.Add("Name", "Name");
		dataTableMapping.ColumnMappings.Add("AccCode", "AccCode");
		dataTableMapping.ColumnMappings.Add("Contacts", "Contacts");
		this._adapter.TableMappings.Add(dataTableMapping);
		this._adapter.DeleteCommand = new SqlCommand();
		this._adapter.DeleteCommand.Connection = this.Connection;
		this._adapter.DeleteCommand.CommandText = "DELETE FROM Bank_T\r\nWHERE        (AccCode = @AccCode)";
		this._adapter.DeleteCommand.CommandType = CommandType.Text;
		this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@AccCode", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "AccCode", DataRowVersion.Original, false, null, "", "", ""));
		this._adapter.InsertCommand = new SqlCommand();
		this._adapter.InsertCommand.Connection = this.Connection;
		this._adapter.InsertCommand.CommandText = "INSERT INTO Bank_T\r\n                         (Name, AccCode, Contacts)\r\nVALUES        (@Name,@AccCode,@Contacts); \r\nSELECT Code, Name, AccCode, Contacts FROM Bank_T WHERE (Code = SCOPE_IDENTITY())";
		this._adapter.InsertCommand.CommandType = CommandType.Text;
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, "Name", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@AccCode", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "AccCode", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Contacts", SqlDbType.NVarChar, 200, ParameterDirection.Input, 0, 0, "Contacts", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand = new SqlCommand();
		this._adapter.UpdateCommand.Connection = this.Connection;
		this._adapter.UpdateCommand.CommandText = "UPDATE       Bank_T\r\nSET                Name = @Name, AccCode = @AccCode, Contacts = @Contacts\r\nWHERE        (AccCode = @Code); \r\nSELECT Code, Name, AccCode, Contacts FROM Bank_T WHERE (Code = @Code)";
		this._adapter.UpdateCommand.CommandType = CommandType.Text;
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, "Name", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@AccCode", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "AccCode", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Contacts", SqlDbType.NVarChar, 200, ParameterDirection.Input, 0, 0, "Contacts", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Code", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "AccCode", DataRowVersion.Original, false, null, "", "", ""));
	}

	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		this._commandCollection = new SqlCommand[2];
		this._commandCollection[0] = new SqlCommand();
		this._commandCollection[0].Connection = this.Connection;
		this._commandCollection[0].CommandText = "SELECT        Code, Name, AccCode, Contacts\r\nFROM            Bank_T";
		this._commandCollection[0].CommandType = CommandType.Text;
		this._commandCollection[1] = new SqlCommand();
		this._commandCollection[1].Connection = this.Connection;
		this._commandCollection[1].CommandText = "SELECT        AccCode\r\nFROM            Bank_T\r\nWHERE        (Code = @code)";
		this._commandCollection[1].CommandType = CommandType.Text;
		this._commandCollection[1].Parameters.Add(new SqlParameter("@code", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Code", DataRowVersion.Current, false, null, "", "", ""));
	}

	[DebuggerNonUserCode]
	private void InitConnection()
	{
		this._connection = new SqlConnection();
		this._connection.ConnectionString = Settings.Default.AccountingDBConnectionString;
	}

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Insert(string Name, int AccCode, string Contacts)
	{
		int num1;
		if (Name == null)
		{
			throw new ArgumentNullException("Name");
		}
		this.Adapter.InsertCommand.Parameters[0].Value = Name;
		this.Adapter.InsertCommand.Parameters[1].Value = AccCode;
		if (Contacts == null)
		{
			this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			this.Adapter.InsertCommand.Parameters[2].Value = Contacts;
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

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(Bank_TDataTable dataTable)
	{
		return this.Adapter.Update(dataTable);
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(AccountingDS dataSet)
	{
		return this.Adapter.Update(dataSet, "Bank_T");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Update(DataRow dataRow)
	{
		DataRow[] dataRowArray;
		return this.Adapter.Update(new DataRow[] { dataRow });
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataRow[] dataRows)
	{
		return this.Adapter.Update(dataRows);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int Update(string Name, int AccCode, string Contacts, int Code)
	{
		int num1;
		if (Name == null)
		{
			throw new ArgumentNullException("Name");
		}
		this.Adapter.UpdateCommand.Parameters[0].Value = Name;
		this.Adapter.UpdateCommand.Parameters[1].Value = AccCode;
		if (Contacts == null)
		{
			this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			this.Adapter.UpdateCommand.Parameters[2].Value = Contacts;
		}
		this.Adapter.UpdateCommand.Parameters[3].Value = Code;
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
}
}