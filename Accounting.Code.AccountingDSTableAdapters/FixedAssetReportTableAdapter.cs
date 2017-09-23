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
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[ToolboxItem(true)]
[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class FixedAssetReportTableAdapter : Component
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
	public FixedAssetReportTableAdapter()
	{
		this.ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Fill(FixedAssetReportDataTable dataTable, DateTime? dateFrom, DateTime? dateTo)
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

	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual FixedAssetReportDataTable GetData(DateTime? dateFrom, DateTime? dateTo)
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
		FixedAssetReportDataTable fixedAssetReportDataTable = new FixedAssetReportDataTable();
		this.Adapter.Fill(fixedAssetReportDataTable);
		return fixedAssetReportDataTable;
	}

	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		this._adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "FixedAssetReport";
		dataTableMapping.ColumnMappings.Add("desc", "desc");
		dataTableMapping.ColumnMappings.Add("lastYearBalance", "lastYearBalance");
		dataTableMapping.ColumnMappings.Add("yearDebit", "yearDebit");
		dataTableMapping.ColumnMappings.Add("yearCredit", "yearCredit");
		dataTableMapping.ColumnMappings.Add("yearBalance", "yearBalance");
		dataTableMapping.ColumnMappings.Add("lastAccDep", "lastAccDep");
		dataTableMapping.ColumnMappings.Add("yearDep", "yearDep");
		dataTableMapping.ColumnMappings.Add("AccDep", "AccDep");
		dataTableMapping.ColumnMappings.Add("total", "total");
		this._adapter.TableMappings.Add(dataTableMapping);
	}

	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		this._commandCollection = new SqlCommand[1];
		this._commandCollection[0] = new SqlCommand();
		this._commandCollection[0].Connection = this.Connection;
		this._commandCollection[0].CommandText = "dbo.FixedAssetReport";
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