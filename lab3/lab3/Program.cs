using System;

namespace lab3
{
    partial class Customer
    {
        public static int id = 0;

        public string lastName;
        public string firstName;
        public string middleName;
        public string address;
        public int cardNumber;
        public int cardBalance;
        public int change;

        static readonly string Message = "You can only read me or edit in constructor";
        static Customer()
        {
            Console.WriteLine("This is static constructor");
            Console.WriteLine(Message);
        }

        public Customer() //конструктор
        {
            lastName = "Ivanov";
            firstName = "Ivan";
            middleName = "Ivanovich";
            address = "Pushkina 13";
            cardNumber = 15;
            cardBalance = 100;

            id++;
        }

        public Customer(string name1, string name2, string name3, string place, int number, int balance) //конструктор
        {
            lastName = name1;
            firstName = name2;
            middleName = name3;
            address = place;
            cardNumber = number;
            cardBalance = balance;

            id++;
        }

        public Customer(string name2, string name3, string place, int number = 20, int balance = 200, string name1 = "Tsyganok") //конструктор
        {
            lastName = name1;
            firstName = name2;
            middleName = name3;
            address = place;
            cardNumber = number;
            cardBalance = balance;

            id++;
        }

        public void addMoney()
        {
            Console.Write("how many? ");
            change = int.Parse(Console.ReadLine());
            cardBalance += cardBalance;
        }
        public void removeMoney()
        {
            Console.Write("how many? ");
            change = int.Parse(Console.ReadLine());
            cardBalance -= cardBalance;
        }
    }

    partial class Customer
    {
        public void Print() //метод вывода
        {
            Console.WriteLine();
            Console.WriteLine("Name: " + lastName + " " + firstName + " " + middleName);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Card Number: " + cardNumber);
            Console.WriteLine("Balance: " + cardBalance + " BYR");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int Size = 3;
            Customer[] customers = new Customer[Size];

            //Простой конструктор (без параметров)
            customers[0] = new Customer();
            customers[0].Print();


            //Конструктор с параметрами
            customers[1] = new Customer("Savelyev", "Dmitry", "Olegovich", "Vetebsk", 25, 100);
            customers[1].Print();

            //Конструктор с параметрами по умолчанию
            customers[2] = new Customer("Ilya", "Alexandrovich", "Minsk", balance: 100);
            customers[2].Print();

            Console.WriteLine(customers[0].ToString());

            Console.WriteLine(customers[0].Equals(customers[1]));

            Console.WriteLine(customers[0].GetHashCode());

            Console.WriteLine(customers[0].GetType());


            string[] lastNames = new string[Size];
            for (int i = 0; i < Size; i++)
            {
                lastNames[i] = customers[i].lastName;
            }

            Array.Sort(lastNames);
            for (int i = 0; i < Size; i++)
            {
                Console.Write(lastNames[i] + " ");
            }

            int min, max;

            Console.Write("range (min): ");
            min = int.Parse(Console.ReadLine());
            Console.Write("range (max): ");
            max = int.Parse(Console.ReadLine());

            for (int i = 0; i < Size; i++)
            {
                if (customers[i].cardNumber > min && customers[i].cardNumber < max)
                {
                    Console.Write(customers[i].cardNumber + " ");
                }
            }
        }
    }
}