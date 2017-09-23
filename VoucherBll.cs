using System;
using Accounting.Code.AccountingDSTableAdapters;

public class VoucherBll
{
	public VoucherBll()
	{
	}

	public VoucherDataTable getVoucher(int VID)
	{
		VoucherDataTable voucherDataTable1;
		bool flag;
		VoucherTableAdapter voucherTableAdapter = new VoucherTableAdapter();
		try
		{
			try
			{
				VoucherDataTable voucherDataTable2 = new VoucherDataTable();
				voucherTableAdapter.Fill(voucherDataTable2, new int?(VID));
				try
				{
					voucherDataTable2[0].chkNumber;
					flag = 0 == 0;
				}
				catch
				{
					voucherDataTable2[0].chkNumber = 0;
				}
				voucherDataTable1 = voucherDataTable2;
			}
			catch
			{
				throw new Exception("Error getting the invoice information");
			}
		}
		finally
		{
			flag = voucherTableAdapter == null;
			if (!flag)
			{
				voucherTableAdapter.Dispose();
			}
		}
		return voucherDataTable1;
	}

	public VoucherDataTable getVoucherBydate(DateTime date)
	{
		VoucherDataTable voucherDataTable;
		using (VoucherTableAdapter voucherTableAdapter = new VoucherTableAdapter())
		{
			try
			{
				VoucherDataTable voucherByDate = voucherTableAdapter.GetVoucherByDate(new DateTime?(date));
				voucherDataTable = voucherByDate;
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("unable to get vouchers", exception.Message));
			}
		}
		return voucherDataTable;
	}

	public string getVoucherType(int voucherNum)
	{
		string str;
		using (VoucherTableAdapter voucherTableAdapter = new VoucherTableAdapter())
		{
			try
			{
				str = voucherTableAdapter.GetVoucherType(new int?(voucherNum)).ToString();
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("Unable to get voucher type", exception.Message));
			}
		}
		return str;
	}

	public bool insertVoucher(int cash, int DAcc, int CAcc, decimal amount, string type, int? bank, int? chkNumber, byte period, string desc, DateTime date)
	{
		bool flag;
		using (VoucherTableAdapter voucherTableAdapter = new VoucherTableAdapter())
		{
			try
			{
				voucherTableAdapter.addVoucher(new int?(cash), new int?(DAcc), new int?(CAcc), new decimal?(amount), type, bank, chkNumber, new byte?(period), new DateTime?(date), desc);
				flag = true;
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}
		}
		return flag;
	}

	public bool updateVoucher(int vnumber, int DAcc, int OldDAcc, int CAcc, int OldCAcc, decimal preAmount, decimal amount, string desc, int? chknumber, int? bank)
	{
		bool flag;
		using (VoucherTableAdapter voucherTableAdapter = new VoucherTableAdapter())
		{
			try
			{
				voucherTableAdapter.updateVoucher(new int?(vnumber), new int?(DAcc), new int?(OldDAcc), new int?(CAcc), new int?(OldCAcc), new decimal?(amount), new decimal?(preAmount), bank, chknumber, desc);
				flag = true;
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("unable to update the voucher", exception.Message));
			}
		}
		return flag;
	}
}