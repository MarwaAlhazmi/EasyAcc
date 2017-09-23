using System;
using Accounting.Code.AccountingDSTableAdapters;

public class BankBll
{
	public BankBll()
	{
	}

	public int getAccountCode(int code)
	{
		Bank_TTableAdapter bankTTableAdapter;
		int num;
		try
		{
			bankTTableAdapter = new Bank_TTableAdapter();
		}
		catch
		{
			throw new Exception("Error getting the Account code of this bank intance");
		}
		using (bankTTableAdapter)
		{
			num = Convert.ToInt32(bankTTableAdapter.GetAccountCode(code));
		}
		return num;
	}

	public Bank_TDataTable getBanks()
	{
		Bank_TDataTable bankTDataTable1;
		using (Bank_TTableAdapter bankTTableAdapter = new Bank_TTableAdapter())
		{
			try
			{
				Bank_TDataTable bankTDataTable2 = new Bank_TDataTable();
				bankTTableAdapter.Fill(bankTDataTable2);
				bankTDataTable1 = bankTDataTable2;
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("Unable to get banks", exception.Message));
			}
		}
		return bankTDataTable1;
	}

	public void insertBank(string name, int accCode, string contact)
	{
		try
		{
			using (Bank_TTableAdapter bankTTableAdapter = new Bank_TTableAdapter())
			{
				bankTTableAdapter.Insert(name, accCode, contact);
			}
		}
		catch (Exception exception)
		{
			throw new Exception(string.Concat("Error inserting the Bank. ", exception.Message));
		}
	}
}