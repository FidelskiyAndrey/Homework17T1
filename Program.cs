using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17T1
{
    class Program
    {
        static void Main(string[] args)
        {

            Account<int> account1 = new Account<int>(5, 1000, "Фидэльский Андрей Александрович");

            Account<string> account2 = new Account<string>("005", 1000, "Фидэльский Андрей Александрович");


            print<int>(12);
            print<string>("привет");

            Console.ReadKey();
        }
      
        
        static void print<T>(T value)
        {
            Console.WriteLine(value);
        }

    }

    public class Account<T>
    {

        private T Number { get; set; }
        private double Balance { get; set; }
        private string Name { get; set; }



        public Account(T number, double balance, string name)
        {
            Number = number;
            Balance = balance;
            Name = name;
        }

      

    }


}
