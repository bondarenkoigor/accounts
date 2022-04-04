using System;
using System.IO;

namespace ConsoleApp4
{
    internal class Admin : Account
    {
        public Admin(string login, string password, string name) : base(login, password, name) { }

        public override string ToString()
        {
            return base.ToString();
        }

        public Manager createManager(Account account)
        {
            return new Manager(account);
        }

        public void logManager(string path, Manager manager)
        {
            File.AppendAllText(path, manager.ToString() + "\n");
        }

        public void logManager(Manager manager)
        {
            logManager(string.Format($"{Login}.txt"), manager);
        }

        public Manager[] readManagers()
        {
            if (!File.Exists(Login + ".txt")) return null;
            string[] managers = File.ReadAllLines(Login + ".txt");
            Manager[] result = new Manager[managers.Length];
            for(int i = 0; i < managers.Length; i++)
            {
                string[] iManagerSplit = managers[i].Split(" ");
                result[i] = new Manager(iManagerSplit[0], iManagerSplit[1], iManagerSplit[2]);
            }

            return result;
        }
    }
}
