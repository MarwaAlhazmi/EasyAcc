using System;
using Accounting.Code.AccountingDSTableAdapters;
using System.Management;
using System.Text;
using System.Security.Cryptography;

namespace Accounting.Code.Bll
{
internal class Check
{
	public Check()
	{
	}

	public bool autherized(out string name)
	{
		string str;
		Sec_TTableAdapter secTTableAdapter;
		bool flag;
		try
		{
			str = "";
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * From Win32_processor");
			foreach (ManagementObject managementObject in managementObjectSearcher.Get())
			{
				str = managementObject["ProcessorID"].ToString();
			}
			if (string.IsNullOrEmpty(str))
			{
				throw new Exception("No Data");
			}
			secTTableAdapter = new Sec_TTableAdapter();
		}
		catch (Exception exception)
		{
			throw new Exception(exception.Message);
		}
		try
		{
			Sec_TDataTable dataByValue = secTTableAdapter.GetDataByValue("PR", this.hash(str));
			if (dataByValue.Count && dataByValue[0].Value == this.hash(str))
			{
				flag = true;
			}
			else
			{
				flag = false;
				if (secTTableAdapter != null)
				{
					secTTableAdapter.Dispose();
				}
			}
		}
		finally
		{
		}
		return flag;
	}

	private static string ByteArrayToString(byte[] arrInput)
	{
		StringBuilder stringBuilder = new StringBuilder((int)arrInput.Length);
		for (int i = 0; i < (int)arrInput.Length; i++)
		{
			stringBuilder.Append(arrInput[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	private string hash(string value)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(value);
		byte[] numArray = new MD5CryptoServiceProvider().ComputeHash(bytes);
		return Check.ByteArrayToString(numArray);
	}
}
}