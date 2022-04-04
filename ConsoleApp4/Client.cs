using System;

namespace ConsoleApp4
{
    internal class Client : Account
    {
        public Client(string login, string password, string name) : base(login, password, name) { }
        
        //public void buyItem(string itemName)
        //{
        //    Manager.sellItem(itemName);
        //}
    }
}
