using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Testing_grounds
{
    public class N1_fun_test
    {

        public static int poisci(int el, int[] a)
        {
            // TODO
            int right = a.Length - 1;

            for (int i = 0; i < a.Length; i++)
            {
                if (el == a[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public static int poisciZBisekcijo(int el, int[] a)
        {

            int left = 0;
            int right = a.Length - 1;

            while (left <= right)
            {
                int temp = (left + right) / 2;

                if (el < a[temp])
                {
                    left = temp + 1;


                }
                else if (el > a[temp])
                {
                    right = temp - 1;
                }
                else
                {
                    if (a[left] == a[right])
                    {
                        return right;
                    }
                    else
                    {
                        return temp;
                    }
                }

            }

            return -1;
        }

        public static int[] urediSPrameni(int[] a, int dolzina)
        {
            for (int i = 0; i < dolzina; i++)
            {
                for (int j = i + 1; j < dolzina; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            //saved a -> temp_a
            int[] temp_a;
            temp_a = a;

            //make temp array 
            int[] temp_b = new int[a.Length];

            int x = 0;
            temp_b[x++] = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] != a[i - 1])
                {
                    temp_b[x++] = a[i];
                }

            }

            for (int i = 0; i < dolzina; i++)
            {
                a[i] = temp_b[i];
            }
            return a;
        }

    }
}
