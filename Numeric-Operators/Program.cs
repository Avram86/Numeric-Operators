using System;

namespace Numeric_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void DivisionForIntegers_RetursIntegers()
        {
            int a = 3;
            int b = 2;

            int c = a / b;
            int d = a % b;

            Console.WriteLine(d);
        }

        public static void IncrementPostfixVsPrefix()
        {
            int a = 3;
            //Prefic increment
            //int b = ++a;

            //Postfix increment
            int b = a++;

            Console.WriteLine(a);
            Console.WriteLine(b);
            //a=4, b=3
        }

        public static void ArithmeticOverflowExample()
        {
            int nr = int.MaxValue;
            int nr_to_add = 1;

            bool isOverflow = IsOverflow(nr, nr_to_add);

            if (isOverflow)
            {
                Console.WriteLine("Woops, arithmetic overflow!");
            }
            else
            {
                int result = nr + nr_to_add;
                Console.WriteLine(result);
            }
        }
        public static bool IsOverflow(int nr, int nr_to_add)
        {
            bool isOverflow=int.MaxValue - nr < nr_to_add;
            return isOverflow;
        }

        public static bool IsNotOverflow(int nr, int nr_to_add)
        {
            bool isNotOverflow = int.MaxValue - nr > nr_to_add;
            return isNotOverflow;
        }

        public static void DivideBy0()
        {

            int nr = 1234;
            int b = 0;

            int result = nr / b;
            Console.WriteLine(result);
        }

        public static void PowersOfTwo()
        {
            int a = 1;

            Console.WriteLine(a << 0);
            Console.WriteLine(a << 1);
            Console.WriteLine(a << 2);
            Console.WriteLine(a << 3);
            Console.WriteLine(a << 4);
            /*
             1
            2
            4
            8
            16*/
        }

    }
}
