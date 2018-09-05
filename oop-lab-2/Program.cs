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
            //a
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

            //b
            double x = 1.2;// явный
            int b1 = (int)x;
            float b2 = (float)x;
            short b3 = (short)b1;
            int b4 = (int)value;
            x = (double)b1;

            int y = 123434234;// не явный
            long a = y;
            double a1 = y;

            //c

            //Упаковка представляет собой процесс преобразования типа значения в тип object или в любой другой тип интерфейса, реализуемый этим типом значения. Когда тип значения упаковывается средой CLR, она создает оболочку значения внутри System.Object и сохраняет ее в управляемой куче. Операция распаковки извлекает тип значения из объекта. Упаковка является неявной; распаковка является явной.

            //упаковка
            int i = 12323;
            object o = i;

            //распаковка

            o = 1232132;
            i = (int)o;
            //????

            //d

            var var1="sd";
            var var2 = 23232;

            Nullable<bool> per = null;
            int? per1 = null;
            int? per2 = null;

            //2 

            //a
            String str1 = "12345";
            String str2 = "1234567";
            




        }
    }
}
