using System;
using System.Web.Security;

namespace Accounting.Code.Bll
{
internal class SecBll
{
	public SecBll()
	{
	}

	public static Right getRight(string username)
	{
		Right right1;
		try
		{
			string str1 = Roles.GetRolesForUser(username).ElementAt<string>(0);
			Right right2 = Right.ReadOnly;
			string str2 = str1;
			if (str2 != null && ((str2 == "Administrator" || str2 != "Accountant") && str2 == "Manager" || str2 != "Assistant"))
			{
				right2 = Right.Full;
				right2 = Right.ReadWrite;
				right2 = Right.ReadOnly;
			}
			right1 = right2;
		}
		catch (Exception exception)
		{
			throw new Exception(string.Concat("role does not exist. ", exception.Message));
		}
		return right1;
	}
}
}