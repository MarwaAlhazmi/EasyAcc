using System.ComponentModel;
using System.CodeDom.Compiler;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System;
using System.Diagnostics;
using System.Data;
using System.Data.Common;
using Accounting.Properties;

namespace Accounting.Code.AccountingDSTableAdapters
{
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[ToolboxItem(true)]
[DataObject(true)]
public class ReportTableAdapter : Component
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
	public ReportTableAdapter()
	{
		this.ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual object getAmountSum(DateTime? dateFrom, DateTime? dateTo, int? account)
	{
		object obj;
		SqlCommand commandCollection = this.CommandCollection[1];
		if (&dateFrom.HasValue)
		{
			commandCollection.Parameters[1].Value = &dateFrom.Value;
		}
		else
		{
			commandCollection.Parameters[1].Value = DBNull.Value;
		}
		if (&dateTo.HasValue)
		{
			commandCollection.Parameters[2].Value = &dateTo.Value;
		}
		else
		{
			commandCollection.Parameters[2].Value = DBNull.Value;
		}
		if (&account.HasValue)
		{
			commandCollection.Parameters[3].Value = &account.Value;
		}
		else
		{
			commandCollection.Parameters[3].Value = DBNull.Value;
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
			return null;
		}
		return obj;
	}

	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual ReportDataTable getJournalByCodeDate(DateTime? dateFrom, DateTime? dateTo, int? account)
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
		if (&account.HasValue)
		{
			this.Adapter.SelectCommand.Parameters[3].Value = &account.Value;
		}
		else
		{
			this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
		}
		ReportDataTable reportDataTable = new ReportDataTable();
		this.Adapter.Fill(reportDataTable);
		return reportDataTable;
	}

	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		this._adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Report";
		dataTableMapping.ColumnMappings.Add("code", "code");
		dataTableMapping.ColumnMappings.Add("Account", "Account");
		dataTableMapping.ColumnMappings.Add("Debit", "Debit");
		dataTableMapping.ColumnMappings.Add("Credit", "Credit");
		dataTableMapping.ColumnMappings.Add("Descrip_VC", "Descrip_VC");
		dataTableMapping.ColumnMappings.Add("Date_DT", "Date_DT");
		dataTableMapping.ColumnMappings.Add("Balance", "Balance");
		this._adapter.TableMappings.Add(dataTableMapping);
	}

	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		this._commandCollection = new SqlCommand[2];
		this._commandCollection[0] = new SqlCommand();
		this._commandCollection[0].Connection = this.Connection;
		this._commandCollection[0].CommandText = "dbo.JournalByCodeDateReport";
		this._commandCollection[0].CommandType = CommandType.StoredProcedure;
		this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[0].Parameters.Add(new SqlParameter("@dateFrom", SqlDbType.Date, 3, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[0].Parameters.Add(new SqlParameter("@dateTo", SqlDbType.Date, 3, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[0].Parameters.Add(new SqlParameter("@account", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1] = new SqlCommand();
		this._commandCollection[1].Connection = this.Connection;
		this._commandCollection[1].CommandText = "dbo.getAmountSum";
		this._commandCollection[1].CommandType = CommandType.StoredProcedure;
		this._commandCollection[1].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@dateFrom", SqlDbType.Date, 3, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@dateTo", SqlDbType.Date, 3, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@account", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
	}

	[DebuggerNonUserCode]
	private void InitConnection()
	{
		this._connection = new SqlConnection();
		this._connection.ConnectionString = Settings.Default.AccountingDBConnectionString;
	}
}
}