using System;

namespace ConsoleApp4.Accounts
{
	internal class Account
	{
		public string Login { get; private set; }
		public string Password { get; private set; }
		public string Name { get; private set; }


		public Account(string login, string password, string name)
		{
			Login = login; Password = password; Name = name;
		}

		public override string ToString()
		{
			return string.Format("{0} {1} {2}", Login, Password, Name);
		}
	}
}
