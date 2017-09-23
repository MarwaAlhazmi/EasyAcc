using System;
using Accounting.Code.AccountingDSTableAdapters;

public class ClientBll
{
	public ClientBll()
	{
	}

	public void deleteClient(int accCode)
	{
		using (ClientTableAdapter clientTableAdapter = new ClientTableAdapter())
		{
			try
			{
				clientTableAdapter.Delete(new int?(accCode));
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("unable to delete Client. ", exception.Message));
			}
		}
	}

	public ClientDataTable getClient()
	{
		ClientDataTable client;
		using (ClientTableAdapter clientTableAdapter = new ClientTableAdapter())
		{
			try
			{
				client = clientTableAdapter.GetClient();
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("unable to get Clients. ", exception.Message));
			}
		}
		return client;
	}

	public int getNextCode()
	{
		int num1;
		int num2;
		int num3;
		using (ClientTableAdapter clientTableAdapter = new ClientTableAdapter())
		{
			try
			{
				int num4 = Convert.ToInt32(clientTableAdapter.getLastClient());
				if (num4 == 0)
				{
					num3 = 231;
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

	public void insertClient(string name, string nation, long? id, long? phone, string address, int accCode, decimal balance)
	{
		using (ClientTableAdapter clientTableAdapter = new ClientTableAdapter())
		{
			try
			{
				clientTableAdapter.Insert(name, nation, id, address, phone, new int?(accCode), new decimal?(balance));
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("Error inserting client. ", exception.Message));
			}
		}
	}

	public void updateClient(string name, string nation, long? id, long? phone, string address, int accCode, int oldAcc, int clientID)
	{
		using (ClientTableAdapter clientTableAdapter = new ClientTableAdapter())
		{
			try
			{
				clientTableAdapter.Update(new int?(clientID), name, nation, id, address, phone, new int?(accCode), new int?(oldAcc));
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("Error updating Client. ", exception.Message));
			}
		}
	}
}