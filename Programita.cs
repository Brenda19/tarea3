
using System;
using System.Windows.Forms;

namespace t3
{
	
	internal sealed class Programita
	{
			
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new A());
		}
		
	}
}
