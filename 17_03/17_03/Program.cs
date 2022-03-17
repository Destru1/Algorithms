using System;

namespace _17_03
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        public static string G(int k, int n)
        {
            if (n == 1)
            {
                return k.ToString();
            }

            else if (k < (int)Math.Pow(2, n - 1))
            {
                return "0" + G(k, n - 1);
            }
            else
            {
                return "1" + G((int)Math.Pow(2, n) - 1 - k, n - 1);
            }
        }

        public static string GrayCodeRec(int k)
        {
            if (k <= 1)
            {
                return Convert.ToString(k);
            }

            else
            {
                return (GrayCodeRec(k - 1) + ", " + Convert.ToString(k) + ", " + GrayCodeRec(k - 1));
            }
        }

        public static void GrayCodeNonRec(int k)
        {
            if (k < 1)
            {
                Console.WriteLine(k);
            }

            else
            {
               
            }
        }

        public static String[] GrayCode(int n)
        {
            String[] result = new String[(int)Math.Pow(2, n)];
            for (int k = 0; k < (int)Math.Pow(2, n); k++)
            {
                result[k] = G(k, n);
            }
            return result;
        }
        static void Main(string[] args)
        {

            //Console.WriteLine(Fibonacci(2));

            
            String[] codes = GrayCode(3);
            for (int i = 0; i < codes.Length; i++)
            {
                Console.WriteLine(codes[i]);

            }
        }
    }
}
