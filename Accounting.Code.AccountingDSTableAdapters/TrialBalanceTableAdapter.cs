using System.ComponentModel;
using System.ComponentModel.Design;
using System.CodeDom.Compiler;
using System.Data.SqlClient;
using System;
using System.Diagnostics;
using System.Data.Common;
using System.Data;
using Accounting.Properties;

namespace Accounting.Code.AccountingDSTableAdapters
{
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
[DesignerCategory("code")]
[ToolboxItem(true)]
[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
public class TrialBalanceTableAdapter : Component
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
	public TrialBalanceTableAdapter()
	{
		this.ClearBeforeFill = true;
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Fill(TrialBalanceDataTable dataTable, DateTime? dateFrom, DateTime? dateTo)
	{
		this.Adapter.SelectCommand = this.CommandCollection[0];
		if (&dateFrom.HasValue)
		{
			this.Adapter.SelectCommand.Parameters[1].Value = &dateFrom.Value;
		}
		else
		{
			this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
		}
		if (&dateTo.HasValue)
		{
			this.Adapter.SelectCommand.Parameters[2].Value = &dateTo.Value;
		}
		else
		{
			this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
		}
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
	public virtual TrialBalanceDataTable GetData(DateTime? dateFrom, DateTime? dateTo)
	{
		this.Adapter.SelectCommand = this.CommandCollection[0];
		if (&dateFrom.HasValue)
		{
			this.Adapter.SelectCommand.Parameters[1].Value = &dateFrom.Value;
		}
		else
		{
			this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
		}
		if (&dateTo.HasValue)
		{
			this.Adapter.SelectCommand.Parameters[2].Value = &dateTo.Value;
		}
		else
		{
			this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
		}
		TrialBalanceDataTable trialBalanceDataTable = new TrialBalanceDataTable();
		this.Adapter.Fill(trialBalanceDataTable);
		return trialBalanceDataTable;
	}

	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		this._adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "TrialBalance";
		dataTableMapping.ColumnMappings.Add("GL_Name_VC", "GL_Name_VC");
		dataTableMapping.ColumnMappings.Add("GL_ID", "GL_ID");
		dataTableMapping.ColumnMappings.Add("Category_Name", "Category_Name");
		dataTableMapping.ColumnMappings.Add("BS_Category_VC", "BS_Category_VC");
		dataTableMapping.ColumnMappings.Add("PreDebit", "PreDebit");
		dataTableMapping.ColumnMappings.Add("PreCredit", "PreCredit");
		dataTableMapping.ColumnMappings.Add("Debit", "Debit");
		dataTableMapping.ColumnMappings.Add("Credit", "Credit");
		dataTableMapping.ColumnMappings.Add("CurrDebit", "CurrDebit");
		dataTableMapping.ColumnMappings.Add("CurrCredit", "CurrCredit");
		this._adapter.TableMappings.Add(dataTableMapping);
	}

	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		this._commandCollection = new SqlCommand[1];
		this._commandCollection[0] = new SqlCommand();
		this._commandCollection[0].Connection = this.Connection;
		this._commandCollection[0].CommandText = "dbo.trialBalance";
		this._commandCollection[0].CommandType = CommandType.StoredProcedure;
		this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[0].Parameters.Add(new SqlParameter("@dateFrom", SqlDbType.Date, 3, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[0].Parameters.Add(new SqlParameter("@dateTo", SqlDbType.Date, 3, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
	}

	[DebuggerNonUserCode]
	private void InitConnection()
	{
		this._connection = new SqlConnection();
		this._connection.ConnectionString = Settings.Default.AccountingDBConnectionString;
	}
}
}