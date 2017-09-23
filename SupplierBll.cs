using System;
using Accounting.Code.AccountingDSTableAdapters;

public class SupplierBll
{
	public SupplierBll()
	{
	}

	public bool deleteSupplier(int AccCode)
	{
		bool flag;
		using (SupplierTableAdapter supplierTableAdapter = new SupplierTableAdapter())
		{
			try
			{
				supplierTableAdapter.Delete(new int?(AccCode));
				flag = true;
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("Could not delete Supplier. ", exception.Message));
			}
		}
		return flag;
	}

	public int getNewCode()
	{
		int num1;
		int num2;
		int num3;
		using (SupplierTableAdapter supplierTableAdapter = new SupplierTableAdapter())
		{
			try
			{
				int num4 = Convert.ToInt32(supplierTableAdapter.getLastSupplier());
				if (num4 == 0)
				{
					num3 = 321;
				}
				else
				{
					if (num4 < 1000)
					{
						num1 = num4 % 10;
						num2 = Convert.ToInt32(num4 / 10);
					}
					else
					{
						if (num4 < 10000)
						{
							num1 = num4 % 100;
							num2 = Convert.ToInt32(num4 / 100);
						}
						else
						{
							num1 = num4 % 1000;
							num2 = Convert.ToInt32(num4 / 1000);
						}
					}
					num3 = Convert.ToInt32(string.Concat(int num5 = num1 + 1, num5.ToString()));
					throw new Exception(string.Concat("Could not insert supplier. ", exception.Message));
				}
			}
			catch (Exception exception)
			{
			}
		}
		return num3;
	}

	public SupplierDataTable getSuppliers()
	{
		SupplierDataTable data;
		using (SupplierTableAdapter supplierTableAdapter = new SupplierTableAdapter())
		{
			try
			{
				data = supplierTableAdapter.GetData();
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("Could not get suppliers. ", exception.Message));
			}
		}
		return data;
	}

	public bool insertSuppliers(string name, string pname, string address, long? phone, int accCode, decimal balance)
	{
		bool flag;
		using (SupplierTableAdapter supplierTableAdapter = new SupplierTableAdapter())
		{
			try
			{
				supplierTableAdapter.Insert(name, pname, address, phone, new int?(accCode), new decimal?(balance));
				flag = true;
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("Could not insert supplier. ", exception.Message));
			}
		}
		return flag;
	}

	public bool updateSuppliers(string name, string pname, string address, long? phone, int accCode, int suppID, int oldAcc)
	{
		bool flag;
		using (SupplierTableAdapter supplierTableAdapter = new SupplierTableAdapter())
		{
			try
			{
				supplierTableAdapter.Update(name, pname, address, phone, new int?(accCode), new int?(oldAcc), new int?(suppID));
				flag = true;
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("Could not update supplier. ", exception.Message));
			}
		}
		return flag;
	}
}