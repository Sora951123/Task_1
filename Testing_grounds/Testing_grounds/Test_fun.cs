using System;
using System.IO;
using System.Linq;


namespace Testing_grounds
{
    public class Test_fun
    {

        public static TimeSpan timer()
        {
           DateTime temp = DateTime.Now;
            int hour = temp.Hour;
            int min = temp.Minute;
            int sec = temp.Second;
            int ms = temp.Millisecond;           
            TimeSpan timer = new TimeSpan(0,hour, min, sec, ms);
            return timer;
        }

        public static int[] randomarraygen(int max)
        {
            int[] temparray = new int[max];
            Random rnd = new Random();

            for (int i = 0; i < max; i++)
            {
                int tempn = rnd.Next(-max, max);
                temparray[i] = tempn;
            }
            return temparray;

        }

        public static int[] arraygenerator(int max)
        { 
            int[] temparray = new int[max];
            Random rnd = new Random();

            for (int i = 0; i < max; i++)
            {
                int tempn = rnd.Next(-max, max);

                if (temparray.Contains(tempn))
                {
                    tempn = rnd.Next(-max, max);
                    i--;
                }
                else {
                    temparray[i] = tempn;
                }
            }
            return temparray;
        }

        public static void arraygenmassive(int num)
        {
            string n = "";
            for (int i = 0; i < num; i++)
            {
                n += "," + i;
            }
            File.WriteAllText(@"C:\Temp\csc.txt", n);
        }
    }
}
