using System.ComponentModel;
using System.CodeDom.Compiler;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System;
using System.Diagnostics;
using System.Data.Common;
using System.Data;
using Accounting.Properties;

namespace Accounting.Code.AccountingDSTableAdapters
{
[DataObject(true)]
[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
[HelpKeyword("vs.data.TableAdapter")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItem(true)]
[DesignerCategory("code")]
public class DailyJournalTableAdapter : Component
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
	public DailyJournalTableAdapter()
	{
		this.ClearBeforeFill = true;
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Fill(DailyJournalDataTable dataTable, DateTime? date)
	{
		this.Adapter.SelectCommand = this.CommandCollection[0];
		if (&date.HasValue)
		{
			this.Adapter.SelectCommand.Parameters[1].Value = &date.Value;
		}
		else
		{
			this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
		}
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
	public virtual DailyJournalDataTable GetDataByDate(DateTime? date)
	{
		this.Adapter.SelectCommand = this.CommandCollection[0];
		if (&date.HasValue)
		{
			this.Adapter.SelectCommand.Parameters[1].Value = &date.Value;
		}
		else
		{
			this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
		}
		DailyJournalDataTable dailyJournalDataTable = new DailyJournalDataTable();
		this.Adapter.Fill(dailyJournalDataTable);
		return dailyJournalDataTable;
	}

	[DataObjectMethod(DataObjectMethodType.Select, false)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual DailyJournalDataTable GetJournalByCode(int? code)
	{
		this.Adapter.SelectCommand = this.CommandCollection[1];
		if (&code.HasValue)
		{
			this.Adapter.SelectCommand.Parameters[1].Value = &code.Value;
		}
		else
		{
			this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
		}
		DailyJournalDataTable dailyJournalDataTable = new DailyJournalDataTable();
		this.Adapter.Fill(dailyJournalDataTable);
		return dailyJournalDataTable;
	}

	[DataObjectMethod(DataObjectMethodType.Select, false)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual DailyJournalDataTable getJournalFromTo(DateTime? fromDate, DateTime? toDate)
	{
		this.Adapter.SelectCommand = this.CommandCollection[2];
		if (&fromDate.HasValue)
		{
			this.Adapter.SelectCommand.Parameters[1].Value = &fromDate.Value;
		}
		else
		{
			this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
		}
		if (&toDate.HasValue)
		{
			this.Adapter.SelectCommand.Parameters[2].Value = &toDate.Value;
		}
		else
		{
			this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
		}
		DailyJournalDataTable dailyJournalDataTable = new DailyJournalDataTable();
		this.Adapter.Fill(dailyJournalDataTable);
		return dailyJournalDataTable;
	}

	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		this._adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "DailyJournal";
		dataTableMapping.ColumnMappings.Add("code", "code");
		dataTableMapping.ColumnMappings.Add("Account", "Account");
		dataTableMapping.ColumnMappings.Add("Debit", "Debit");
		dataTableMapping.ColumnMappings.Add("Credit", "Credit");
		dataTableMapping.ColumnMappings.Add("Descrip_VC", "Descrip_VC");
		dataTableMapping.ColumnMappings.Add("Date_DT", "Date_DT");
		this._adapter.TableMappings.Add(dataTableMapping);
	}

	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		this._commandCollection = new SqlCommand[7];
		this._commandCollection[0] = new SqlCommand();
		this._commandCollection[0].Connection = this.Connection;
		this._commandCollection[0].CommandText = "dbo.getJournalByDate";
		this._commandCollection[0].CommandType = CommandType.StoredProcedure;
		this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[0].Parameters.Add(new SqlParameter("@date", SqlDbType.DateTime, 8, ParameterDirection.Input, 23, 3, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1] = new SqlCommand();
		this._commandCollection[1].Connection = this.Connection;
		this._commandCollection[1].CommandText = "dbo.GetJournalByCode";
		this._commandCollection[1].CommandType = CommandType.StoredProcedure;
		this._commandCollection[1].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@code", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[2] = new SqlCommand();
		this._commandCollection[2].Connection = this.Connection;
		this._commandCollection[2].CommandText = "dbo.getJournalFromTo";
		this._commandCollection[2].CommandType = CommandType.StoredProcedure;
		this._commandCollection[2].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[2].Parameters.Add(new SqlParameter("@fromDate", SqlDbType.Date, 3, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[2].Parameters.Add(new SqlParameter("@toDate", SqlDbType.Date, 3, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[3] = new SqlCommand();
		this._commandCollection[3].Connection = this.Connection;
		this._commandCollection[3].CommandText = "dbo.insertFixedAssetJournal";
		this._commandCollection[3].CommandType = CommandType.StoredProcedure;
		this._commandCollection[3].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[3].Parameters.Add(new SqlParameter("@doc_No", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[3].Parameters.Add(new SqlParameter("@account", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[3].Parameters.Add(new SqlParameter("@amount", SqlDbType.Money, 8, ParameterDirection.Input, 19, 4, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[3].Parameters.Add(new SqlParameter("@desc", SqlDbType.NVarChar, 200, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[3].Parameters.Add(new SqlParameter("@date", SqlDbType.DateTime, 8, ParameterDirection.Input, 23, 3, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[3].Parameters.Add(new SqlParameter("@period", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[3].Parameters.Add(new SqlParameter("@year", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4] = new SqlCommand();
		this._commandCollection[4].Connection = this.Connection;
		this._commandCollection[4].CommandText = "dbo.insertJournal";
		this._commandCollection[4].CommandType = CommandType.StoredProcedure;
		this._commandCollection[4].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4].Parameters.Add(new SqlParameter("@doc_No", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4].Parameters.Add(new SqlParameter("@account", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4].Parameters.Add(new SqlParameter("@amount", SqlDbType.Money, 8, ParameterDirection.Input, 19, 4, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4].Parameters.Add(new SqlParameter("@desc", SqlDbType.NVarChar, 200, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4].Parameters.Add(new SqlParameter("@date", SqlDbType.DateTime, 8, ParameterDirection.Input, 23, 3, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4].Parameters.Add(new SqlParameter("@period", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4].Parameters.Add(new SqlParameter("@year", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[5] = new SqlCommand();
		this._commandCollection[5].Connection = this.Connection;
		this._commandCollection[5].CommandText = "dbo.updateFixedAssetsJournal";
		this._commandCollection[5].CommandType = CommandType.StoredProcedure;
		this._commandCollection[5].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[5].Parameters.Add(new SqlParameter("@code", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[5].Parameters.Add(new SqlParameter("@oldCode", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[5].Parameters.Add(new SqlParameter("@account", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[5].Parameters.Add(new SqlParameter("@oldAccount", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[5].Parameters.Add(new SqlParameter("@amount", SqlDbType.Money, 8, ParameterDirection.Input, 19, 4, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[5].Parameters.Add(new SqlParameter("@oldAmount", SqlDbType.Money, 8, ParameterDirection.Input, 19, 4, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[5].Parameters.Add(new SqlParameter("@desc", SqlDbType.NVarChar, 200, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[6] = new SqlCommand();
		this._commandCollection[6].Connection = this.Connection;
		this._commandCollection[6].CommandText = "dbo.updateJournal";
		this._commandCollection[6].CommandType = CommandType.StoredProcedure;
		this._commandCollection[6].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[6].Parameters.Add(new SqlParameter("@code", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[6].Parameters.Add(new SqlParameter("@oldCode", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[6].Parameters.Add(new SqlParameter("@account", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[6].Parameters.Add(new SqlParameter("@oldAccount", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[6].Parameters.Add(new SqlParameter("@amount", SqlDbType.Money, 8, ParameterDirection.Input, 19, 4, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[6].Parameters.Add(new SqlParameter("@oldAmount", SqlDbType.Money, 8, ParameterDirection.Input, 19, 4, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[6].Parameters.Add(new SqlParameter("@desc", SqlDbType.NVarChar, 200, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
	}

	[DebuggerNonUserCode]
	private void InitConnection()
	{
		this._connection = new SqlConnection();
		this._connection.ConnectionString = Settings.Default.AccountingDBConnectionString;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int insertFixedAssetJournal(int? doc_No, int? account, decimal? amount, string desc, DateTime? date, int? period, int? year)
	{
		int num;
		SqlCommand commandCollection = this.CommandCollection[3];
		if (&doc_No.HasValue)
		{
			commandCollection.Parameters[1].Value = &doc_No.Value;
		}
		else
		{
			commandCollection.Parameters[1].Value = DBNull.Value;
		}
		if (&account.HasValue)
		{
			commandCollection.Parameters[2].Value = &account.Value;
		}
		else
		{
			commandCollection.Parameters[2].Value = DBNull.Value;
		}
		if (&amount.HasValue)
		{
			commandCollection.Parameters[3].Value = &amount.Value;
		}
		else
		{
			commandCollection.Parameters[3].Value = DBNull.Value;
		}
		if (desc == null)
		{
			commandCollection.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			commandCollection.Parameters[4].Value = desc;
		}
		if (&date.HasValue)
		{
			commandCollection.Parameters[5].Value = &date.Value;
		}
		else
		{
			commandCollection.Parameters[5].Value = DBNull.Value;
		}
		if (&period.HasValue)
		{
			commandCollection.Parameters[6].Value = &period.Value;
		}
		else
		{
			commandCollection.Parameters[6].Value = DBNull.Value;
		}
		if (&year.HasValue)
		{
			commandCollection.Parameters[7].Value = &year.Value;
		}
		else
		{
			commandCollection.Parameters[7].Value = DBNull.Value;
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
	public virtual int insertJournal(int? doc_No, int? account, decimal? amount, string desc, DateTime? date, int? period, int? year)
	{
		int num;
		SqlCommand commandCollection = this.CommandCollection[4];
		if (&doc_No.HasValue)
		{
			commandCollection.Parameters[1].Value = &doc_No.Value;
		}
		else
		{
			commandCollection.Parameters[1].Value = DBNull.Value;
		}
		if (&account.HasValue)
		{
			commandCollection.Parameters[2].Value = &account.Value;
		}
		else
		{
			commandCollection.Parameters[2].Value = DBNull.Value;
		}
		if (&amount.HasValue)
		{
			commandCollection.Parameters[3].Value = &amount.Value;
		}
		else
		{
			commandCollection.Parameters[3].Value = DBNull.Value;
		}
		if (desc == null)
		{
			commandCollection.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			commandCollection.Parameters[4].Value = desc;
		}
		if (&date.HasValue)
		{
			commandCollection.Parameters[5].Value = &date.Value;
		}
		else
		{
			commandCollection.Parameters[5].Value = DBNull.Value;
		}
		if (&period.HasValue)
		{
			commandCollection.Parameters[6].Value = &period.Value;
		}
		else
		{
			commandCollection.Parameters[6].Value = DBNull.Value;
		}
		if (&year.HasValue)
		{
			commandCollection.Parameters[7].Value = &year.Value;
		}
		else
		{
			commandCollection.Parameters[7].Value = DBNull.Value;
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
	public virtual int updateFixedAssetsJournal(int? code, int? oldCode, int? account, int? oldAccount, decimal? amount, decimal? oldAmount, string desc)
	{
		int num;
		SqlCommand commandCollection = this.CommandCollection[5];
		if (&code.HasValue)
		{
			commandCollection.Parameters[1].Value = &code.Value;
		}
		else
		{
			commandCollection.Parameters[1].Value = DBNull.Value;
		}
		if (&oldCode.HasValue)
		{
			commandCollection.Parameters[2].Value = &oldCode.Value;
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
		if (&oldAccount.HasValue)
		{
			commandCollection.Parameters[4].Value = &oldAccount.Value;
		}
		else
		{
			commandCollection.Parameters[4].Value = DBNull.Value;
		}
		if (&amount.HasValue)
		{
			commandCollection.Parameters[5].Value = &amount.Value;
		}
		else
		{
			commandCollection.Parameters[5].Value = DBNull.Value;
		}
		if (&oldAmount.HasValue)
		{
			commandCollection.Parameters[6].Value = &oldAmount.Value;
		}
		else
		{
			commandCollection.Parameters[6].Value = DBNull.Value;
		}
		if (desc == null)
		{
			commandCollection.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			commandCollection.Parameters[7].Value = desc;
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
	[DebuggerNonUserCode]
	public virtual int updateJournal(int? code, int? oldCode, int? account, int? oldAccount, decimal? amount, decimal? oldAmount, string desc)
	{
		int num;
		SqlCommand commandCollection = this.CommandCollection[6];
		if (&code.HasValue)
		{
			commandCollection.Parameters[1].Value = &code.Value;
		}
		else
		{
			commandCollection.Parameters[1].Value = DBNull.Value;
		}
		if (&oldCode.HasValue)
		{
			commandCollection.Parameters[2].Value = &oldCode.Value;
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
		if (&oldAccount.HasValue)
		{
			commandCollection.Parameters[4].Value = &oldAccount.Value;
		}
		else
		{
			commandCollection.Parameters[4].Value = DBNull.Value;
		}
		if (&amount.HasValue)
		{
			commandCollection.Parameters[5].Value = &amount.Value;
		}
		else
		{
			commandCollection.Parameters[5].Value = DBNull.Value;
		}
		if (&oldAmount.HasValue)
		{
			commandCollection.Parameters[6].Value = &oldAmount.Value;
		}
		else
		{
			commandCollection.Parameters[6].Value = DBNull.Value;
		}
		if (desc == null)
		{
			commandCollection.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			commandCollection.Parameters[7].Value = desc;
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