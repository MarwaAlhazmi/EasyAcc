using System.ComponentModel;
using System.ComponentModel.Design;
using System.CodeDom.Compiler;
using System.Data.SqlClient;
using System;
using System.Diagnostics;
using System.Data.Common;
using System.Data;
using Accounting.Properties;
using Accounting.Code;

namespace Accounting.Code.AccountingDSTableAdapters
{
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapter")]
[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
[DesignerCategory("code")]
public class Journal_TTableAdapter : Component
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
	public Journal_TTableAdapter()
	{
		this.ClearBeforeFill = true;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[DebuggerNonUserCode]
	public virtual int Fill(Journal_TDataTable dataTable)
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
	public virtual Journal_TDataTable GetData()
	{
		this.Adapter.SelectCommand = this.CommandCollection[0];
		Journal_TDataTable journalTDataTable = new Journal_TDataTable();
		this.Adapter.Fill(journalTDataTable);
		return journalTDataTable;
	}

	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		this._adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Journal_T";
		dataTableMapping.ColumnMappings.Add("Doc_No_VC", "Doc_No_VC");
		dataTableMapping.ColumnMappings.Add("GL_ID", "GL_ID");
		dataTableMapping.ColumnMappings.Add("Amount_NU", "Amount_NU");
		dataTableMapping.ColumnMappings.Add("Descrip_VC", "Descrip_VC");
		dataTableMapping.ColumnMappings.Add("Date_DT", "Date_DT");
		dataTableMapping.ColumnMappings.Add("Period_TI", "Period_TI");
		dataTableMapping.ColumnMappings.Add("Year_SI", "Year_SI");
		this._adapter.TableMappings.Add(dataTableMapping);
		this._adapter.InsertCommand = new SqlCommand();
		this._adapter.InsertCommand.Connection = this.Connection;
		this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Journal_T] ([Doc_No_VC], [GL_ID], [Amount_NU], [Descrip_VC], [Date_DT], [Period_TI], [Year_SI]) VALUES (@Doc_No_VC, @GL_ID, @Amount_NU, @Descrip_VC, @Date_DT, @Period_TI, @Year_SI)";
		this._adapter.InsertCommand.CommandType = CommandType.Text;
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Doc_No_VC", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Doc_No_VC", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GL_ID", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "GL_ID", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Amount_NU", SqlDbType.Money, 0, ParameterDirection.Input, 0, 0, "Amount_NU", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Descrip_VC", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Descrip_VC", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Date_DT", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "Date_DT", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Period_TI", SqlDbType.TinyInt, 0, ParameterDirection.Input, 0, 0, "Period_TI", DataRowVersion.Current, false, null, "", "", ""));
		this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Year_SI", SqlDbType.SmallInt, 0, ParameterDirection.Input, 0, 0, "Year_SI", DataRowVersion.Current, false, null, "", "", ""));
	}

	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		this._commandCollection = new SqlCommand[1];
		this._commandCollection[0] = new SqlCommand();
		this._commandCollection[0].Connection = this.Connection;
		this._commandCollection[0].CommandText = "SELECT Doc_No_VC, GL_ID, Amount_NU, Descrip_VC, Date_DT, Period_TI, Year_SI FROM dbo.Journal_T";
		this._commandCollection[0].CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	private void InitConnection()
	{
		this._connection = new SqlConnection();
		this._connection.ConnectionString = Settings.Default.AccountingDBConnectionString;
	}

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Insert(int Doc_No_VC, int GL_ID, decimal Amount_NU, string Descrip_VC, DateTime Date_DT, byte Period_TI, short Year_SI)
	{
		int num1;
		this.Adapter.InsertCommand.Parameters[0].Value = Doc_No_VC;
		this.Adapter.InsertCommand.Parameters[1].Value = GL_ID;
		this.Adapter.InsertCommand.Parameters[2].Value = Amount_NU;
		if (Descrip_VC == null)
		{
			throw new ArgumentNullException("Descrip_VC");
		}
		this.Adapter.InsertCommand.Parameters[3].Value = Descrip_VC;
		this.Adapter.InsertCommand.Parameters[4].Value = Date_DT;
		this.Adapter.InsertCommand.Parameters[5].Value = Period_TI;
		this.Adapter.InsertCommand.Parameters[6].Value = Year_SI;
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
	public virtual int Update(Journal_TDataTable dataTable)
	{
		return this.Adapter.Update(dataTable);
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(AccountingDS dataSet)
	{
		return this.Adapter.Update(dataSet, "Journal_T");
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
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
}
}