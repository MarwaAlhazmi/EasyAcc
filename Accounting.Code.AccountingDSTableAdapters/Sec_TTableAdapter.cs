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
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
[DesignerCategory("code")]
[ToolboxItem(true)]
[DataObject(true)]
public class Sec_TTableAdapter : Component
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
	public Sec_TTableAdapter()
	{
		this.ClearBeforeFill = true;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	public virtual int Delete(int Original_ID, string Original_Type, string Original_Value, string Original_Name)
	{
		int num1;
		this.Adapter.DeleteCommand.Parameters[0].Value = Original_ID;
		if (Original_Type == null)
		{
			throw new ArgumentNullException("Original_Type");
		}
		this.Adapter.DeleteCommand.Parameters[1].Value = Original_Type;
		if (Original_Value == null)
		{
			throw new ArgumentNullException("Original_Value");
		}
		this.Adapter.DeleteCommand.Parameters[2].Value = Original_Value;
		if (Original_Name == null)
		{
			throw new ArgumentNullException("Original_Name");
		}
		this.Adapter.DeleteCommand.Parameters[3].Value = Original_Name;
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

	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Fill(Sec_TDataTable dataTable)
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
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual Sec_TDataTable GetData()
	{
		this.Adapter.SelectCommand = this.CommandCollection[0];
		Sec_TDataTable secTDataTable = new Sec_TDataTable();
		this.Adapter.Fill(secTDataTable);
		return secTDataTable;
	}

	[DataObjectMethod(DataObjectMethodType.Select, false)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual Sec_TDataTable GetDataByValue(string type, string value)
	{
		this.Adapter.SelectCommand = this.CommandCollection[1];
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		this.Adapter.SelectCommand.Parameters[0].Value = type;
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		this.Adapter.SelectCommand.Parameters[1].Value = value;
		Sec_TDataTable secTDataTable = new Sec_TDataTable();
		this.Adapter.Fill(secTDataTable);
		return secTDataTable;
	}

	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		this._adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Sec_T";
		dataTableMapping.ColumnMappings.Add("ID", "ID");
		dataTableMapping.ColumnMappings.Add("Type", "Type");
		dataTableMapping.ColumnMappings.Add("Value", "Value");
		dataTableMapping.ColumnMappings.Add("Name", "Name");
		this._adapter.TableMappings.Add(dataTableMapping);
		this._adapter.DeleteCommand = new SqlCommand();
		this._adapter.DeleteCommand.Connection = this.Connection;
		this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[Sec_T] WHERE (([ID] = @Original_ID) AND ([Type] = @Original_Type) AND ([Value] = @Original_Value) AND ([Name] = @Original_Name))";
		this._adapter.DeleteCommand.CommandType = CommandType.Text;
		this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, false, null, "", "", ""));
		this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Type", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Type", DataRowVersion.Original, false, null, "", "", ""));
		this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Value", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Value", DataRowVersion.Original, false, null, "", "", ""));
		this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Name", DataRowVersion.Original, false, null, "", "", ""));
		this._adapter.InsertCommand = new SqlCommand();
		this._adapter.InsertCommand.Connection = this.Connection;
		this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Sec_T] ([Type], [Value], [Name]) VALUES (@Type, @Value, @Name);\r\nSELECT ID, Type, Value, Name FROM Sec_T WHERE (ID = SCOPE_IDENTITY())";
		this._adapter.InsertCommand.CommandType = CommandType.Text;
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Type", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Value", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Value", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Name", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand = new SqlCommand();
		this._adapter.UpdateCommand.Connection = this.Connection;
		this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[Sec_T] SET [Type] = @Type, [Value] = @Value, [Name] = @Name WHERE (([ID] = @Original_ID) AND ([Type] = @Original_Type) AND ([Value] = @Original_Value) AND ([Name] = @Original_Name));\r\nSELECT ID, Type, Value, Name FROM Sec_T WHERE (ID = @ID)";
		this._adapter.UpdateCommand.CommandType = CommandType.Text;
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Type", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Value", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Value", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Name", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Type", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Type", DataRowVersion.Original, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Value", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Value", DataRowVersion.Original, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Name", DataRowVersion.Original, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Current, false, null, "", "", ""));
	}

	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		this._commandCollection = new SqlCommand[2];
		this._commandCollection[0] = new SqlCommand();
		this._commandCollection[0].Connection = this.Connection;
		this._commandCollection[0].CommandText = "SELECT ID, Type, Value, Name FROM dbo.Sec_T";
		this._commandCollection[0].CommandType = CommandType.Text;
		this._commandCollection[1] = new SqlCommand();
		this._commandCollection[1].Connection = this.Connection;
		this._commandCollection[1].CommandText = "SELECT ID, Type, Value, Name FROM dbo.Sec_T where Type = @type and Value = @value";
		this._commandCollection[1].CommandType = CommandType.Text;
		this._commandCollection[1].Parameters.Add(new SqlParameter("@type", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, "Type", DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@value", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, "Value", DataRowVersion.Current, false, null, "", "", ""));
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
	public virtual int Insert(string Type, string Value, string Name)
	{
		int num1;
		if (Type == null)
		{
			throw new ArgumentNullException("Type");
		}
		this.Adapter.InsertCommand.Parameters[0].Value = Type;
		if (Value == null)
		{
			throw new ArgumentNullException("Value");
		}
		this.Adapter.InsertCommand.Parameters[1].Value = Value;
		if (Name == null)
		{
			throw new ArgumentNullException("Name");
		}
		this.Adapter.InsertCommand.Parameters[2].Value = Name;
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
	public virtual int Update(Sec_TDataTable dataTable)
	{
		return this.Adapter.Update(dataTable);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Update(AccountingDS dataSet)
	{
		return this.Adapter.Update(dataSet, "Sec_T");
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

	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Update(string Type, string Value, string Name, int Original_ID, string Original_Type, string Original_Value, string Original_Name, int ID)
	{
		int num1;
		if (Type == null)
		{
			throw new ArgumentNullException("Type");
		}
		this.Adapter.UpdateCommand.Parameters[0].Value = Type;
		if (Value == null)
		{
			throw new ArgumentNullException("Value");
		}
		this.Adapter.UpdateCommand.Parameters[1].Value = Value;
		if (Name == null)
		{
			throw new ArgumentNullException("Name");
		}
		this.Adapter.UpdateCommand.Parameters[2].Value = Name;
		this.Adapter.UpdateCommand.Parameters[3].Value = Original_ID;
		if (Original_Type == null)
		{
			throw new ArgumentNullException("Original_Type");
		}
		this.Adapter.UpdateCommand.Parameters[4].Value = Original_Type;
		if (Original_Value == null)
		{
			throw new ArgumentNullException("Original_Value");
		}
		this.Adapter.UpdateCommand.Parameters[5].Value = Original_Value;
		if (Original_Name == null)
		{
			throw new ArgumentNullException("Original_Name");
		}
		this.Adapter.UpdateCommand.Parameters[6].Value = Original_Name;
		this.Adapter.UpdateCommand.Parameters[7].Value = ID;
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

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[DebuggerNonUserCode]
	public virtual int Update(string Type, string Value, string Name, int Original_ID, string Original_Type, string Original_Value, string Original_Name)
	{
		return this.Update(Type, Value, Name, Original_ID, Original_Type, Original_Value, Original_Name, Original_ID);
	}
}
}