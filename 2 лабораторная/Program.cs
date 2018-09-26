using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* Типы *");

            //Определите переменные всех возможных примитивных типов С#  и проинициализируйте их

            sbyte sb = 1;
            short i16 = 1;
            int i32 = 1;
            long i64 = 1;
            byte bt = 1;
            ushort ut16 = 1;
            uint ut32 = 1;
            ulong ut64 = 1;
            char ch = 'c';
            bool bl = false;
            float ft = 1;
            double db = 1.2;
            decimal dcm = 1;
            string str = "hello";
            object obj = 1;

            //Выполните 5 операций явного и 5 неявного приведения

            //неявное приведение
            long Imp1 = i32;
            Single Imp2 = i32;
            int Imp3 = i16;
            ulong Imp4 = ut32;
            uint Imp5 = ut16;
            //явное приведение
            Byte Imp6 = (Byte)i32;
            short Imp7 = (short)Imp2;
            Byte Imp8 = (Byte)i64;
            short Imp9 = (short)i64;
            int Imp10 = (int)bt;

            //Выполните упаковку и распаковку значимых типов. 

            int Num = 3;
            Object Box = Num;
            byte Unbox = (byte)(int)Box;

            //Продемонстрируйте работу с неявно типизированной переменной. 

            var Number1 = 1.13;
            var Number2 = 20;
            var Number3 = Number1 + Number2;
            Console.WriteLine($"Работа с неявно типизированной переменной: {Number3}");

            //Продемонстрируйте пример работы с Nullable переменной

            int? Nullable = null;
            int? Nullable1 = null;
            Console.WriteLine($"Работа с Nullable переменной: { Nullable == Nullable1}");
            Console.WriteLine("---");

            Console.WriteLine("* Строки *");

            //Объявите строковые литералы. Сравните их

            String Str1 = "My Favotite String";
            String Str2 = "IHaveThisString";
            String Str3 = "ThisStringIsNormal";

            // Создайте три строки на основе String. Выполните: сцепление, копирование, 
            //выделение подстроки, разделение строки на слова, вставки подстроки в заданную позицию, 
            //удаление заданной подстроки. 

            Console.WriteLine($"Сцепление строк (конкатенация): {String.Concat(Str1, Str2)}");
            String StrCopy = String.Copy(Str1);
            Console.WriteLine($"Копирование: {StrCopy}");
            Console.WriteLine($"Выделение подстроки: {Str1.Substring(2)}");
            Console.WriteLine("Разбитие строки на слова: (");
            string[] words = Str1.Split(' ');
            foreach (string word in words)
                Console.WriteLine(word);
            Console.WriteLine(")");
            Console.WriteLine($"Вставка подстроки в заданную позицию: {Str1.Insert(0, "Подстрока: ")}");
            Console.WriteLine($"Удаление заданной подстроки: {Str1.Remove(2, 9)}");

            //Создайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками 

            String Empty = "";
            String NullStr = null;
            String Conc = String.Concat(Empty, NullStr);
            Console.WriteLine(Conc);

            //Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в 
            //начало и конец строки
            Console.WriteLine("---StringBuilder---");
            StringBuilder StrBuild = new StringBuilder("STR", 50);
            Console.WriteLine($"Удаление определенный позиций: {StrBuild.Remove(0, 1)}");
            Console.WriteLine($"Новые символы в начале строки: {StrBuild.Append("DIEF")}");
            Console.WriteLine($"Новые символы в конце строки: {StrBuild.Insert(0, "Start ")}");
            Console.WriteLine("---");

            Console.WriteLine("* Массивы *");

            //Создайте целый двумерный массив и выведите его на консоль в отформатированном виде (матрица)

            int[,] Matrix = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(Matrix[i, j] + " ");
                Console.WriteLine();
            }

            //Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива. 
            //Поменяйте произвольный элемент (пользователь определяет позицию и значение). 

            String[] MassStr = { "one", "two", "three", "four" };
            Console.WriteLine("Длинна массива: " + MassStr.GetLength(0) + " содержимое:");
            for (int i = 0; i < MassStr.GetLength(0); i++)
            {
                Console.WriteLine(MassStr[i]);
            }
            Console.WriteLine("Какой элемент и на что поменять?");
            String ElemNum = Console.ReadLine();
            String ElemVal = Console.ReadLine();
            int ElemNum1 = Convert.ToInt32(ElemNum);
            MassStr[ElemNum1] = ElemVal;
            for (int i = 0; i < MassStr.GetLength(0); i++)
            {
                Console.WriteLine(MassStr[i]);
            }

            //Создайте ступечатый (не выровненный) массив вещественных чисел с 3-мя строками,
            //в каждой из которых 2, 3 и 4 столбцов соответственно. Значения массива введите с консоли. 

            float[][] Jagged = { new float[2], new float[3], new float[4] };

            for (int i = 0; i < 2; i++)
            {
                String JNum = Console.ReadLine();
                Jagged[0][i] = Convert.ToInt32(JNum);
            }

            for (int i = 0; i < 3; i++)
            {
                String JNum = Console.ReadLine();
                Jagged[1][i] = Convert.ToInt32(JNum);
            }

            for (int i = 0; i < 4; i++)
            {
                String JNum = Console.ReadLine();
                Jagged[2][i] = Convert.ToInt32(JNum);
            }

            foreach (float[] x in Jagged)
            {
                foreach (int b in x) Console.Write("\t" + b);
                Console.WriteLine();

            }

            //Создайте неявно типизированные переменные для хранения массива и строки.

            var NoArray = new object[0];
            var NoStr = "";

            Console.WriteLine("---");

            Console.WriteLine("* Кортежи *");

            //Задайте кортеж из 5 элементов с типами int, string, char, string, ulong. 

            (int, string, char, string, ulong) Tuple;

            //Сделайте именование его элементов

            (int number, string str1, char ch, string str2, ulong ul) Tuple1 = (22, "one", 'o', "oneo", 1);

            //Выведите кортеж на консоль целиком и выборочно (1, 3, 4  элементы) 

            Console.WriteLine($"{Tuple1}");
            Console.WriteLine(Tuple1.number + " " + Tuple1.ch + " " + Tuple1.str2);

            //Выполните распаковку кортежа в переменные.

            var (one, two, three, four, five) = Tuple1;

            //Сравните два кортежа. 

            var Type_1 = (a: 24, b: 'Q');
            var Type_2 = (c: 11, d: "helicopter");
            Console.WriteLine("Кортежи {0} и {1} - {2}", Type_1, Type_2, Object.Equals(Type_1, Type_2) ? "равны\n" : "не равны\n");

            Console.WriteLine("---");

            //Создайте локальную функцию в main и вызовите ее. Формальные параметры функции – массив целых и строка. 
            //Функция должна вернуть кортеж, содержащий: максимальный и минимальный элементы массива, 
            //сумму элементов массива и первую букву строки 

            (int, int, int, char) MainFunction(int[] arr, string strng)
            {
                return (arr.Max(), arr.Min(), arr.Sum(), strng.First());
            }

            Console.WriteLine("Введите целые числа: ");
            int[] Task = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Task[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите строку: ");
            string Task2 = Console.ReadLine();
            Console.WriteLine(MainFunction(Task, Task2));
            Console.ReadKey();
        }
    }
}