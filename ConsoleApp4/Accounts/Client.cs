using System;

namespace ConsoleApp4.Accounts
{
    internal class Client : Account
    {
        public Client(string login, string password, string name) : base(login, password, name) { }
        public Client(Account user) : base(user.Login, user.Password, user.Name) { }
        public void buyItem(Manager manager, Products.Product product)
        {
            manager.sellItem(product, this);
        }
    }
}
