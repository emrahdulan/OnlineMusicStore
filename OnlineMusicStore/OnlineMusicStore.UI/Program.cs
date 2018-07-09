using System;
using System.Windows.Forms;

namespace OnlineMusicStore.UI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var loginForm = new LoginForm();
			if (loginForm.ShowDialog() == DialogResult.OK)
			{
				if (Global.OnlineUser.RoleId == 1)
					Application.Run(new AdminMainForm());
				else
					Application.Run(new UserMainForm());
			}
		}
	}
}
