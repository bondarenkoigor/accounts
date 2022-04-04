using System;
using System.IO;

namespace ConsoleApp4.Accounts
{
    internal class Manager : Account
    {
        public Manager(string login, string password, string name) : base(login, password, name) { }

        public Manager(Account account) : this(account.Login, account.Password, account.Name) { }
        public Client createClient(Account user)
        {
            return new Client(user);
        }
        public void sellItem(Products.Product product, Client client)
        {
            File.AppendAllText(Login + ".txt", Name + " продал " + product.Name + " клиенту " + client.Name + " за " + product.Price + "грн\n");
        }
        public string getSellHistory()
        {
            return File.ReadAllText(Login + ".txt");
        }
        public void clearSellHistory()
        {
            if (!File.Exists(Login + ".txt")) return;
            File.WriteAllText(Login + ".txt", "");
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
