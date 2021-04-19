using System;
using System.Threading;

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

        public static void DivisionForFloat()
        {
            float a = 3;
            float b = 2;

            Console.WriteLine(a / b);
        }

        public static void ImmutableStrings()
        {
            string msg1 = "Hello world";
            string msg2 = msg1;

            Console.WriteLine(msg1);
            Console.WriteLine(msg2);


            msg1 = msg1 + "123";
            Console.WriteLine(msg1);
            Console.WriteLine(msg2);
        }

        public static void StringPunctCompare()
        {
            string msg1 = "ana";
            string msg2 = "Ana";

            Console.WriteLine("Comparison in current culture");
            if (string.Compare(msg1, msg2, StringComparison.CurrentCulture) < 0)
            {
                Console.WriteLine("msg1<msg2");
            }
            if (string.Compare(msg1, msg2, StringComparison.CurrentCulture) == 0)
            {
                Console.WriteLine("msg1=msg2");
            }
            else
            {
                Console.WriteLine("msg1>msg2");
            }
            //literele mici sunt inaintea celor mari

            Console.WriteLine("Comparison in ordinal(coduri de caractere)");
            if (string.Compare(msg1, msg2, StringComparison.Ordinal) < 0)
            {
                Console.WriteLine("msg1<msg2");
            }
            if (string.Compare(msg1, msg2, StringComparison.Ordinal) == 0)
            {
                Console.WriteLine("msg1=msg2");
            }
            else
            {
                Console.WriteLine("msg1>msg2");
            }
            //invers

            Console.WriteLine("Comparison in OrdinalIgnoreCase(lit mari si mici au aceeasi ordine)");
            if (string.Compare(msg1, msg2, StringComparison.OrdinalIgnoreCase) < 0)
            {
                Console.WriteLine("msg1<msg2");
            }
            if (string.Compare(msg1, msg2, StringComparison.OrdinalIgnoreCase) == 0)
            {
                Console.WriteLine("msg1=msg2");
            }
            else
            {
                Console.WriteLine("msg1>msg2");
            }
            //egal
        }

        public static void StringPunctEqual()
        {
            string msg1 = "file";
            string msg2 = "FILE";

            bool areEqual1 = string.Equals(msg1, msg2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("areEqual1= " + areEqual1);
            //outcome: true

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
            bool areEqual2 = string.Equals(msg1, msg2, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine("areEqual2= " + areEqual2);
            //outcome: false

        }

    }
}
