using System;
using System.IO;
using System.Threading;
using System.Xml.Linq;

namespace Testing_grounds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 98, 95, 94, 90, 88, 87, 82, 79, 77, 76, 73, 69, 67, 64, 63, 62, 60, 58, 57, 55, 54, 53, 49, 47, 46, 45, 44, 41, 40, 38, 37, 36, 34, 33, 31, 30, 29, 27, 25, 24, 22, 21, 20, 18, 17, 16, 14, 13, 10, 9, 8, 3, 2, 1, -2, -3, -6, -10, -13, -18, -20, -22, -24, -25, -26, -28, -30, -31, -32, -34, -35, -37, -38, -40, -41, -43, -47, -49, -51, -52, -53, -54, -55, -59, -60, -61, -62, -68, -72, -74, -75, -79, -81, -82, -84, -85, -86, -93, -95, -96 };

            int[] a = Test_fun.randomarraygen(100);
            for (int i = 0; i < a.Length; i++) { Console.WriteLine($"I: {i} V: {a[i]}"); }
            Console.WriteLine($"-----------");
            int[] b = N1_fun_test.urediSPrameni(a,a.Length);
            for (int i = 0; i < b.Length; i++) { Console.WriteLine($"I: {i} V: {a[i]}"); }

            /*
            int[] a = Test_fun.arraygenerator(10);
            while (true)
            {
            int[] b = N1_fun_test.urediSPrameni(a, a.Length);
                
                foreach (var element in b)
                {
                    Console.Write($" {element} ");
                }
                Console.WriteLine($"\nmid: {b[b.Length / 2]} ");
                Console.WriteLine("look num");

                string look = Console.ReadLine();
                int look_in = int.Parse(look);

                try
                {
                    int number = N1_fun_test.poisciZBisekcijo(look_in, b);
                    Console.WriteLine("num: "+ number);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);

                }
                Thread.Sleep(3000);
                Console.Clear();
            }
            */
        }
    }
}