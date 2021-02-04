using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//структура для сложения и вычитания комплексных чисел
#region(struct Complex)
struct Complex
{
    public double im;
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
#endregion

//класс для произведения комплексных чисел
#region (Class Complex)
namespace HomeWork_3
{
    class ComplexC
    {
        private double im;
        double re;
        public ComplexC()
        {
            im = 0;
            re = 0;
        }

        public ComplexC(double _im, double re)
        {
            im = _im;
            this.re = re;
        }
        public ComplexC Multi(ComplexC x2)
        {
            ComplexC x3 = new ComplexC();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }
        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }
        public override string ToString()
        {
            return "("+re+")" + "+" + "("+im+")" + "i";
        }

    }
    #endregion

    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Введите номер задания (0 - выход):");
                var index = int.Parse(Console.ReadLine());

                switch (index)
                {
                    case 0:
                        return;
                    case 1:
                        Task1();
                        break;
                   
                }
            }
            #region(Task1)
            static void  Task1()
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

                Console.ReadKey();

                ComplexC complexC1 = new ComplexC(1, 1);
                ComplexC complexC2 = new ComplexC(2, 2);
                complexC2.Im = 3;
                ComplexC result;
                result = complexC1.Multi(complexC2);
                Console.WriteLine($"Произведение комплексных чисел {complexC1} и {complexC2} -> " + result.ToString());
            }
            #endregion
        }


    }
}
