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
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapter")]
[DesignerCategory("code")]
[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
public class CategoryTableAdapter : Component
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
	public CategoryTableAdapter()
	{
		this.ClearBeforeFill = true;
	}

	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Delete(int Original_Category_ID)
	{
		int num1;
		this.Adapter.DeleteCommand.Parameters[0].Value = Original_Category_ID;
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
	public virtual int Fill(CategoryDataTable dataTable)
	{
		this.Adapter.SelectCommand = this.CommandCollection[0];
		if (this.ClearBeforeFill)
		{
			dataTable.Clear();
		}
		int num = this.Adapter.Fill(dataTable);
		return num;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual CategoryDataTable GetData()
	{
		this.Adapter.SelectCommand = this.CommandCollection[0];
		CategoryDataTable categoryDataTable = new CategoryDataTable();
		this.Adapter.Fill(categoryDataTable);
		return categoryDataTable;
	}

	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		this._adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Category";
		dataTableMapping.ColumnMappings.Add("Category_ID", "Category_ID");
		dataTableMapping.ColumnMappings.Add("Category_Name", "Category_Name");
		this._adapter.TableMappings.Add(dataTableMapping);
		this._adapter.DeleteCommand = new SqlCommand();
		this._adapter.DeleteCommand.Connection = this.Connection;
		this._adapter.DeleteCommand.CommandText = "DELETE FROM Category\r\nWHERE        (Category_ID = @Original_Category_ID)";
		this._adapter.DeleteCommand.CommandType = CommandType.Text;
		this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Category_ID", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Category_ID", DataRowVersion.Original, false, null, "", "", ""));
		this._adapter.InsertCommand = new SqlCommand();
		this._adapter.InsertCommand.Connection = this.Connection;
		this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Category] ([Category_ID], [Category_Name]) VALUES (@Category_ID, @Category_Name);\r\nSELECT Category_ID, Category_Name FROM Category WHERE (Category_ID = @Category_ID)";
		this._adapter.InsertCommand.CommandType = CommandType.Text;
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Category_ID", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Category_ID", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Category_Name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Category_Name", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand = new SqlCommand();
		this._adapter.UpdateCommand.Connection = this.Connection;
		this._adapter.UpdateCommand.CommandText = "UPDATE       Category\r\nSET                Category_ID = @Category_ID, Category_Name = @Category_Name\r\nWHERE        (Category_ID = @Original_Category_ID); \r\nSELECT Category_ID, Category_Name FROM Category WHERE (Category_ID = @Category_ID)";
		this._adapter.UpdateCommand.CommandType = CommandType.Text;
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Category_ID", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Category_ID", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Category_Name", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, "Category_Name", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Category_ID", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Category_ID", DataRowVersion.Original, false, null, "", "", ""));
	}

	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		this._commandCollection = new SqlCommand[1];
		this._commandCollection[0] = new SqlCommand();
		this._commandCollection[0].Connection = this.Connection;
		this._commandCollection[0].CommandText = "SELECT        Category_ID, Category_Name\r\nFROM            Category\r\nWHERE        (Category_ID <> 0)";
		this._commandCollection[0].CommandType = CommandType.Text;
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
	public virtual int Insert(int Category_ID, string Category_Name)
	{
		int num1;
		this.Adapter.InsertCommand.Parameters[0].Value = Category_ID;
		if (Category_Name == null)
		{
			throw new ArgumentNullException("Category_Name");
		}
		this.Adapter.InsertCommand.Parameters[1].Value = Category_Name;
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
	public virtual int Update(CategoryDataTable dataTable)
	{
		return this.Adapter.Update(dataTable);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Update(AccountingDS dataSet)
	{
		return this.Adapter.Update(dataSet, "Category");
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
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[DebuggerNonUserCode]
	public virtual int Update(int Category_ID, string Category_Name, int Original_Category_ID)
	{
		int num1;
		this.Adapter.UpdateCommand.Parameters[0].Value = Category_ID;
		if (Category_Name == null)
		{
			throw new ArgumentNullException("Category_Name");
		}
		this.Adapter.UpdateCommand.Parameters[1].Value = Category_Name;
		this.Adapter.UpdateCommand.Parameters[2].Value = Original_Category_ID;
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
	public virtual int Update(string Category_Name, int Original_Category_ID)
	{
		return this.Update(Original_Category_ID, Category_Name, Original_Category_ID);
	}
}
}