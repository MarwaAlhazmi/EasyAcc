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
[DataObject(true)]
[HelpKeyword("vs.data.TableAdapter")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
public class EmployeeTableAdapter : Component
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
	public EmployeeTableAdapter()
	{
		this.ClearBeforeFill = true;
	}

	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
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
	public virtual int Fill(EmployeeDataTable dataTable)
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
	public virtual EmployeeDataTable GetData()
	{
		this.Adapter.SelectCommand = this.CommandCollection[0];
		EmployeeDataTable employeeDataTable = new EmployeeDataTable();
		this.Adapter.Fill(employeeDataTable);
		return employeeDataTable;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int? getLastEmployee()
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
		dataTableMapping.DataSetTable = "Employee";
		dataTableMapping.ColumnMappings.Add("EmployeeID", "EmployeeID");
		dataTableMapping.ColumnMappings.Add("Name", "Name");
		dataTableMapping.ColumnMappings.Add("Nationality", "Nationality");
		dataTableMapping.ColumnMappings.Add("IDNumber", "IDNumber");
		dataTableMapping.ColumnMappings.Add("Phone", "Phone");
		dataTableMapping.ColumnMappings.Add("Address", "Address");
		dataTableMapping.ColumnMappings.Add("AccCode", "AccCode");
		dataTableMapping.ColumnMappings.Add("Role", "Role");
		this._adapter.TableMappings.Add(dataTableMapping);
		this._adapter.DeleteCommand = new SqlCommand();
		this._adapter.DeleteCommand.Connection = this.Connection;
		this._adapter.DeleteCommand.CommandText = "dbo.deleteEmployee";
		this._adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
		this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@AccCode", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, "AccCode", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand = new SqlCommand();
		this._adapter.InsertCommand.Connection = this.Connection;
		this._adapter.InsertCommand.CommandText = "dbo.insertEmployee";
		this._adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 150, ParameterDirection.Input, 0, 0, "Name", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Nation", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, "Nationality", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.BigInt, 8, ParameterDirection.Input, 19, 0, "IDNumber", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 200, ParameterDirection.Input, 0, 0, "Address", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.BigInt, 8, ParameterDirection.Input, 19, 0, "Phone", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@AccCode", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, "AccCode", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Role", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, "Role", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Balance", SqlDbType.Money, 8, ParameterDirection.Input, 19, 4, "", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand = new SqlCommand();
		this._adapter.UpdateCommand.Connection = this.Connection;
		this._adapter.UpdateCommand.CommandText = "dbo.updateEmployee";
		this._adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, "EmployeeID", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 150, ParameterDirection.Input, 0, 0, "Name", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Nation", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, "Nationality", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.BigInt, 8, ParameterDirection.Input, 19, 0, "IDNumber", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 200, ParameterDirection.Input, 0, 0, "Address", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.BigInt, 8, ParameterDirection.Input, 19, 0, "Phone", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@AccCode", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, "AccCode", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@oldAcc", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, "", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Role", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, "Role", DataRowVersion.Current, false, null, "", "", ""));
	}

	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		this._commandCollection = new SqlCommand[2];
		this._commandCollection[0] = new SqlCommand();
		this._commandCollection[0].Connection = this.Connection;
		this._commandCollection[0].CommandText = "dbo.selectEmployee";
		this._commandCollection[0].CommandType = CommandType.StoredProcedure;
		this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1] = new SqlCommand();
		this._commandCollection[1].Connection = this.Connection;
		this._commandCollection[1].CommandText = "SELECT        MAX(AccCode) AS Expr1\r\nFROM            Employee";
		this._commandCollection[1].CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	private void InitConnection()
	{
		this._connection = new SqlConnection();
		this._connection.ConnectionString = Settings.Default.AccountingDBConnectionString;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	public virtual int Insert(string Name, string Nation, long? ID, string Address, long? Phone, int? AccCode, string Role, decimal? Balance)
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
		if (Role == null)
		{
			this.Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			this.Adapter.InsertCommand.Parameters[7].Value = Role;
		}
		if (&Balance.HasValue)
		{
			this.Adapter.InsertCommand.Parameters[8].Value = &Balance.Value;
		}
		else
		{
			this.Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
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
	public virtual int Update(EmployeeDataTable dataTable)
	{
		return this.Adapter.Update(dataTable);
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(AccountingDS dataSet)
	{
		return this.Adapter.Update(dataSet, "Employee");
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

	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(int? EmployeeID, string Name, string Nation, long? ID, string Address, long? Phone, int? AccCode, int? oldAcc, string Role)
	{
		int num1;
		if (&EmployeeID.HasValue)
		{
			this.Adapter.UpdateCommand.Parameters[1].Value = &EmployeeID.Value;
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
		if (Role == null)
		{
			this.Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
		}
		else
		{
			this.Adapter.UpdateCommand.Parameters[9].Value = Role;
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