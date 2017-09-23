using System;
using System.Windows.Forms;
using Accounting.Code.Bll;

namespace Accounting
{
internal static class Program
{
	[STAThread]
	private static void Main()
	{
		string str;
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Check check = new Check();
		Application.Run(new Form1());
	}
}
}