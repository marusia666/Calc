using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ArrCalc : InterfaceArrCalc
    {
        private int[] a = new int[10];

        public void Put_A(ref int[] a)
        {
            for (int i = 0; i <= a.Length; i++) 
            {
                this.a[i] = a[i];
            }
                
        }

        public void Clear_A()
        {
             for (int i = 0; i <= a.Length; i++)
             {
                this.a[i] = 0;
             }
        }

        public int[] Multiplication(int b)
        {
             for (int i = 0; i <= a.Length; i++)
             {
                a[i] = a[i]*b;
             }
             return a;
        }

        public int[] Division(int b)
        {
             for (int i = 0; i <= a.Length; i++)
             {
                 a[i] = a[i]/b;
             }
             return a;
        }

        public int[] Sum(int b)
        {
             for (int i = 0; i <= a.Length; i++)
             {
                a[i] = a[i]+b;
             }
             return a;
        }

        public int[] Subtraction(int b)
        {
             for (int i = 0; i <= a.Length; i++)
             {
                a[i] = a[i]-b;
             }
             return a;
        }

        public int[] SqrtX(int b)
        {
             for (int i = 0; i <= a.Length; i++)
             {
                a[i] = (int)Math.Pow(a[i], 1/b);
             }
             return a;
        }

        public int[] Degree(int b)
        {
             for (int i = 0; i <= a.Length; i++)
             {
                a[i] = (int)Math.Pow(a[i], b);
             }
             return a;
        }

         public int[] Sqrt()
         {

             for (int i = 0; i <= a.Length; i++)
             {
                a[i] = (int)Math.Sqrt(a[i]);
             }
             return a;
         }

         public int[] Square()
         {
             for (int i = 0; i <= a.Length; i++)
             {
                a[i] = (int)Math.Pow(a[i], 2);
             }
             return a;
         }

        public int Factorial(ref int [] a, int j)
        {
            int f = 1;

            for (int i = 1; i <= a[j]; i++)
                f *= i;

            return f;
        }

        public int[] Percent()
         {
             for (int i = 0; i <= a.Length; i++)
             {
                a[i] = a[i]/100;
             }
             return a;
         }

         public int[] Log(int b)
         {
             for (int i = 0; i <= a.Length; i++)
             {
                a[i] = (int)Math.Log(a[i], b);
             }
             return a;
         }
    }
}
