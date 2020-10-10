using System;
using System.Text;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("\nTask 1\n");
            //a
            //типы переменных
            bool var1 = true;
            byte var2 = 2;
            sbyte var3 = -7;
            short var4 = 32700;
            ushort var5 = 52432;
            int var6 = -8900600;
            uint var7 = 4000000000;
            long var8 = -123123123123;
            ulong var9 = 121212121212;
            float var10 = 12.12F;
            double var11 = 12.121212;
            char var12 = 'h';
            string var13 = "artemka";
            object var14 = "hello, world";
            decimal var15 = 10.6m;

            //вывод
            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);
            Console.WriteLine(var4);
            Console.WriteLine(var5);
            Console.WriteLine(var6);
            Console.WriteLine(var7);
            Console.WriteLine(var8);
            Console.WriteLine(var9);
            Console.WriteLine(var10);
            Console.WriteLine(var11);
            Console.WriteLine(var12);
            Console.WriteLine(var13);
            Console.WriteLine(var14);
            Console.WriteLine(var15);

            //b
            //неявное приведение
            int a1 = 2147483647;
            long a2 = a1;

            sbyte b1 = -10;
            short b2 = b1;

            long c1 = 123123123;
            float c2 = c1;

            float d1 = 12.312f;
            double d2 = d1;

            byte e1 = 15;
            uint e2 = e1;

            //явное приведение
            char aa1 = 'h';
            int aa2 = (char)aa1;

            short bb1 = 21;
            int bb2 = (short)bb1;

            sbyte cc1 = -3;
            short cc2 = (sbyte)cc1;

            uint dd1 = 12;
            float dd2 = (uint)dd1;

            float ee1 = 1.213f;
            double ee2 = (float)ee1;

            //c
            //упаковка и распоковка

            int box1 = 90;
            object obj1 = box1;
            int box2 = (int)obj1;

            char box3 = '.';
            object obj2 = box3;
            char box4 = (char)obj2;

            //d
            //работа с неявно типизированными переменными
            var text = "HELLO";
            Console.WriteLine(text.GetType());

            //e
            //Nullable переменная
            System.Nullable<double> null1 = null;
            null1 = 1.1;
            Console.WriteLine(null1.GetType());

            //2
            Console.WriteLine("\nTask 2\n");
            //a
            //Строковые литералы, сравнение строк
            Console.WriteLine("comparison of string literals:");

            int result = String.Compare("ac","ca");
            if (result < 0)
            {
                Console.WriteLine("first string is first (alphabetical)");
            }
            else if (result > 0)
            {
                Console.WriteLine("second string is first (alphabetical)");
            }
            else
            {
                Console.WriteLine("strings are equal (alphabetical)");
            }

            //b
            string first = "me";
            string second = "you";
            string third = "Dima";

            //сцепление 1
            string str1 = first + ", " + second + " and " + third;
            Console.WriteLine(str1);

            //сцепление 2
            string str2 = String.Concat(first, ", ", second, " and ", third, " inc. ");
            Console.WriteLine(str2);

            //копирование
            string str3 = String.Copy(third);
            Console.WriteLine(str3 + " Savelyev");

            //выделение подстроки
            Console.WriteLine(str1.Substring(4, 12));

            //разделение строки на слова
            string[] words = str1.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

            //вставка подстроки в заданную позицию
            string mod = str1.Insert(8, words[1] + " ");
            Console.WriteLine(mod);

            //c
            //пустые и null-строки
            string str4 = null;
            string str5 = "";
            Console.WriteLine(string.IsNullOrEmpty(str4));
            Console.WriteLine(string.IsNullOrEmpty(str5));

            //d
            StringBuilder alphabet = new StringBuilder("abcdefg");
            Console.WriteLine(alphabet);
            alphabet.Remove(1, 2);
            Console.WriteLine(alphabet);
            alphabet.Insert(alphabet.Length, " - asdasf");
            Console.WriteLine(alphabet);

            //3
            Console.WriteLine("\nTask 3\n");
            //a
            //матрица
            Console.WriteLine("Matrix:");
            int[,] Matrix = new int[4, 4];
            Random Elem = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Matrix[i, j] = Elem.Next(1, 10);
                    Console.Write("{0}  ", Matrix[i, j]);
                }
                Console.WriteLine();
            }
            //b
            //одномерный массив строк
            string[] Arr = { "arr1", "arr2", "arr3", "arr4" };
            for (int i = 0; i < 4; i++) 
            {
                Console.Write(Arr[i] + " ");
            }
            Console.WriteLine("array's length: {0}", Arr.Length);

            Console.WriteLine("array element number: ");
            int number;
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("element value: ");
            string value = Console.ReadLine();

            Arr[number] = value;

            Console.WriteLine("new array: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(Arr[i] + " ");
            }
            Console.WriteLine();

            //c
            //ступенчатый массив
            int[][] stepArr = new int[4][];
            stepArr[0] = new int[2];
            stepArr[1] = new int[3];
            stepArr[2] = new int[4];

            Console.WriteLine("first arrays's string (2 elements): ");
            for (int i = 0; i < 2; i++)
            {
                stepArr[0][i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("second arrays's string (3 elements): ");
            for (int i = 0; i < 3; i++)
            {
                stepArr[1][i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("third arrays's string (4 elements): ");
            for (int i = 0; i < 4; i++)
            {
                stepArr[2][i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("stepped array: ");
            for (int i = 0; i < 2; i++)
            {
                Console.Write(stepArr[0][i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(stepArr[1][i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write(stepArr[2][i] + " ");
            }
            Console.WriteLine();

            //d
            //неявно типизированные переменные для строки и массива
            var str6 = "hello again";
            Console.WriteLine(str6);
            var arr = new[] { 1, 2, 3 };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

            //4
            Console.WriteLine("\nTask 4\n");
            //a
            //создание кортежа
            (int, string, char, string, ulong) tuple = (2048, "oh hi Mark", 'd', "I DID NOT", 100001000010000);

            //вывод кортежа
            Console.WriteLine(tuple); //целиком
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4);

            //распаковка кортежа в переменные
            int t1 = tuple.Item1;
            string t2 = tuple.Item2;
            char t3 = tuple.Item3;
            string t4 = tuple.Item4;
            ulong t5 = tuple.Item5;

            //сравнение кортежей
            (int, string, char, string, ulong) tuple1 = (2048, "oh hi Mark", 'd', "I DID NOT", 100001000010000);
            if (tuple == tuple1)
            {
                Console.WriteLine("tuples are equal");
            }
            else Console.WriteLine("tuples are NOT equal");

            //5
            Console.WriteLine("\nTask 5\n");
            //локальная функция
            int[] arrF = { 40, 45, 12, 8, 32 };
            Console.WriteLine("integer array:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arrF[i] + " ");
            }
            Console.WriteLine();
            string strF = "Potapov";
            Console.Write("string:");
            Console.WriteLine(strF);

            var tupleF = localFunc(arrF, strF);
            Console.Write("function result: ");
            Console.WriteLine(tupleF);

            (int, int, int, string) localFunc(int[] arrFunc, string strFunc)
            {
                (int Max, int Min, int Sum, string First) resultF = (arrFunc[0], arrFunc[0], 0, " ");
                resultF.First = strFunc.Remove(1); //вырезаем 1 букву из строки
                for (int i = 0; i < arrFunc.Length; i++)
                {
                    resultF.Sum += arrFunc[i];
                }
                for (int i = 0; i < arrFunc.Length; i++)
                {
                    if (resultF.Max < arrFunc[i])
                    {
                        resultF.Max = arrFunc[i];
                    }
                }
                for (int i = 0; i < arrFunc.Length; i++)
                {
                    if (resultF.Min > arrFunc[i])
                    {
                        resultF.Min = arrFunc[i];
                    }
                }
                return resultF;
            }

        }
    }
}