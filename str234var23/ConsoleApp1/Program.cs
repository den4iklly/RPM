using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            algoritm5.alg5Main();
        }
    }
    class algoritm1
    {
        public static void alg1Main()
        {
            int smallNumber = 690;
            int bigNumber = 685;
            if (bigNumber < smallNumber)
            {
                System.Console.Write(bigNumber);
                System.Console.Write(" меньше, чем ");
                System.Console.WriteLine(smallNumber);
            }
            else
            {
                System.Console.Write(smallNumber);
                System.Console.Write(" меньше, чем ");
                System.Console.WriteLine(bigNumber);
            }
            System.Console.WriteLine("Для выхода нажмите Enter");
            System.Console.ReadLine();
        }
    }
    class Algoritm2
    {
        public static void alg2Main()
        {
            int reactorTemp = 1550;
            string emergencyValve = "закрыт";
            if (reactorTemp <= 1000)
            {
                System.Console.WriteLine("Температура в реакторе нормальная");
                System.Console.WriteLine("Для выхода из системы диагностики нажмите Enter"); 
                System.Console.ReadLine();
            }
            else
            {
                System.Console.WriteLine("Слишком высокая температура в реакторе!");
                if (emergencyValve == "закрыт")
                {
                    System.Console.WriteLine("Реактор в процессе плавления!");
                    System.Console.WriteLine("Для открытия аварийного клапана нажмите Enter");
                    System.Console.ReadLine();
                }
            }
        }
    }
    class algoritm3
    {
        public static void alg3Main()
        {
            for (int counter = 1; counter <= 25; counter++)
            {
                System.Console.WriteLine("counter = " + counter);
            }
            System.Console.WriteLine("Для выхода нажмите Enter");
            System.Console.ReadLine();
        }
    }
    class algoritm4
    {
        public static void alg4Main()
        {
            int counter = 25;
            do
            {
                System.Console.WriteLine("counter = " + counter);
                counter--;
            }
            while (counter > 1);
            System.Console.WriteLine("Для выхода нажмите Enter");
            System.Console.ReadLine();
        }
    }
    class algoritm5
    {
        public static void alg5Main()
        {
            int[] myValues = { 4, 6, 9, 8, -78 };
            foreach (int counter in myValues)
            {
                System.Console.WriteLine("counter = " + counter);
            }
            System.Console.WriteLine("Для выхода нажмите Enter");
            System.Console.ReadLine();
        }
    }
}
