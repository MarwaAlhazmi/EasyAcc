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
[DesignerCategory("code")]
[ToolboxItem(true)]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
public class COA_TTableAdapter : Component
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
	public COA_TTableAdapter()
	{
		this.ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int addFixedAsset(int? id, string name, int? category, decimal? balance, int? parent, int? depCode)
	{
		int num;
		SqlCommand commandCollection = this.CommandCollection[1];
		if (&id.HasValue)
		{
			commandCollection.Parameters[1].Value = &id.Value;
		}
		else
		{
			commandCollection.Parameters[1].Value = DBNull.Value;
		}
		if (name == null)
		{
			commandCollection.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			commandCollection.Parameters[2].Value = name;
		}
		if (&category.HasValue)
		{
			commandCollection.Parameters[3].Value = &category.Value;
		}
		else
		{
			commandCollection.Parameters[3].Value = DBNull.Value;
		}
		if (&balance.HasValue)
		{
			commandCollection.Parameters[4].Value = &balance.Value;
		}
		else
		{
			commandCollection.Parameters[4].Value = DBNull.Value;
		}
		if (&parent.HasValue)
		{
			commandCollection.Parameters[5].Value = &parent.Value;
		}
		else
		{
			commandCollection.Parameters[5].Value = DBNull.Value;
		}
		if (&depCode.HasValue)
		{
			commandCollection.Parameters[6].Value = &depCode.Value;
		}
		else
		{
			commandCollection.Parameters[6].Value = DBNull.Value;
		}
		ConnectionState state = commandCollection.Connection.State;
		if ((commandCollection.Connection.State & 1) != 1)
		{
			commandCollection.Connection.Open();
		}
		try
		{
			num = commandCollection.ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				commandCollection.Connection.Close();
			}
		}
		return num;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual object CategoryMax(int category)
	{
		object obj;
		SqlCommand commandCollection = this.CommandCollection[2];
		commandCollection.Parameters[0].Value = category;
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
		return obj;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	public virtual int Delete(int Original_GL_ID)
	{
		int num1;
		this.Adapter.DeleteCommand.Parameters[0].Value = Original_GL_ID;
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
	[DebuggerNonUserCode]
	public virtual int deleteBank(int? accCode)
	{
		int num;
		SqlCommand commandCollection = this.CommandCollection[3];
		if (&accCode.HasValue)
		{
			commandCollection.Parameters[1].Value = &accCode.Value;
		}
		else
		{
			commandCollection.Parameters[1].Value = DBNull.Value;
		}
		ConnectionState state = commandCollection.Connection.State;
		if ((commandCollection.Connection.State & 1) != 1)
		{
			commandCollection.Connection.Open();
		}
		try
		{
			num = commandCollection.ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				commandCollection.Connection.Close();
			}
		}
		return num;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[DebuggerNonUserCode]
	public virtual int Fill(COA_TDataTable dataTable)
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
	public virtual decimal? getBalance(int id)
	{
		object obj;
		SqlCommand commandCollection = this.CommandCollection[4];
		commandCollection.Parameters[0].Value = id;
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
			decimal? nullable = null;
			return nullable;
		}
		return new decimal?((decimal)obj);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int? getCategory(int account)
	{
		object obj;
		SqlCommand commandCollection = this.CommandCollection[5];
		commandCollection.Parameters[0].Value = account;
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
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual COA_TDataTable GetData()
	{
		this.Adapter.SelectCommand = this.CommandCollection[0];
		COA_TDataTable cOATDataTable = new COA_TDataTable();
		this.Adapter.Fill(cOATDataTable);
		return cOATDataTable;
	}

	[DataObjectMethod(DataObjectMethodType.Select, false)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual COA_TDataTable GetDataByID(int id)
	{
		this.Adapter.SelectCommand = this.CommandCollection[6];
		this.Adapter.SelectCommand.Parameters[0].Value = id;
		COA_TDataTable cOATDataTable = new COA_TDataTable();
		this.Adapter.Fill(cOATDataTable);
		return cOATDataTable;
	}

	[DataObjectMethod(DataObjectMethodType.Select, false)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual COA_TDataTable GetMainAccounts()
	{
		this.Adapter.SelectCommand = this.CommandCollection[7];
		COA_TDataTable cOATDataTable = new COA_TDataTable();
		this.Adapter.Fill(cOATDataTable);
		return cOATDataTable;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int? getParent(int account)
	{
		object obj;
		SqlCommand commandCollection = this.CommandCollection[8];
		commandCollection.Parameters[0].Value = account;
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
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual COA_TDataTable getSubAccounts(int? parent)
	{
		this.Adapter.SelectCommand = this.CommandCollection[9];
		if (&parent.HasValue)
		{
			this.Adapter.SelectCommand.Parameters[0].Value = &parent.Value;
		}
		else
		{
			this.Adapter.SelectCommand.Parameters[0].Value = DBNull.Value;
		}
		COA_TDataTable cOATDataTable = new COA_TDataTable();
		this.Adapter.Fill(cOATDataTable);
		return cOATDataTable;
	}

	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		this._adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "COA_T";
		dataTableMapping.ColumnMappings.Add("GL_ID", "GL_ID");
		dataTableMapping.ColumnMappings.Add("GL_Name_VC", "GL_Name_VC");
		dataTableMapping.ColumnMappings.Add("BS_Category_VC", "BS_Category_VC");
		dataTableMapping.ColumnMappings.Add("Status_BT", "Status_BT");
		dataTableMapping.ColumnMappings.Add("Balance", "Balance");
		dataTableMapping.ColumnMappings.Add("ParentAcc", "ParentAcc");
		this._adapter.TableMappings.Add(dataTableMapping);
		this._adapter.DeleteCommand = new SqlCommand();
		this._adapter.DeleteCommand.Connection = this.Connection;
		this._adapter.DeleteCommand.CommandText = "DELETE FROM COA_T\r\nWHERE        (GL_ID = @Original_GL_ID)";
		this._adapter.DeleteCommand.CommandType = CommandType.Text;
		this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GL_ID", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "GL_ID", DataRowVersion.Original, false, null, "", "", ""));
		this._adapter.InsertCommand = new SqlCommand();
		this._adapter.InsertCommand.Connection = this.Connection;
		this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[COA_T] ([GL_ID], [GL_Name_VC], [BS_Category_VC], [Status_BT], [Balance], [ParentAcc]) VALUES (@GL_ID, @GL_Name_VC, @BS_Category_VC, @Status_BT, @Balance, @ParentAcc);\r\nSELECT GL_ID, GL_Name_VC, BS_Category_VC, Status_BT, Balance, ParentAcc FROM COA_T WHERE (GL_ID = @GL_ID)";
		this._adapter.InsertCommand.CommandType = CommandType.Text;
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GL_ID", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "GL_ID", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GL_Name_VC", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "GL_Name_VC", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BS_Category_VC", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "BS_Category_VC", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Status_BT", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "Status_BT", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Balance", SqlDbType.Money, 0, ParameterDirection.Input, 0, 0, "Balance", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ParentAcc", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "ParentAcc", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand = new SqlCommand();
		this._adapter.UpdateCommand.Connection = this.Connection;
		this._adapter.UpdateCommand.CommandText = "UPDATE       COA_T\r\nSET                GL_ID = @GL_ID, GL_Name_VC = @GL_Name_VC, BS_Category_VC = @BS_Category_VC, Status_BT = @Status_BT, Balance = @Balance, \r\n                         ParentAcc = @ParentAcc\r\nWHERE        (GL_ID = @Original_GL_ID); \r\nSELECT GL_ID, GL_Name_VC, BS_Category_VC, Status_BT, Balance, ParentAcc FROM COA_T WHERE (GL_ID = @GL_ID)";
		this._adapter.UpdateCommand.CommandType = CommandType.Text;
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GL_ID", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "GL_ID", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GL_Name_VC", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, "GL_Name_VC", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BS_Category_VC", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "BS_Category_VC", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Status_BT", SqlDbType.Bit, 1, ParameterDirection.Input, 0, 0, "Status_BT", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Balance", SqlDbType.Money, 8, ParameterDirection.Input, 0, 0, "Balance", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ParentAcc", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "ParentAcc", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GL_ID", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "GL_ID", DataRowVersion.Original, false, null, "", "", ""));
	}

	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		this._commandCollection = new SqlCommand[12];
		this._commandCollection[0] = new SqlCommand();
		this._commandCollection[0].Connection = this.Connection;
		this._commandCollection[0].CommandText = "SELECT        GL_ID, GL_Name_VC, BS_Category_VC, Status_BT, Balance, ParentAcc\r\nFROM            COA_T\r\nWHERE        (GL_ID <> 0)";
		this._commandCollection[0].CommandType = CommandType.Text;
		this._commandCollection[1] = new SqlCommand();
		this._commandCollection[1].Connection = this.Connection;
		this._commandCollection[1].CommandText = "dbo.addFixedAsset";
		this._commandCollection[1].CommandType = CommandType.StoredProcedure;
		this._commandCollection[1].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@category", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@balance", SqlDbType.Money, 8, ParameterDirection.Input, 19, 4, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@parent", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@depCode", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[2] = new SqlCommand();
		this._commandCollection[2].Connection = this.Connection;
		this._commandCollection[2].CommandText = "SELECT        MAX(GL_ID) AS id\r\nFROM            COA_T\r\nWHERE        (BS_Category_VC = @category) AND (ParentAcc = 0)";
		this._commandCollection[2].CommandType = CommandType.Text;
		this._commandCollection[2].Parameters.Add(new SqlParameter("@category", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "BS_Category_VC", DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[3] = new SqlCommand();
		this._commandCollection[3].Connection = this.Connection;
		this._commandCollection[3].CommandText = "dbo.deleteBank";
		this._commandCollection[3].CommandType = CommandType.StoredProcedure;
		this._commandCollection[3].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[3].Parameters.Add(new SqlParameter("@accCode", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4] = new SqlCommand();
		this._commandCollection[4].Connection = this.Connection;
		this._commandCollection[4].CommandText = "SELECT        Balance\r\nFROM            COA_T\r\nWHERE        (GL_ID = @id)";
		this._commandCollection[4].CommandType = CommandType.Text;
		this._commandCollection[4].Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "GL_ID", DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[5] = new SqlCommand();
		this._commandCollection[5].Connection = this.Connection;
		this._commandCollection[5].CommandText = "select BS_Category_VC\r\nfrom COA_T\r\nwhere GL_ID = @account";
		this._commandCollection[5].CommandType = CommandType.Text;
		this._commandCollection[5].Parameters.Add(new SqlParameter("@account", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "GL_ID", DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[6] = new SqlCommand();
		this._commandCollection[6].Connection = this.Connection;
		this._commandCollection[6].CommandText = "SELECT BS_Category_VC, Balance, GL_ID, GL_Name_VC, ParentAcc, Status_BT FROM COA_T WHERE (GL_ID = @id)";
		this._commandCollection[6].CommandType = CommandType.Text;
		this._commandCollection[6].Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "GL_ID", DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[7] = new SqlCommand();
		this._commandCollection[7].Connection = this.Connection;
		this._commandCollection[7].CommandText = "SELECT        GL_ID, GL_Name_VC, BS_Category_VC, Status_BT, Balance, ParentAcc\r\nFROM            COA_T\r\nWHERE        (ParentAcc = 0) AND (GL_ID <> 0)";
		this._commandCollection[7].CommandType = CommandType.Text;
		this._commandCollection[8] = new SqlCommand();
		this._commandCollection[8].Connection = this.Connection;
		this._commandCollection[8].CommandText = "select ParentAcc\r\nFrom COA_T \r\nwhere GL_ID = @account";
		this._commandCollection[8].CommandType = CommandType.Text;
		this._commandCollection[8].Parameters.Add(new SqlParameter("@account", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "GL_ID", DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[9] = new SqlCommand();
		this._commandCollection[9].Connection = this.Connection;
		this._commandCollection[9].CommandText = "SELECT        GL_ID, GL_Name_VC, BS_Category_VC, Status_BT, Balance, ParentAcc\r\nFROM            COA_T\r\nWHERE        (ParentAcc = @parent)";
		this._commandCollection[9].CommandType = CommandType.Text;
		this._commandCollection[9].Parameters.Add(new SqlParameter("@parent", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "ParentAcc", DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[10] = new SqlCommand();
		this._commandCollection[10].Connection = this.Connection;
		this._commandCollection[10].CommandText = "SELECT        MAX(GL_ID) AS id\r\nFROM            COA_T\r\nWHERE        (ParentAcc = @parent)";
		this._commandCollection[10].CommandType = CommandType.Text;
		this._commandCollection[10].Parameters.Add(new SqlParameter("@parent", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "ParentAcc", DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[11] = new SqlCommand();
		this._commandCollection[11].Connection = this.Connection;
		this._commandCollection[11].CommandText = "dbo.updateFixedAsset";
		this._commandCollection[11].CommandType = CommandType.StoredProcedure;
		this._commandCollection[11].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[11].Parameters.Add(new SqlParameter("@accCode", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[11].Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
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
	public virtual int Insert(int GL_ID, string GL_Name_VC, int BS_Category_VC, bool Status_BT, decimal Balance, int? ParentAcc)
	{
		int num1;
		this.Adapter.InsertCommand.Parameters[0].Value = GL_ID;
		if (GL_Name_VC == null)
		{
			throw new ArgumentNullException("GL_Name_VC");
		}
		this.Adapter.InsertCommand.Parameters[1].Value = GL_Name_VC;
		this.Adapter.InsertCommand.Parameters[2].Value = BS_Category_VC;
		this.Adapter.InsertCommand.Parameters[3].Value = Status_BT;
		this.Adapter.InsertCommand.Parameters[4].Value = Balance;
		if (&ParentAcc.HasValue)
		{
			this.Adapter.InsertCommand.Parameters[5].Value = &ParentAcc.Value;
		}
		else
		{
			this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
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
	public virtual int? ParentMax(int? parent)
	{
		object obj;
		SqlCommand commandCollection = this.CommandCollection[10];
		if (&parent.HasValue)
		{
			commandCollection.Parameters[0].Value = &parent.Value;
		}
		else
		{
			commandCollection.Parameters[0].Value = DBNull.Value;
		}
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
	public virtual int Update(COA_TDataTable dataTable)
	{
		return this.Adapter.Update(dataTable);
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(AccountingDS dataSet)
	{
		return this.Adapter.Update(dataSet, "COA_T");
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

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int Update(int GL_ID, string GL_Name_VC, int BS_Category_VC, bool Status_BT, decimal Balance, int? ParentAcc, int Original_GL_ID)
	{
		int num1;
		this.Adapter.UpdateCommand.Parameters[0].Value = GL_ID;
		if (GL_Name_VC == null)
		{
			throw new ArgumentNullException("GL_Name_VC");
		}
		this.Adapter.UpdateCommand.Parameters[1].Value = GL_Name_VC;
		this.Adapter.UpdateCommand.Parameters[2].Value = BS_Category_VC;
		this.Adapter.UpdateCommand.Parameters[3].Value = Status_BT;
		this.Adapter.UpdateCommand.Parameters[4].Value = Balance;
		if (&ParentAcc.HasValue)
		{
			this.Adapter.UpdateCommand.Parameters[5].Value = &ParentAcc.Value;
		}
		else
		{
			this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
		}
		this.Adapter.UpdateCommand.Parameters[6].Value = Original_GL_ID;
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

	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(string GL_Name_VC, int BS_Category_VC, bool Status_BT, decimal Balance, int? ParentAcc, int Original_GL_ID)
	{
		return this.Update(Original_GL_ID, GL_Name_VC, BS_Category_VC, Status_BT, Balance, ParentAcc, Original_GL_ID);
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int updateFixedAsset(int? accCode, string name)
	{
		int num;
		SqlCommand commandCollection = this.CommandCollection[11];
		if (&accCode.HasValue)
		{
			commandCollection.Parameters[1].Value = &accCode.Value;
		}
		else
		{
			commandCollection.Parameters[1].Value = DBNull.Value;
		}
		if (name == null)
		{
			commandCollection.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			commandCollection.Parameters[2].Value = name;
		}
		ConnectionState state = commandCollection.Connection.State;
		if ((commandCollection.Connection.State & 1) != 1)
		{
			commandCollection.Connection.Open();
		}
		try
		{
			num = commandCollection.ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				commandCollection.Connection.Close();
			}
		}
		return num;
	}
}
}