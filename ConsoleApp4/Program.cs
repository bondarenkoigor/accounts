using System;
using ConsoleApp4.Accounts;
using ConsoleApp4.Products;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin("admin", "admin", "admin");
            Account user = new Account("manager123", "qwerty", "manager1");
            Account user2 = new Account("123manager", "password", "manager2");
            Manager manager = admin.createManager(user);
            Manager manager2 = admin.createManager(user2);

            admin.logManager(manager);
            admin.logManager(manager2);

            Manager[] managers = admin.readManagers();
            Client client1 = managers[0].createClient(new Account("client123", "qwerty", "petya"));
            Client client2 = managers[1].createClient(new Account("123client", "password", "vasya"));

            client1.buyItem(managers[0], new Laptop());
            client1.buyItem(managers[0], new Bed());
            client2.buyItem(managers[1], new Sugar());
            client2.buyItem(managers[1], new Bayraktar());

            Console.WriteLine(managers[0].getSellHistory());
            Console.WriteLine(managers[1].getSellHistory());

            admin.clearLogs();
            managers[0].clearSellHistory();
            managers[1].clearSellHistory();
        }   
    }
}