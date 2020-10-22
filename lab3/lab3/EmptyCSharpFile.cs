using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба3
{
    partial class Train
    {
        public string Destination;
        int TrainNumber;
        public string Time;
        int PlacesCommon;
        int PlacesCoupe;
        int PlacesLuxury;
        int PlacesReserved;
        string value = "     ";
        string duration = "03:00";
        const string Class = "Business";
        static int Counter = 0;
        public int Size;

        /*private Train()
        {
            Console.WriteLine("This is private class, dude! Go on!");
        }*/
        public string Duration
        {
            get
            {
                return duration;
            }
            protected set
            {
                duration = value;
            }
        }
        static readonly string Message = "You can only read me or edit in constructor";
        static Train()
        {
            Console.WriteLine("This is static constructor");
            Console.WriteLine(Message);
        }

        public Train()
        {
            Destination = "Витебск";
            TrainNumber = 703;
            Time = "15:15";
            PlacesCommon = 50;
            PlacesCoupe = 30;
            PlacesLuxury = 16;
            PlacesReserved = 20;
            Counter++;
        }

        public Train(string Dest, int Numb, string Tim, int places1, int places2, int places3, int places4)
        {
            Destination = Dest;
            TrainNumber = Numb;
            Time = Tim;
            PlacesCommon = places1;
            PlacesCoupe = places2;
            PlacesLuxury = places3;
            PlacesReserved = places4;
            Counter++;
        }

        public Train(string Dest, int places1, int places2, int places3, int Numb = 606, int places4 = 25, string Tim = "11:40")
        {
            Destination = Dest;
            TrainNumber = Numb;
            Time = Tim;
            PlacesCommon = places1;
            PlacesCoupe = places2;
            PlacesLuxury = places3;
            PlacesReserved = places4;
            Counter++;
        }


        public void AllPlaces(ref Train tr, out int places)
        {
            places = tr.PlacesCommon + tr.PlacesCoupe + tr.PlacesLuxury + tr.PlacesReserved;

        }

        static void CounterOutput()
        {
            Console.WriteLine("Количество созданных экземпляров объекта Train равно {0}", Counter);
        }


    }

    partial class Train
    {
        public void Output()
        {
            Console.WriteLine($"Поезд под номером {this.TrainNumber}" +
                $" отправляется в {this.Destination}" +
                $" в {this.Time}." +
                $" Всего в поезде {this.PlacesCommon} общих мест, " +
                $"{this.PlacesCoupe} мест купе, " +
                $"{this.PlacesLuxury} мест люкс, " +
                $"{this.PlacesReserved} плацкартных мест");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int places, Size;
            Console.WriteLine("Введите размер массива классов Train: ");
            Size = Convert.ToInt32(Console.ReadLine());
            Train[] Trains = new Train[Size];

            //Простой конструктор (без параметров)
            Trains[0] = new Train();
            Trains[0].Output();


            //Конструктор с параметрами
            Trains[1] = new Train("Минск", 706, "6:33", 60, 45, 30, 40);
            Trains[1].Output();

            //Конструктор с параметрами по умолчанию
            Trains[2] = new Train("Минск", 60, 45, 30, places4: 30);
            Trains[2].Output();
            Trains[2].AllPlaces(ref Trains[2], out places);
            Console.WriteLine("Количество мест в поезде: {0}", places);

            //Trains[0].CounterOutput();

            Console.WriteLine($"Строка представляющая объект Trains: {Trains[0].ToString()}");

            Console.WriteLine($"Экземпляры Trains[0] и Trains[1] равны: {Trains[0].Equals(Trains[1])}");

            Console.WriteLine($"Хеш-код экземпляра Trains[0]: {Trains[0].GetHashCode()}");

            Console.WriteLine($"Тип экземпляра Trains[0]: {Trains[0].GetType()}");

            string dest;
            Console.WriteLine("Поезд с каким направлением вы хотите найти?");
            dest = Convert.ToString(Console.ReadLine());

            //Поиск поездов по месту прибытия
            for (int i = 0; i < Size; i++)
            {
                if (Trains[i].Destination == dest)
                {
                    Trains[i].Output();
                    break;
                }
            }

            Console.WriteLine("Поезд с каким направлением вы хотите найти?");
            dest = Convert.ToString(Console.ReadLine());
            string time;
            Console.WriteLine("После какого времени должен отправляться поезд?");
            time = Convert.ToString(Console.ReadLine());

            //Поиск поездов по месту прибытия и следующих после определенного времени
            for (int i = 0; i < Size; i++)
            {
                if (Trains[i].Destination == dest)
                {
                    int hour1, hour2, minute1, minute2;
                    char ch;
                    //hour1 = 
                    ch = Trains[0].Time[0];
                    hour1 = (int)Char.GetNumericValue(Trains[0].Time[0]) * 10 + (int)Char.GetNumericValue(Trains[0].Time[1]);
                    //Console.WriteLine(hour1);
                    minute1 = (int)Char.GetNumericValue(Trains[0].Time[3]) * 10 + (int)Char.GetNumericValue(Trains[0].Time[4]);
                    hour2 = (int)Char.GetNumericValue(time[0]) * 10 + (int)Char.GetNumericValue(time[1]);
                    minute2 = (int)Char.GetNumericValue(time[3]) * 10 + (int)Char.GetNumericValue(time[4]);

                    if (((hour1 == hour2) && minute1 > minute2) || hour1 > hour2)
                    {
                        Trains[i].Output();
                        break;
                    }

                    Trains[i].Output();
                    break;
                }
            }


            var t = new { Destination = "Брест", Number = 702, Time = "11:10", PlacesCoupe = 60, PlacesCommon = 42, PlacesLuxury = 30, PlacesReserved = 20 };


        }
    }
}