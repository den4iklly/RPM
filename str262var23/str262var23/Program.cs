using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str262var23
{
    class Numbers
    {
        public static void Main()
        {
            int myInt1 = 23145;
            int myInt2 = 23863;
            System.Console.WriteLine("myInt1 = {0, 6}, myInt2 = {1, 7}", myInt1, myInt2);
            System.Console.WriteLine("myInt1 в формате 10:d = {0, 9:d}", myInt1);

            System.Console.WriteLine("myInt1 в формате 10:x ={0, 9:x2}", myInt1);

            double myDouble = 1234.2228;
            System.Console.WriteLine("myDouble в формате 10:f3 ={0, 10:f3}",
      myDouble);
            float myFloat = 1234.56789f;
            System.Console.WriteLine("myFloat в формате 10:f3 = {0, 10:f3}", myFloat);
            decimal myDecimal = 1234.56789m;
            System.Console.WriteLine("myDecimal в формате 10:f3 ={0, 9:f3}",
      myDecimal);
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Для выхода нажмите на Enter");
            System.Console.ReadLine();
        }
    }
    }
