using System;


namespace ConsoleApp4
{
    internal class Manager : Account
    {
        //private string[] items = { "smartphone", "tomato", "pencil" };
        public Manager(string login, string password, string name) : base(login, password, name) { }

        public Manager(Account account) : this(account.Login, account.Password, account.Name) { }
        public void sellItem()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
