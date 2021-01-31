using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{

    class Program
    {

        struct Complex
        {
            /// <summary>
            /// Мнимая часть комплексного числа
            /// </summary>
            public double im;

            /// <summary>
            /// Действительная часть комплексного числа
            /// </summary>
            public double re;

            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }

            public Complex Sub(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }

            public override string ToString()
            {
                return $"({re}) + ({im}i)";
            }

        }

        static void Main(string[] args)
        {
            int i = 12;
            Complex complex1;
            complex1.re = 12;
            complex1.im = -3;

            Complex complex2;
            complex2.re = -1;
            complex2.im = 5;

            Console.WriteLine($"Результат сложения комплексных чисел {complex1} и {complex2} -> {complex1.Plus(complex2)}");
            Console.WriteLine($"Результат разности комплексных чисел {complex1} и {complex2} -> {complex1.Sub(complex2)}");

               Test1();
               Console.ReadKey();

        }

         static void Test1()
         {
            Console.WriteLine();
         }
    }
}
