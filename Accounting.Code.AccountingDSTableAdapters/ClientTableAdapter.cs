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
[DataObject(true)]
[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
public class ClientTableAdapter : Component
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
	public ClientTableAdapter()
	{
		this.ClearBeforeFill = true;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	public virtual int Delete(int? AccCode)
	{
		int num1;
		if (&AccCode.HasValue)
		{
			this.Adapter.DeleteCommand.Parameters[1].Value = &AccCode.Value;
		}
		else
		{
			this.Adapter.DeleteCommand.Parameters[1].Value = DBNull.Value;
		}
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
	public virtual int Fill(ClientDataTable dataTable)
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
	public virtual ClientDataTable GetClient()
	{
		this.Adapter.SelectCommand = this.CommandCollection[0];
		ClientDataTable clientDataTable = new ClientDataTable();
		this.Adapter.Fill(clientDataTable);
		return clientDataTable;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int? getLastClient()
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

	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		this._adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Client";
		dataTableMapping.ColumnMappings.Add("ClientID", "ClientID");
		dataTableMapping.ColumnMappings.Add("Name", "Name");
		dataTableMapping.ColumnMappings.Add("Phone", "Phone");
		dataTableMapping.ColumnMappings.Add("Nationality", "Nationality");
		dataTableMapping.ColumnMappings.Add("IDNumber", "IDNumber");
		dataTableMapping.ColumnMappings.Add("Address", "Address");
		dataTableMapping.ColumnMappings.Add("AccCode", "AccCode");
		this._adapter.TableMappings.Add(dataTableMapping);
		this._adapter.DeleteCommand = new SqlCommand();
		this._adapter.DeleteCommand.Connection = this.Connection;
		this._adapter.DeleteCommand.CommandText = "dbo.deleteClient";
		this._adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
		this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@AccCode", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, "AccCode", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand = new SqlCommand();
		this._adapter.InsertCommand.Connection = this.Connection;
		this._adapter.InsertCommand.CommandText = "dbo.insertClient";
		this._adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 150, ParameterDirection.Input, 0, 0, "Name", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Nation", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, "Nationality", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.BigInt, 8, ParameterDirection.Input, 19, 0, "IDNumber", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 200, ParameterDirection.Input, 0, 0, "Address", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.BigInt, 8, ParameterDirection.Input, 19, 0, "Phone", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@AccCode", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, "AccCode", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Balance", SqlDbType.Money, 8, ParameterDirection.Input, 19, 4, "", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand = new SqlCommand();
		this._adapter.UpdateCommand.Connection = this.Connection;
		this._adapter.UpdateCommand.CommandText = "dbo.updateClient";
		this._adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ClientID", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, "ClientID", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 150, ParameterDirection.Input, 0, 0, "Name", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Nation", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, "Nationality", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.BigInt, 8, ParameterDirection.Input, 19, 0, "IDNumber", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 200, ParameterDirection.Input, 0, 0, "Address", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.BigInt, 8, ParameterDirection.Input, 19, 0, "Phone", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@AccCode", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, "AccCode", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@oldAcc", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, "AccCode", DataRowVersion.Current, false, null, "", "", ""));
	}

	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		this._commandCollection = new SqlCommand[2];
		this._commandCollection[0] = new SqlCommand();
		this._commandCollection[0].Connection = this.Connection;
		this._commandCollection[0].CommandText = "dbo.selectClient";
		this._commandCollection[0].CommandType = CommandType.StoredProcedure;
		this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1] = new SqlCommand();
		this._commandCollection[1].Connection = this.Connection;
		this._commandCollection[1].CommandText = "SELECT        MAX(AccCode) AS Expr1\r\nFROM            Client";
		this._commandCollection[1].CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	private void InitConnection()
	{
		this._connection = new SqlConnection();
		this._connection.ConnectionString = Settings.Default.AccountingDBConnectionString;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[DebuggerNonUserCode]
	public virtual int Insert(string Name, string Nation, long? ID, string Address, long? Phone, int? AccCode, decimal? Balance)
	{
		int num1;
		if (Name == null)
		{
			this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			this.Adapter.InsertCommand.Parameters[1].Value = Name;
		}
		if (Nation == null)
		{
			this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			this.Adapter.InsertCommand.Parameters[2].Value = Nation;
		}
		if (&ID.HasValue)
		{
			this.Adapter.InsertCommand.Parameters[3].Value = &ID.Value;
		}
		else
		{
			this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
		}
		if (Address == null)
		{
			this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			this.Adapter.InsertCommand.Parameters[4].Value = Address;
		}
		if (&Phone.HasValue)
		{
			this.Adapter.InsertCommand.Parameters[5].Value = &Phone.Value;
		}
		else
		{
			this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
		}
		if (&AccCode.HasValue)
		{
			this.Adapter.InsertCommand.Parameters[6].Value = &AccCode.Value;
		}
		else
		{
			this.Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
		}
		if (&Balance.HasValue)
		{
			this.Adapter.InsertCommand.Parameters[7].Value = &Balance.Value;
		}
		else
		{
			this.Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
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
	public virtual int Update(ClientDataTable dataTable)
	{
		return this.Adapter.Update(dataTable);
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(AccountingDS dataSet)
	{
		return this.Adapter.Update(dataSet, "Client");
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
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

	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(int? ClientID, string Name, string Nation, long? ID, string Address, long? Phone, int? AccCode, int? oldAcc)
	{
		int num1;
		if (&ClientID.HasValue)
		{
			this.Adapter.UpdateCommand.Parameters[1].Value = &ClientID.Value;
		}
		else
		{
			this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
		}
		if (Name == null)
		{
			this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			this.Adapter.UpdateCommand.Parameters[2].Value = Name;
		}
		if (Nation == null)
		{
			this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			this.Adapter.UpdateCommand.Parameters[3].Value = Nation;
		}
		if (&ID.HasValue)
		{
			this.Adapter.UpdateCommand.Parameters[4].Value = &ID.Value;
		}
		else
		{
			this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
		}
		if (Address == null)
		{
			this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			this.Adapter.UpdateCommand.Parameters[5].Value = Address;
		}
		if (&Phone.HasValue)
		{
			this.Adapter.UpdateCommand.Parameters[6].Value = &Phone.Value;
		}
		else
		{
			this.Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
		}
		if (&AccCode.HasValue)
		{
			this.Adapter.UpdateCommand.Parameters[7].Value = &AccCode.Value;
		}
		else
		{
			this.Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
		}
		if (&oldAcc.HasValue)
		{
			this.Adapter.UpdateCommand.Parameters[8].Value = &oldAcc.Value;
		}
		else
		{
			this.Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
		}
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