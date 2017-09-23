using System;
using Accounting.Code.AccountingDSTableAdapters;

public class CashBll
{
	public CashBll()
	{
	}

	public int getNewVoucher()
	{
		int num1;
		using (Cash_TTableAdapter cashTTableAdapter = new Cash_TTableAdapter())
		{
			try
			{
				int num2 = Convert.ToInt32(cashTTableAdapter.getMax());
				num1 = num2 + 1;
			}
			catch
			{
				throw new Exception("unable to get new voucher number");
			}
		}
		return num1;
	}

	public string getType(int VNumber)
	{
		string type;
		using (Cash_TTableAdapter cashTTableAdapter = new Cash_TTableAdapter())
		{
			try
			{
				type = cashTTableAdapter.GetType(VNumber);
			}
			catch
			{
				throw new Exception("unable to get the type of the voucher");
			}
		}
		return type;
	}

	public bool insert(int code, string type)
	{
		bool flag;
		using (Cash_TTableAdapter cashTTableAdapter = new Cash_TTableAdapter())
		{
			try
			{
				int? nullable = null.Insert(nullable, nullable, nullable = null, nullable);
				flag = true;
			}
			catch
			{
				throw new Exception("unable to insert new voucher");
			}
		}
		return flag;
	}

	public bool insert(int code, string type, int bankCode, int chkNumber)
	{
		bool flag;
		using (Cash_TTableAdapter cashTTableAdapter = new Cash_TTableAdapter())
		{
			try
			{
				cashTTableAdapter.Insert(code, type, new int?(bankCode), new int?(chkNumber));
				flag = true;
			}
			catch
			{
				throw new Exception("unable to insert new voucher");
			}
		}
		return flag;
	}
}