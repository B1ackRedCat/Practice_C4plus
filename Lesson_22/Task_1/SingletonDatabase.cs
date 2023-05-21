using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class SingletonDatabase
    {
        private static SingletonDatabase instance = null;
        private static string databaseUrl = "google.com";
        private SingletonDatabase()
        {
            Console.WriteLine("Подключение инициализировано к " + databaseUrl);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static SingletonDatabase GetInstance()
        {
            if (instance == null)
            {
                instance = new SingletonDatabase();
            }
            return instance;
        }

        public void Query(string sql)
        {
            Console.WriteLine("Выполняемый запрос: " + sql);
        }
    }
}
