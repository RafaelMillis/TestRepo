using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main()
        {

            Math m = new Math(10, 10);

            m.MathTable();

            //math_ext ma = new math_ext();
            //ma.ver();


            //Console.Read();
            Console.WriteLine("Tested successfully " + DateTime.Now);
        }
        public class Math
        {
            double a;
            double b;

            public Math(double avalue, double bvalue)
            {
                a = avalue;
                b = bvalue;
            }


            public void MathTable()
            {
                for (int j = 1; j < 11; j++)
                {
                    string s = "";
                    for (int i = 1; i < 11; i++)
                    {
                        s += (i * j).ToString() + ",";

                    }

                    Console.WriteLine(s);
                }

            }

            public double Sum(double a, double b)
            {

                Console.WriteLine(a + b);
                return a + b;

            }
            public double Mul(double a, double b)
            {

                Console.WriteLine(a * b);

                return a * b;

            }


        }


        //class math_ext : Math
        //{
        //    string s = "";

        //    public string ver()
        //    {
        //        string sval = "Ver 1.19";
        //        Console.WriteLine(sval);
        //        return sval;
        //    }


        //}


    }


}
