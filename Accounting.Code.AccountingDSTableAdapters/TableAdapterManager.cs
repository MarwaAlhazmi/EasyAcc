using System.ComponentModel;
using System.ComponentModel.Design;
using System.CodeDom.Compiler;
using System;
using System.Data;
using System.Diagnostics;
using System.Collections.Generic;
using Accounting.Code;
using System.Data.SqlClient;
using System.Data.Common;

namespace Accounting.Code.AccountingDSTableAdapters
{
[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapterManager")]
[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
[DesignerCategory("code")]
public class TableAdapterManager : Component
{
	private bool _backupDataSetBeforeUpdate;

	private Bank_TTableAdapter _bank_TTableAdapter;

	private Cash_TTableAdapter _cash_TTableAdapter;

	private CategoryTableAdapter _categoryTableAdapter;

	private ClientTableAdapter _clientTableAdapter;

	private COA_TTableAdapter _cOA_TTableAdapter;

	private IDbConnection _connection;

	private EmployeeTableAdapter _employeeTableAdapter;

	private Journal_TTableAdapter _journal_TTableAdapter;

	private Sec_TTableAdapter _sec_TTableAdapter;

	private SupplierTableAdapter _supplierTableAdapter;

	private UpdateOrderOption _updateOrder;

	[DebuggerNonUserCode]
	public bool BackupDataSetBeforeUpdate
	{
		get
		{
			return this._backupDataSetBeforeUpdate;
		}
		set
		{
			this._backupDataSetBeforeUpdate = value;
		}
	}

	[DebuggerNonUserCode]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public Bank_TTableAdapter Bank_TTableAdapter
	{
		get
		{
			return this._bank_TTableAdapter;
		}
		set
		{
			this._bank_TTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public Cash_TTableAdapter Cash_TTableAdapter
	{
		get
		{
			return this._cash_TTableAdapter;
		}
		set
		{
			this._cash_TTableAdapter = value;
		}
	}

	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[DebuggerNonUserCode]
	public CategoryTableAdapter CategoryTableAdapter
	{
		get
		{
			return this._categoryTableAdapter;
		}
		set
		{
			this._categoryTableAdapter = value;
		}
	}

	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[DebuggerNonUserCode]
	public ClientTableAdapter ClientTableAdapter
	{
		get
		{
			return this._clientTableAdapter;
		}
		set
		{
			this._clientTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public COA_TTableAdapter COA_TTableAdapter
	{
		get
		{
			return this._cOA_TTableAdapter;
		}
		set
		{
			this._cOA_TTableAdapter = value;
		}
	}

	[Browsable(false)]
	[DebuggerNonUserCode]
	public IDbConnection Connection
	{
		get
		{
			if (this._connection != null)
			{
				return this._connection;
			}
			if (this._bank_TTableAdapter != null && this._bank_TTableAdapter.Connection != null)
			{
				return this._bank_TTableAdapter.Connection;
			}
			if (this._cash_TTableAdapter != null && this._cash_TTableAdapter.Connection != null)
			{
				return this._cash_TTableAdapter.Connection;
			}
			if (this._categoryTableAdapter != null && this._categoryTableAdapter.Connection != null)
			{
				return this._categoryTableAdapter.Connection;
			}
			if (this._cOA_TTableAdapter != null && this._cOA_TTableAdapter.Connection != null)
			{
				return this._cOA_TTableAdapter.Connection;
			}
			if (this._journal_TTableAdapter != null && this._journal_TTableAdapter.Connection != null)
			{
				return this._journal_TTableAdapter.Connection;
			}
			if (this._supplierTableAdapter != null && this._supplierTableAdapter.Connection != null)
			{
				return this._supplierTableAdapter.Connection;
			}
			if (this._employeeTableAdapter != null && this._employeeTableAdapter.Connection != null)
			{
				return this._employeeTableAdapter.Connection;
			}
			if (this._sec_TTableAdapter != null && this._sec_TTableAdapter.Connection != null)
			{
				return this._sec_TTableAdapter.Connection;
			}
			if (this._clientTableAdapter != null && this._clientTableAdapter.Connection != null)
			{
				return this._clientTableAdapter.Connection;
			}
			return null;
		}
		set
		{
			this._connection = value;
		}
	}

	[DebuggerNonUserCode]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public EmployeeTableAdapter EmployeeTableAdapter
	{
		get
		{
			return this._employeeTableAdapter;
		}
		set
		{
			this._employeeTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public Journal_TTableAdapter Journal_TTableAdapter
	{
		get
		{
			return this._journal_TTableAdapter;
		}
		set
		{
			this._journal_TTableAdapter = value;
		}
	}

	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[DebuggerNonUserCode]
	public Sec_TTableAdapter Sec_TTableAdapter
	{
		get
		{
			return this._sec_TTableAdapter;
		}
		set
		{
			this._sec_TTableAdapter = value;
		}
	}

	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[DebuggerNonUserCode]
	public SupplierTableAdapter SupplierTableAdapter
	{
		get
		{
			return this._supplierTableAdapter;
		}
		set
		{
			this._supplierTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[Browsable(false)]
	public int TableAdapterInstanceCount
	{
		get
		{
			int num = 0;
			if (this._bank_TTableAdapter != null)
			{
				num++;
			}
			if (this._cash_TTableAdapter != null)
			{
				num++;
			}
			if (this._categoryTableAdapter != null)
			{
				num++;
			}
			if (this._cOA_TTableAdapter != null)
			{
				num++;
			}
			if (this._journal_TTableAdapter != null)
			{
				num++;
			}
			if (this._supplierTableAdapter != null)
			{
				num++;
			}
			if (this._employeeTableAdapter != null)
			{
				num++;
			}
			if (this._sec_TTableAdapter != null)
			{
				num++;
			}
			if (this._clientTableAdapter != null)
			{
				num++;
			}
			return num;
		}
	}

	[DebuggerNonUserCode]
	public UpdateOrderOption UpdateOrder
	{
		get
		{
			return this._updateOrder;
		}
		set
		{
			this._updateOrder = value;
		}
	}

	public TableAdapterManager()
	{
	}

	[DebuggerNonUserCode]
	private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
	{
		if (updatedRows == null || (int)updatedRows.Length < 1)
		{
			return updatedRows;
		}
		if (allAddedRows == null || allAddedRows.Count < 1)
		{
			return updatedRows;
		}
		List<DataRow> dataRows = new List<DataRow>();
		foreach (DataRow updatedRow in updatedRows)
		{
			if (!allAddedRows.Contains(updatedRow))
			{
				dataRows.Add(updatedRow);
			}
		}
		return dataRows.ToArray();
	}

	[DebuggerNonUserCode]
	protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
	{
		if (this._connection != null)
		{
			return true;
		}
		if (this.Connection == null || inputConnection == null)
		{
			return true;
		}
		if (string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}

	[DebuggerNonUserCode]
	protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
	{
		Sort<DataRow>(rows, new SelfReferenceComparer(relation, childFirst));
	}

	[DebuggerNonUserCode]
	public virtual int UpdateAll(AccountingDS dataSet)
	{
		DataRow[] dataRowArray;
		if (dataSet == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!dataSet.HasChanges())
		{
			return 0;
		}
		if (this._bank_TTableAdapter != null && !this.MatchTableAdapterConnection(this._bank_TTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (this._cash_TTableAdapter != null && !this.MatchTableAdapterConnection(this._cash_TTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (this._categoryTableAdapter != null && !this.MatchTableAdapterConnection(this._categoryTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (this._cOA_TTableAdapter != null && !this.MatchTableAdapterConnection(this._cOA_TTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (this._journal_TTableAdapter != null && !this.MatchTableAdapterConnection(this._journal_TTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (this._supplierTableAdapter != null && !this.MatchTableAdapterConnection(this._supplierTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (this._employeeTableAdapter != null && !this.MatchTableAdapterConnection(this._employeeTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (this._sec_TTableAdapter != null && !this.MatchTableAdapterConnection(this._sec_TTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (this._clientTableAdapter != null && !this.MatchTableAdapterConnection(this._clientTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		IDbConnection connection = this.Connection;
		if (connection == null)
		{
			throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
		}
		bool flag = false;
		if ((connection.State & 16) == 16)
		{
			connection.Close();
		}
		if (connection.State == 0)
		{
			connection.Open();
			flag = true;
		}
		IDbTransaction dbTransaction = connection.BeginTransaction();
		if (dbTransaction == null)
		{
			throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
		}
		List<DataRow> dataRows1 = new List<DataRow>();
		List<DataRow> dataRows2 = new List<DataRow>();
		List<DataAdapter> dataAdapters = new List<DataAdapter>();
		Dictionary<object, IDbConnection> objs = new Dictionary<object, IDbConnection>();
		int num = 0;
		DataSet dataSet2 = null;
		if (this.BackupDataSetBeforeUpdate)
		{
			dataSet2 = new DataSet();
			dataSet2.Merge(dataSet);
		}
		try
		{
			if (this._bank_TTableAdapter != null)
			{
				objs.Add(this._bank_TTableAdapter, this._bank_TTableAdapter.Connection);
				this._bank_TTableAdapter.Connection = (SqlConnection)connection;
				this._bank_TTableAdapter.Transaction = (SqlTransaction)dbTransaction;
				if (this._bank_TTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					this._bank_TTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					dataAdapters.Add(this._bank_TTableAdapter.Adapter);
				}
			}
			if (this._cash_TTableAdapter != null)
			{
				objs.Add(this._cash_TTableAdapter, this._cash_TTableAdapter.Connection);
				this._cash_TTableAdapter.Connection = (SqlConnection)connection;
				this._cash_TTableAdapter.Transaction = (SqlTransaction)dbTransaction;
				if (this._cash_TTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					this._cash_TTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					dataAdapters.Add(this._cash_TTableAdapter.Adapter);
				}
			}
			if (this._categoryTableAdapter != null)
			{
				objs.Add(this._categoryTableAdapter, this._categoryTableAdapter.Connection);
				this._categoryTableAdapter.Connection = (SqlConnection)connection;
				this._categoryTableAdapter.Transaction = (SqlTransaction)dbTransaction;
				if (this._categoryTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					this._categoryTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					dataAdapters.Add(this._categoryTableAdapter.Adapter);
				}
			}
			if (this._cOA_TTableAdapter != null)
			{
				objs.Add(this._cOA_TTableAdapter, this._cOA_TTableAdapter.Connection);
				this._cOA_TTableAdapter.Connection = (SqlConnection)connection;
				this._cOA_TTableAdapter.Transaction = (SqlTransaction)dbTransaction;
				if (this._cOA_TTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					this._cOA_TTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					dataAdapters.Add(this._cOA_TTableAdapter.Adapter);
				}
			}
			if (this._journal_TTableAdapter != null)
			{
				objs.Add(this._journal_TTableAdapter, this._journal_TTableAdapter.Connection);
				this._journal_TTableAdapter.Connection = (SqlConnection)connection;
				this._journal_TTableAdapter.Transaction = (SqlTransaction)dbTransaction;
				if (this._journal_TTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					this._journal_TTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					dataAdapters.Add(this._journal_TTableAdapter.Adapter);
				}
			}
			if (this._supplierTableAdapter != null)
			{
				objs.Add(this._supplierTableAdapter, this._supplierTableAdapter.Connection);
				this._supplierTableAdapter.Connection = (SqlConnection)connection;
				this._supplierTableAdapter.Transaction = (SqlTransaction)dbTransaction;
				if (this._supplierTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					this._supplierTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					dataAdapters.Add(this._supplierTableAdapter.Adapter);
				}
			}
			if (this._employeeTableAdapter != null)
			{
				objs.Add(this._employeeTableAdapter, this._employeeTableAdapter.Connection);
				this._employeeTableAdapter.Connection = (SqlConnection)connection;
				this._employeeTableAdapter.Transaction = (SqlTransaction)dbTransaction;
				if (this._employeeTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					this._employeeTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					dataAdapters.Add(this._employeeTableAdapter.Adapter);
				}
			}
			if (this._sec_TTableAdapter != null)
			{
				objs.Add(this._sec_TTableAdapter, this._sec_TTableAdapter.Connection);
				this._sec_TTableAdapter.Connection = (SqlConnection)connection;
				this._sec_TTableAdapter.Transaction = (SqlTransaction)dbTransaction;
				if (this._sec_TTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					this._sec_TTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					dataAdapters.Add(this._sec_TTableAdapter.Adapter);
				}
			}
			if (this._clientTableAdapter != null)
			{
				objs.Add(this._clientTableAdapter, this._clientTableAdapter.Connection);
				this._clientTableAdapter.Connection = (SqlConnection)connection;
				this._clientTableAdapter.Transaction = (SqlTransaction)dbTransaction;
				if (this._clientTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					this._clientTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					dataAdapters.Add(this._clientTableAdapter.Adapter);
				}
			}
			if (this.UpdateOrder == UpdateOrderOption.UpdateInsertDelete)
			{
				num = num + this.UpdateUpdatedRows(dataSet, dataRows1, dataRows2);
				num = num + this.UpdateInsertedRows(dataSet, dataRows2);
			}
			else
			{
				num = num + this.UpdateInsertedRows(dataSet, dataRows2);
				num = num + this.UpdateUpdatedRows(dataSet, dataRows1, dataRows2);
			}
			num = num + this.UpdateDeletedRows(dataSet, dataRows1);
			dbTransaction.Commit();
			if (0 < dataRows2.Count)
			{
				dataRowArray = new DataRow[dataRows2.Count];
				dataRows2.CopyTo(dataRowArray);
				foreach (DataRow dataRow in dataRowArray)
				{
					dataRow.AcceptChanges();
				}
			}
			if (0 < dataRows1.Count)
			{
				dataRowArray = new DataRow[dataRows1.Count];
				dataRows1.CopyTo(dataRowArray);
				foreach (DataRow dataRow in dataRowArray)
				{
					dataRow.AcceptChanges();
				}
			}
		}
		catch (Exception exception)
		{
			dbTransaction.Rollback();
			if (this.BackupDataSetBeforeUpdate)
			{
				Debug.Assert(dataSet2 != null);
				dataSet.Clear();
				dataSet.Merge(dataSet2);
			}
			else
			{
				if (0 < dataRows2.Count)
				{
					dataRowArray = new DataRow[dataRows2.Count];
					dataRows2.CopyTo(dataRowArray);
					foreach (DataRow dataRow in dataRowArray)
					{
						dataRow.AcceptChanges();
						dataRow.SetAdded();
					}
				}
			}
			throw exception;
		}
		finally
		{
			if (flag != 0)
			{
				connection.Close();
			}
			if (this._bank_TTableAdapter != null)
			{
				this._bank_TTableAdapter.Connection = (SqlConnection)objs[this._bank_TTableAdapter];
				this._bank_TTableAdapter.Transaction = null;
			}
			if (this._cash_TTableAdapter != null)
			{
				this._cash_TTableAdapter.Connection = (SqlConnection)objs[this._cash_TTableAdapter];
				this._cash_TTableAdapter.Transaction = null;
			}
			if (this._categoryTableAdapter != null)
			{
				this._categoryTableAdapter.Connection = (SqlConnection)objs[this._categoryTableAdapter];
				this._categoryTableAdapter.Transaction = null;
			}
			if (this._cOA_TTableAdapter != null)
			{
				this._cOA_TTableAdapter.Connection = (SqlConnection)objs[this._cOA_TTableAdapter];
				this._cOA_TTableAdapter.Transaction = null;
			}
			if (this._journal_TTableAdapter != null)
			{
				this._journal_TTableAdapter.Connection = (SqlConnection)objs[this._journal_TTableAdapter];
				this._journal_TTableAdapter.Transaction = null;
			}
			if (this._supplierTableAdapter != null)
			{
				this._supplierTableAdapter.Connection = (SqlConnection)objs[this._supplierTableAdapter];
				this._supplierTableAdapter.Transaction = null;
			}
			if (this._employeeTableAdapter != null)
			{
				this._employeeTableAdapter.Connection = (SqlConnection)objs[this._employeeTableAdapter];
				this._employeeTableAdapter.Transaction = null;
			}
			if (this._sec_TTableAdapter != null)
			{
				this._sec_TTableAdapter.Connection = (SqlConnection)objs[this._sec_TTableAdapter];
				this._sec_TTableAdapter.Transaction = null;
			}
			if (this._clientTableAdapter != null)
			{
				this._clientTableAdapter.Connection = (SqlConnection)objs[this._clientTableAdapter];
				this._clientTableAdapter.Transaction = null;
			}
			if (0 < dataAdapters.Count)
			{
				DataAdapter[] dataAdapterArray = new DataAdapter[dataAdapters.Count];
				dataAdapters.CopyTo(dataAdapterArray);
				foreach (DataAdapter dataAdapter in dataAdapterArray)
				{
					dataAdapter.AcceptChangesDuringUpdate = true;
				}
			}
		}
		return num;
	}

	[DebuggerNonUserCode]
	private int UpdateDeletedRows(AccountingDS dataSet, List<DataRow> allChangedRows)
	{
		DataRow[] dataRowArray;
		int num = 0;
		if (this._supplierTableAdapter != null)
		{
			dataRowArray = dataSet.Supplier.Select(null, null, DataViewRowState.Deleted);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				num = num + this._supplierTableAdapter.Update(dataRowArray);
				allChangedRows.AddRange(dataRowArray);
			}
		}
		if (this._journal_TTableAdapter != null)
		{
			dataRowArray = dataSet.Journal_T.Select(null, null, DataViewRowState.Deleted);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				num = num + this._journal_TTableAdapter.Update(dataRowArray);
				allChangedRows.AddRange(dataRowArray);
			}
		}
		if (this._employeeTableAdapter != null)
		{
			dataRowArray = dataSet.Employee.Select(null, null, DataViewRowState.Deleted);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				num = num + this._employeeTableAdapter.Update(dataRowArray);
				allChangedRows.AddRange(dataRowArray);
			}
		}
		if (this._sec_TTableAdapter != null)
		{
			dataRowArray = dataSet.Sec_T.Select(null, null, DataViewRowState.Deleted);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				num = num + this._sec_TTableAdapter.Update(dataRowArray);
				allChangedRows.AddRange(dataRowArray);
			}
		}
		if (this._clientTableAdapter != null)
		{
			dataRowArray = dataSet.Client.Select(null, null, DataViewRowState.Deleted);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				num = num + this._clientTableAdapter.Update(dataRowArray);
				allChangedRows.AddRange(dataRowArray);
			}
		}
		if (this._cash_TTableAdapter != null)
		{
			dataRowArray = dataSet.Cash_T.Select(null, null, DataViewRowState.Deleted);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				num = num + this._cash_TTableAdapter.Update(dataRowArray);
				allChangedRows.AddRange(dataRowArray);
			}
		}
		if (this._bank_TTableAdapter != null)
		{
			dataRowArray = dataSet.Bank_T.Select(null, null, DataViewRowState.Deleted);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				num = num + this._bank_TTableAdapter.Update(dataRowArray);
				allChangedRows.AddRange(dataRowArray);
			}
		}
		if (this._cOA_TTableAdapter != null)
		{
			dataRowArray = dataSet.COA_T.Select(null, null, DataViewRowState.Deleted);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				this.SortSelfReferenceRows(dataRowArray, dataSet.Relations["FK_COA_T_COA_T1"], true);
				num = num + this._cOA_TTableAdapter.Update(dataRowArray);
				allChangedRows.AddRange(dataRowArray);
			}
		}
		if (this._categoryTableAdapter != null)
		{
			dataRowArray = dataSet.Category.Select(null, null, DataViewRowState.Deleted);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				num = num + this._categoryTableAdapter.Update(dataRowArray);
				allChangedRows.AddRange(dataRowArray);
			}
		}
		return num;
	}

	[DebuggerNonUserCode]
	private int UpdateInsertedRows(AccountingDS dataSet, List<DataRow> allAddedRows)
	{
		DataRow[] dataRowArray;
		int num = 0;
		if (this._categoryTableAdapter != null)
		{
			dataRowArray = dataSet.Category.Select(null, null, DataViewRowState.Added);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				num = num + this._categoryTableAdapter.Update(dataRowArray);
				allAddedRows.AddRange(dataRowArray);
			}
		}
		if (this._cOA_TTableAdapter != null)
		{
			dataRowArray = dataSet.COA_T.Select(null, null, DataViewRowState.Added);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				this.SortSelfReferenceRows(dataRowArray, dataSet.Relations["FK_COA_T_COA_T1"], false);
				num = num + this._cOA_TTableAdapter.Update(dataRowArray);
				allAddedRows.AddRange(dataRowArray);
			}
		}
		if (this._bank_TTableAdapter != null)
		{
			dataRowArray = dataSet.Bank_T.Select(null, null, DataViewRowState.Added);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				num = num + this._bank_TTableAdapter.Update(dataRowArray);
				allAddedRows.AddRange(dataRowArray);
			}
		}
		if (this._cash_TTableAdapter != null)
		{
			dataRowArray = dataSet.Cash_T.Select(null, null, DataViewRowState.Added);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				num = num + this._cash_TTableAdapter.Update(dataRowArray);
				allAddedRows.AddRange(dataRowArray);
			}
		}
		if (this._clientTableAdapter != null)
		{
			dataRowArray = dataSet.Client.Select(null, null, DataViewRowState.Added);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				num = num + this._clientTableAdapter.Update(dataRowArray);
				allAddedRows.AddRange(dataRowArray);
			}
		}
		if (this._sec_TTableAdapter != null)
		{
			dataRowArray = dataSet.Sec_T.Select(null, null, DataViewRowState.Added);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				num = num + this._sec_TTableAdapter.Update(dataRowArray);
				allAddedRows.AddRange(dataRowArray);
			}
		}
		if (this._employeeTableAdapter != null)
		{
			dataRowArray = dataSet.Employee.Select(null, null, DataViewRowState.Added);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				num = num + this._employeeTableAdapter.Update(dataRowArray);
				allAddedRows.AddRange(dataRowArray);
			}
		}
		if (this._journal_TTableAdapter != null)
		{
			dataRowArray = dataSet.Journal_T.Select(null, null, DataViewRowState.Added);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				num = num + this._journal_TTableAdapter.Update(dataRowArray);
				allAddedRows.AddRange(dataRowArray);
			}
		}
		if (this._supplierTableAdapter != null)
		{
			dataRowArray = dataSet.Supplier.Select(null, null, DataViewRowState.Added);
			if (dataRowArray != null && 0 < (int)dataRowArray.Length)
			{
				num = num + this._supplierTableAdapter.Update(dataRowArray);
				allAddedRows.AddRange(dataRowArray);
			}
		}
		return num;
	}

	[DebuggerNonUserCode]
	private int UpdateUpdatedRows(AccountingDS dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
	{
		DataRow[] realUpdatedRows;
		int num = 0;
		if (this._categoryTableAdapter != null)
		{
			realUpdatedRows = dataSet.Category.Select(null, null, DataViewRowState.ModifiedCurrent);
			realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
			if (realUpdatedRows != null && 0 < (int)realUpdatedRows.Length)
			{
				num = num + this._categoryTableAdapter.Update(realUpdatedRows);
				allChangedRows.AddRange(realUpdatedRows);
			}
		}
		if (this._cOA_TTableAdapter != null)
		{
			realUpdatedRows = dataSet.COA_T.Select(null, null, DataViewRowState.ModifiedCurrent);
			realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
			if (realUpdatedRows != null && 0 < (int)realUpdatedRows.Length)
			{
				this.SortSelfReferenceRows(realUpdatedRows, dataSet.Relations["FK_COA_T_COA_T1"], false);
				num = num + this._cOA_TTableAdapter.Update(realUpdatedRows);
				allChangedRows.AddRange(realUpdatedRows);
			}
		}
		if (this._bank_TTableAdapter != null)
		{
			realUpdatedRows = dataSet.Bank_T.Select(null, null, DataViewRowState.ModifiedCurrent);
			realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
			if (realUpdatedRows != null && 0 < (int)realUpdatedRows.Length)
			{
				num = num + this._bank_TTableAdapter.Update(realUpdatedRows);
				allChangedRows.AddRange(realUpdatedRows);
			}
		}
		if (this._cash_TTableAdapter != null)
		{
			realUpdatedRows = dataSet.Cash_T.Select(null, null, DataViewRowState.ModifiedCurrent);
			realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
			if (realUpdatedRows != null && 0 < (int)realUpdatedRows.Length)
			{
				num = num + this._cash_TTableAdapter.Update(realUpdatedRows);
				allChangedRows.AddRange(realUpdatedRows);
			}
		}
		if (this._clientTableAdapter != null)
		{
			realUpdatedRows = dataSet.Client.Select(null, null, DataViewRowState.ModifiedCurrent);
			realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
			if (realUpdatedRows != null && 0 < (int)realUpdatedRows.Length)
			{
				num = num + this._clientTableAdapter.Update(realUpdatedRows);
				allChangedRows.AddRange(realUpdatedRows);
			}
		}
		if (this._sec_TTableAdapter != null)
		{
			realUpdatedRows = dataSet.Sec_T.Select(null, null, DataViewRowState.ModifiedCurrent);
			realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
			if (realUpdatedRows != null && 0 < (int)realUpdatedRows.Length)
			{
				num = num + this._sec_TTableAdapter.Update(realUpdatedRows);
				allChangedRows.AddRange(realUpdatedRows);
			}
		}
		if (this._employeeTableAdapter != null)
		{
			realUpdatedRows = dataSet.Employee.Select(null, null, DataViewRowState.ModifiedCurrent);
			realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
			if (realUpdatedRows != null && 0 < (int)realUpdatedRows.Length)
			{
				num = num + this._employeeTableAdapter.Update(realUpdatedRows);
				allChangedRows.AddRange(realUpdatedRows);
			}
		}
		if (this._journal_TTableAdapter != null)
		{
			realUpdatedRows = dataSet.Journal_T.Select(null, null, DataViewRowState.ModifiedCurrent);
			realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
			if (realUpdatedRows != null && 0 < (int)realUpdatedRows.Length)
			{
				num = num + this._journal_TTableAdapter.Update(realUpdatedRows);
				allChangedRows.AddRange(realUpdatedRows);
			}
		}
		if (this._supplierTableAdapter != null)
		{
			realUpdatedRows = dataSet.Supplier.Select(null, null, DataViewRowState.ModifiedCurrent);
			realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
			if (realUpdatedRows != null && 0 < (int)realUpdatedRows.Length)
			{
				num = num + this._supplierTableAdapter.Update(realUpdatedRows);
				allChangedRows.AddRange(realUpdatedRows);
			}
		}
		return num;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	private class SelfReferenceComparer : IComparer<DataRow>
	{
		private int _childFirst;

		private DataRelation _relation;

		[DebuggerNonUserCode]
		internal SelfReferenceComparer(DataRelation relation, bool childFirst);

		[DebuggerNonUserCode]
		public int Compare(DataRow row1, DataRow row2);

		[DebuggerNonUserCode]
		private bool IsChildAndParent(DataRow child, DataRow parent);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public enum UpdateOrderOption
	{
		InsertUpdateDelete,
		UpdateInsertDelete
	}
}
}