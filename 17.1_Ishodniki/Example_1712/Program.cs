using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_1712
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder()
            {
                DataSource = @"(localdb)\MSSQLLocalDB",
                InitialCatalog = "MSSQLLocalDemo",
                IntegratedSecurity = true,
                // UserID = "Admin", Password = "qwerty"
                Pooling = !false
            };

            Console.WriteLine($"Строка подключения: {strCon.ConnectionString}");

            SqlConnection sqlConnection;

            var date = DateTime.Now;

            int n = 300000;

            for (double i = 1; i <= n; i++)
            {
                //Console.Write(".");
                sqlConnection = new SqlConnection() { ConnectionString = strCon.ConnectionString };

                try
                {
                    sqlConnection.Open(); // Открыть соединение с БД 
                }
                finally
                {
                    sqlConnection.Close();// Закрыть соединение с БД 
                }
            }

            Console.WriteLine($"\n {n} Подключений за ~{(int)(DateTime.Now-date).TotalSeconds} сек.");
        }
    }
}
