using System;
using Accounting.Code.AccountingDSTableAdapters;

public class EmployeeBll
{
	public EmployeeBll()
	{
	}

	public void deleteEmployee(int accCode)
	{
		using (EmployeeTableAdapter employeeTableAdapter = new EmployeeTableAdapter())
		{
			try
			{
				employeeTableAdapter.Delete(new int?(accCode));
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("unable to delete employee. ", exception.Message));
			}
		}
	}

	public EmployeeDataTable getEmployee()
	{
		EmployeeDataTable data;
		using (EmployeeTableAdapter employeeTableAdapter = new EmployeeTableAdapter())
		{
			try
			{
				data = employeeTableAdapter.GetData();
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("unable to get employees. ", exception.Message));
			}
		}
		return data;
	}

	public int getNextCode()
	{
		int num1;
		int num2;
		int num3;
		using (EmployeeTableAdapter employeeTableAdapter = new EmployeeTableAdapter())
		{
			try
			{
				int num4 = Convert.ToInt32(employeeTableAdapter.getLastEmployee());
				if (num4 == 0)
				{
					num3 = 241;
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
					throw new Exception(string.Concat("Could not get the next Code. ", exception.Message));
				}
			}
			catch (Exception exception)
			{
			}
		}
		return num3;
	}

	public void insertEmployee(string name, string nation, long? id, long? phone, string address, int accCode, string role, decimal balance)
	{
		using (EmployeeTableAdapter employeeTableAdapter = new EmployeeTableAdapter())
		{
			try
			{
				employeeTableAdapter.Insert(name, nation, id, address, phone, new int?(accCode), role, new decimal?(balance));
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("Error inserting employee. ", exception.Message));
			}
		}
	}

	public void updateEmployee(string name, string nation, long? id, long? phone, string address, int accCode, int oldAcc, string role, int EmID)
	{
		using (EmployeeTableAdapter employeeTableAdapter = new EmployeeTableAdapter())
		{
			try
			{
				employeeTableAdapter.Update(new int?(EmID), name, nation, id, address, phone, new int?(accCode), new int?(oldAcc), role);
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("Error updating employee. ", exception.Message));
			}
		}
	}
}