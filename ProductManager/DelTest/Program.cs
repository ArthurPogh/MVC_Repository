using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelTest
{
    class Program
    {

        public static int M10(int a)
        {
            return a * 10;

        }

        public static int M30(int a)
        {
            return a * 30;

        }

        class A
        {

            public delegate int dM(int a);


            public string F()
            {
                dM F10 = Program.M10;
                dM F30 = Program.M30;


                dM F = F10 + F30;







                return F(10).ToString();
            }

        }


       
        static void Main(string[] args)
        {

            Console.ReadKey();
            A obj = new A();

           


            Console.WriteLine(obj.F());

            Console.ReadKey();

        }
    }
}
