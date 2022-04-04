using System;


namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin("admin", "admin", "vasya");
            //Account user = new Account("login123", "qwerty", "petya");
            //Account user2 = new Account("123login", "password", "user123");
            //Manager manager = admin.createManager(user);
            //Manager manager2 = admin.createManager(user2);

            //admin.logManager(manager);
            //admin.logManager(manager2);

            Manager[] managers = admin.readManagers();

            for(int i = 0; i < managers.Length; i++)
            {
                Console.WriteLine(managers[i]);
            }
        }
    }
}