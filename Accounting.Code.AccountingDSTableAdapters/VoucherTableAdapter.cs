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
[ToolboxItem(true)]
[DataObject(true)]
[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
[HelpKeyword("vs.data.TableAdapter")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
public class VoucherTableAdapter : Component
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
	public VoucherTableAdapter()
	{
		this.ClearBeforeFill = true;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int addVoucher(int? Cash, int? DAcc, int? CAcc, decimal? Amount, string Type, int? Bank, int? chkNumber, byte? period, DateTime? date, string Desc)
	{
		int num;
		SqlCommand commandCollection = this.CommandCollection[1];
		if (&Cash.HasValue)
		{
			commandCollection.Parameters[1].Value = &Cash.Value;
		}
		else
		{
			commandCollection.Parameters[1].Value = DBNull.Value;
		}
		if (&DAcc.HasValue)
		{
			commandCollection.Parameters[2].Value = &DAcc.Value;
		}
		else
		{
			commandCollection.Parameters[2].Value = DBNull.Value;
		}
		if (&CAcc.HasValue)
		{
			commandCollection.Parameters[3].Value = &CAcc.Value;
		}
		else
		{
			commandCollection.Parameters[3].Value = DBNull.Value;
		}
		if (&Amount.HasValue)
		{
			commandCollection.Parameters[4].Value = &Amount.Value;
		}
		else
		{
			commandCollection.Parameters[4].Value = DBNull.Value;
		}
		if (Type == null)
		{
			commandCollection.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			commandCollection.Parameters[5].Value = Type;
		}
		if (&Bank.HasValue)
		{
			commandCollection.Parameters[6].Value = &Bank.Value;
		}
		else
		{
			commandCollection.Parameters[6].Value = DBNull.Value;
		}
		if (&chkNumber.HasValue)
		{
			commandCollection.Parameters[7].Value = &chkNumber.Value;
		}
		else
		{
			commandCollection.Parameters[7].Value = DBNull.Value;
		}
		if (&period.HasValue)
		{
			commandCollection.Parameters[8].Value = &period.Value;
		}
		else
		{
			commandCollection.Parameters[8].Value = DBNull.Value;
		}
		if (&date.HasValue)
		{
			commandCollection.Parameters[9].Value = &date.Value;
		}
		else
		{
			commandCollection.Parameters[9].Value = DBNull.Value;
		}
		if (Desc == null)
		{
			commandCollection.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			commandCollection.Parameters[10].Value = Desc;
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
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(VoucherDataTable dataTable, int? invoiceCode)
	{
		this.Adapter.SelectCommand = this.CommandCollection[0];
		if (&invoiceCode.HasValue)
		{
			this.Adapter.SelectCommand.Parameters[1].Value = &invoiceCode.Value;
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

	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int FillBy(VoucherDataTable dataTable, DateTime? date)
	{
		this.Adapter.SelectCommand = this.CommandCollection[2];
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

	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual VoucherDataTable GetData(int? invoiceCode)
	{
		this.Adapter.SelectCommand = this.CommandCollection[0];
		if (&invoiceCode.HasValue)
		{
			this.Adapter.SelectCommand.Parameters[1].Value = &invoiceCode.Value;
		}
		else
		{
			this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
		}
		VoucherDataTable voucherDataTable = new VoucherDataTable();
		this.Adapter.Fill(voucherDataTable);
		return voucherDataTable;
	}

	[DataObjectMethod(DataObjectMethodType.Select, false)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual VoucherDataTable GetVoucherByDate(DateTime? date)
	{
		this.Adapter.SelectCommand = this.CommandCollection[2];
		if (&date.HasValue)
		{
			this.Adapter.SelectCommand.Parameters[1].Value = &date.Value;
		}
		else
		{
			this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
		}
		VoucherDataTable voucherDataTable = new VoucherDataTable();
		this.Adapter.Fill(voucherDataTable);
		return voucherDataTable;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual object GetVoucherType(int? voucherNum)
	{
		object obj;
		SqlCommand commandCollection = this.CommandCollection[3];
		if (&voucherNum.HasValue)
		{
			commandCollection.Parameters[1].Value = &voucherNum.Value;
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
	private void InitAdapter()
	{
		this._adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Voucher";
		dataTableMapping.ColumnMappings.Add("chkNumber", "chkNumber");
		dataTableMapping.ColumnMappings.Add("Code", "Code");
		dataTableMapping.ColumnMappings.Add("BankName", "BankName");
		dataTableMapping.ColumnMappings.Add("Amount_NU", "Amount_NU");
		dataTableMapping.ColumnMappings.Add("Descrip_VC", "Descrip_VC");
		dataTableMapping.ColumnMappings.Add("Date_DT", "Date_DT");
		dataTableMapping.ColumnMappings.Add("CAcc", "CAcc");
		dataTableMapping.ColumnMappings.Add("CName", "CName");
		dataTableMapping.ColumnMappings.Add("DAcc", "DAcc");
		dataTableMapping.ColumnMappings.Add("DName", "DName");
		this._adapter.TableMappings.Add(dataTableMapping);
	}

	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		this._commandCollection = new SqlCommand[5];
		this._commandCollection[0] = new SqlCommand();
		this._commandCollection[0].Connection = this.Connection;
		this._commandCollection[0].CommandText = "dbo.GetVoucher";
		this._commandCollection[0].CommandType = CommandType.StoredProcedure;
		this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[0].Parameters.Add(new SqlParameter("@invoiceCode", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1] = new SqlCommand();
		this._commandCollection[1].Connection = this.Connection;
		this._commandCollection[1].CommandText = "dbo.addVoucher";
		this._commandCollection[1].CommandType = CommandType.StoredProcedure;
		this._commandCollection[1].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@Cash", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@DAcc", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@CAcc", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@Amount", SqlDbType.Money, 8, ParameterDirection.Input, 19, 4, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@Bank", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@chkNumber", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@period", SqlDbType.TinyInt, 1, ParameterDirection.Input, 3, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@date", SqlDbType.DateTime, 8, ParameterDirection.Input, 23, 3, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[1].Parameters.Add(new SqlParameter("@Desc", SqlDbType.NVarChar, 200, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[2] = new SqlCommand();
		this._commandCollection[2].Connection = this.Connection;
		this._commandCollection[2].CommandText = "dbo.GetAllVouchers";
		this._commandCollection[2].CommandType = CommandType.StoredProcedure;
		this._commandCollection[2].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[2].Parameters.Add(new SqlParameter("@date", SqlDbType.DateTime, 8, ParameterDirection.Input, 23, 3, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[3] = new SqlCommand();
		this._commandCollection[3].Connection = this.Connection;
		this._commandCollection[3].CommandText = "dbo.GetVoucherType";
		this._commandCollection[3].CommandType = CommandType.StoredProcedure;
		this._commandCollection[3].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[3].Parameters.Add(new SqlParameter("@voucherNum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4] = new SqlCommand();
		this._commandCollection[4].Connection = this.Connection;
		this._commandCollection[4].CommandText = "dbo.updateVoucher";
		this._commandCollection[4].CommandType = CommandType.StoredProcedure;
		this._commandCollection[4].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4].Parameters.Add(new SqlParameter("@VNumber", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4].Parameters.Add(new SqlParameter("@DAcc", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4].Parameters.Add(new SqlParameter("@OldDAcc", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4].Parameters.Add(new SqlParameter("@CAcc", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4].Parameters.Add(new SqlParameter("@OldCAcc", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4].Parameters.Add(new SqlParameter("@Amount", SqlDbType.Money, 8, ParameterDirection.Input, 19, 4, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4].Parameters.Add(new SqlParameter("@preAmount", SqlDbType.Money, 8, ParameterDirection.Input, 19, 4, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4].Parameters.Add(new SqlParameter("@Bank", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4].Parameters.Add(new SqlParameter("@chkNumber", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		this._commandCollection[4].Parameters.Add(new SqlParameter("@Desc", SqlDbType.NVarChar, 200, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
	}

	[DebuggerNonUserCode]
	private void InitConnection()
	{
		this._connection = new SqlConnection();
		this._connection.ConnectionString = Settings.Default.AccountingDBConnectionString;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int updateVoucher(int? VNumber, int? DAcc, int? OldDAcc, int? CAcc, int? OldCAcc, decimal? Amount, decimal? preAmount, int? Bank, int? chkNumber, string Desc)
	{
		int num;
		SqlCommand commandCollection = this.CommandCollection[4];
		if (&VNumber.HasValue)
		{
			commandCollection.Parameters[1].Value = &VNumber.Value;
		}
		else
		{
			commandCollection.Parameters[1].Value = DBNull.Value;
		}
		if (&DAcc.HasValue)
		{
			commandCollection.Parameters[2].Value = &DAcc.Value;
		}
		else
		{
			commandCollection.Parameters[2].Value = DBNull.Value;
		}
		if (&OldDAcc.HasValue)
		{
			commandCollection.Parameters[3].Value = &OldDAcc.Value;
		}
		else
		{
			commandCollection.Parameters[3].Value = DBNull.Value;
		}
		if (&CAcc.HasValue)
		{
			commandCollection.Parameters[4].Value = &CAcc.Value;
		}
		else
		{
			commandCollection.Parameters[4].Value = DBNull.Value;
		}
		if (&OldCAcc.HasValue)
		{
			commandCollection.Parameters[5].Value = &OldCAcc.Value;
		}
		else
		{
			commandCollection.Parameters[5].Value = DBNull.Value;
		}
		if (&Amount.HasValue)
		{
			commandCollection.Parameters[6].Value = &Amount.Value;
		}
		else
		{
			commandCollection.Parameters[6].Value = DBNull.Value;
		}
		if (&preAmount.HasValue)
		{
			commandCollection.Parameters[7].Value = &preAmount.Value;
		}
		else
		{
			commandCollection.Parameters[7].Value = DBNull.Value;
		}
		if (&Bank.HasValue)
		{
			commandCollection.Parameters[8].Value = &Bank.Value;
		}
		else
		{
			commandCollection.Parameters[8].Value = DBNull.Value;
		}
		if (&chkNumber.HasValue)
		{
			commandCollection.Parameters[9].Value = &chkNumber.Value;
		}
		else
		{
			commandCollection.Parameters[9].Value = DBNull.Value;
		}
		if (Desc == null)
		{
			commandCollection.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			commandCollection.Parameters[10].Value = Desc;
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