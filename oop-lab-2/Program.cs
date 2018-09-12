using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //a Определите переменные всех возможных примитивных типов С#  и проинициализируйте их.   
            bool trueOrFalse = true;//System.Boolean
            int age1 = 24; //System.Int32
            float age2 = 24;//System.Single
            sbyte level = 23;//System.SByte
            short value = -1109;//System.UInt16
            long range = -7091821871L;//System.Int64
            byte age4 = 62;//System.Byte
            ushort value2 = 42019;//System.UInt16
            uint totalScore = 1151092;//System.UInt32
            ulong range2 = 17091821871L;//System.UInt64
            double value3 = -11092.53D;//System.Double
            char ch2 = 'x';//System.Char
            decimal bankBalance = 53005.25M;//System.Decimal

            //b  Выполните 5 операций явного и 5 неявного приведения. 

            // явный
            double x = 1.2;
            int b1 = (int)x;
            float b2 = (float)x;
            short b3 = (short)b1;
            int b4 = (int)value;
            x = (double)b1;

            // не явный
            int y = 123434234;
            long a = y;
            double a1 = y;

            //c Выполните упаковку и распаковку значимых типов. 

            //Упаковка представляет собой процесс преобразования типа значения в тип object или в любой другой тип интерфейса, реализуемый этим типом значения. Когда тип значения упаковывается средой CLR, она создает оболочку значения внутри System.Object и сохраняет ее в управляемой куче. Операция распаковки извлекает тип значения из объекта. Упаковка является неявной; распаковка является явной.

            //упаковка
            int i = 12323;
            object o = i;

            //распаковка

            o = 1232132;
            int u = (int)o;
            //

            //d Продемонстрируйте работу с неявно типизированной переменной

            var var1 = "sd";
            var var2 = 23232;
            //object

            //e Продемонстрируйте пример работы с Nullable переменной. 

            Nullable<bool> per1 = null;
            int? per2 = null;
            int? per3 = null;//но не выводится 


            if (per2 == per3)
            {
                //Console.WriteLine("True");
            }

            //2 

            //a Объявите строковые литералы. Сравните их. 
            String str1 = "12345";
            String str2 = "1234567";

            if (str1 == str2)
            {
                //Console.WriteLine("Cравнение строк по содержанию");
            }
            else
            {
                //Console.WriteLine("Cравнение строк по содержанию");
            }


            /*b. Создайте три строки на основе String.
             * Выполните: сцепление, копирование, выделение подстроки,
             * разделение строки на слова, вставки подстроки в заданную позицию,
             * удаление заданной подстроки. */

            string s1 = "Artem";
            string s2 = "Radchicov";

            //сцепление
            Console.WriteLine("сцепление");
            string s3 = String.Concat(s1, ' ', s2, "!!!"); //cцепление
            Console.WriteLine(s3);
            Console.WriteLine();

            //копирование
            Console.WriteLine("копирование");
            string s4 = String.Copy(s1 + s2);
            Console.WriteLine(s4);
            Console.WriteLine();

            //выделение подстроки
            Console.WriteLine("выделение подстроки");
            string s5 = s2.Substring(0, s2.Length - 3);
            Console.WriteLine(s5);
            Console.WriteLine();

            //разделение строки на слова
            Console.WriteLine("разделение строки на слова");
            string[] s6 = (s1 + ' ' + s1 + ' ' + s2 + ' ' + s2).Split(new char[] { ' ' });
            foreach (string s in s6)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            //вставки подстроки в заданную позицию
            Console.WriteLine("вставки подстроки в заданную позицию");
            string text = "Хороший день";
            string subString = "замечательный ";

            text = text.Insert(8, subString);
            Console.WriteLine(text);
            Console.WriteLine();

            //удаление заданной подстроки
            Console.WriteLine("удаление заданной подстроки");

            text = text.Remove(text.Length - 10);
            Console.WriteLine(text);
            Console.WriteLine();

            //c. Создайте пустую и null строку. 
            //Продемонстрируйте что можно выполнить с такими строками 
            string empty = "";
            Console.WriteLine(empty == ""); // True
            Console.WriteLine(empty == string.Empty); // True
            Console.WriteLine(empty.Length == 0); // True

            string nullString = null;
            Console.WriteLine(nullString == null); // True
            Console.WriteLine(nullString == ""); // False
                                                 // Console.WriteLine(nullString.Length == 0); // NullReferenceException

            /*string.IsNullOrEmpty позволяет проверить является
             * ли строка null или пустой.*/
            /* попытка вызвать метод для строки null вызовет 
             * исключение NullReferenceException. строки null можно использовать 
             * в операциях объединения и сравнения с другими строками*/
            Console.WriteLine();

            /*d. Создайте строку на основе StringBuilder. 
             * Удалите определенные позиции и добавьте новые символы в 
             * начало и конец строки*/

            StringBuilder sb = new StringBuilder("123456789 10");
            Console.WriteLine("Длина строки: {0}", sb.Length);
            Console.WriteLine("Емкость строки: {0}", sb.Capacity);

            StringBuilder sb1 = new StringBuilder(20);//начальная ёмкость 20

            sb.Remove(6, 2);//удалене 2 символов начиная с 6

            Console.WriteLine(sb);
            Console.WriteLine("Длина строки: {0}", sb.Length);
            Console.WriteLine("Емкость строки: {0}", sb.Capacity);

            sb.Append("Добавление в конец");
            Console.WriteLine(sb);

            sb.Insert(0, "Добавление в начало");
            Console.WriteLine(sb);
            Console.WriteLine();

            //3) Массивы
            /*a. Создайте целый двумерный массив и выведите его на консоль
             * в отформатированном виде (матрица).*/

            int[,] nums1;
            int[,] nums2 = new int[2, 3];
            int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };

            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            for (i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /*b. Создайте одномерный массив строк. 
             * Выведите на консоль его содержимое, длину массива.
             * Поменяйте произвольный элемент (пользователь 
             * определяет позицию и значение). */

            string[] masString = new string[4] { "Меня ", "зовут ", "Артем ", "Радчиков." };
            foreach (string st in masString)
            {
                Console.Write(st);
            }
            Console.WriteLine();

            Console.WriteLine("Размер массива: " + masString.Length);

            Console.Write("Введите позицию: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (masString.Length - 1 < choice)
            {
                Console.WriteLine("нет такого элемента");
            }
            else
            {
                Console.Write("Введите значение: ");
                string newValue = Console.ReadLine();
                masString[choice] = newValue;
                foreach (string st in masString)
                {
                    Console.Write(st);
                }
            }

            Console.WriteLine();

            /*c. Создайте ступечатый (не выровненный) массив вещественных 
             * чисел с 3-мя строками, в каждой из которых 2, 3 и 4 столбцов
             * соответственно. Значения массива введите с консоли.*/

            double[][] masDouble = new double[3][];
            masDouble[0] = new double[2];
            masDouble[1] = new double[3];
            masDouble[2] = new double[4];

            Console.WriteLine("Введите значения для элементов массива:");

            for (i = 0; i < masDouble.Length; i++)
            {
                for (int j = 0; j < masDouble[i].Length; j++)
                {
                    //masDouble[i][j] = Convert.ToInt64(Console.ReadLine());
                    masDouble[i][j] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (i = 0; i < masDouble.Length; i++)
            {
                for (int j = 0; j < masDouble[i].Length; j++)
                {
                    Console.Write($"{masDouble[i][j]}\t");
                }
                Console.WriteLine();
            }
            /*d. Создайте неявно типизированные переменные для хранения
             * массива и строки*/

            var masVarForMas = new[]
            {
                new[]{1,2,3,4},
                new[]{5,6,7,8},
            };
            var masVarForString = new[] { "Это", "массив", "для", "строк" };

            //4) Кортежи

            /*a. Задайте кортеж из 5 элементов с типами 
             * int, string, char, string, ulong*/

            (int, string, char, string, ulong) tuple1 = (18, "Артем", 'Д', "Радчиков", 611L);

            // b.Сделайте именование его элементов
            (int, string, char, string, ulong) tuple2 = (Age: 18, name: "Артем", patronymic: 'Д', surname: "Радчиков", typeUlong: 611L);
            var tuple3 = (Age: 18, name: "Артем", patronymic: 'Д', surname: "Радчиков", typeUlong: 565656565611L);

            var (аgeForTuple, name, patronymic, surname, typeUlong) = (18, "Артем", 'Д', "Радчиков", 611L);

            Console.WriteLine("c. Выведите кортеж на консоль целиком и выборочно (1, 3, 4  элементы) ");
            Console.WriteLine(tuple1);

            Console.WriteLine($"{tuple1.Item1}\t{tuple1.Item3}\t{tuple1.Item4}");

            Console.WriteLine($"{аgeForTuple}\t{patronymic}\t{surname}");

            Console.WriteLine($"{tuple3.Age}\t{tuple3.patronymic}\t{tuple3.surname}");

            // d.Выполните распаковку кортежа в переменные.
            var (one, two, three, four, five) = tuple1;
            Console.WriteLine($"{one}\t{two}\t{three}\t{four}\t{five}");
            // e.Сравните два кортежа. 

            Console.WriteLine($"tuple1 == tuple2? : { tuple1 == tuple2}");

            /*5) Создайте локальную функцию в main и вызовите ее. 
             * Формальные параметры функции– массив целых и строка.
             * Функция должна вернуть кортеж, содержащий: максимальный и 
             * минимальный элементы массива, сумму элементов массива и 
             * первую букву строки .*/
             
            (int, int, int, char) functionForTask6(int[] Mas, string Str)
            {
                int maxElem = Mas[0];
                int minElem = Mas[0];
                int sum = 0;
                char firstChar;

                foreach(int elem in Mas)
                {
                    if(maxElem<elem)
                    {
                        maxElem = elem;
                    }
                    if(minElem>elem)
                    {
                        minElem = elem;
                    }
                    sum += elem;
                }

                firstChar = Str[0];

                return (max: maxElem, min: minElem, sum: sum, first: firstChar);
            }

            int[] masOfInt = { 1, 2, 3, 4, 5, 6, 7 };
            string strForTask6="Привет";
            var tupleForTask6 = functionForTask6(masOfInt, strForTask6);
            Console.WriteLine(tupleForTask6);

            Console.ReadKey();

        }
    }
}
