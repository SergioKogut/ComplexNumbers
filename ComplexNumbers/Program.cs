using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Реализовать класс для хранения комплексного числа Выполнить в нем перегрузку всех необходимых
операторов для успешной компиляции следующего
фрагмента кода:
    Краткая справка по комплексным числам
(из Википедии):
• Любое комплексное число может быть представлено
как формальная сумма x + iy, где x и y — вещественные числа, i — мнимая единица, то есть число, удовлетворяющее уравнению i2 = − 1 
     
     
*/




namespace ComplexNumber
{

    class Complex
    {
        public double a { get; set; }
        public double b { get; set; }

        public Complex(double a = 1, double b = 1)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            if (b < 0)
            {
                return $"{Math.Round(a,2)}{b}i";
            }
            else
            {
                return $"{Math.Round(a,2)}+{b}i";
            }

        }

        // протилежне комплексне число
        public static Complex operator -(Complex c)
        {
            return new Complex(-c.a, -c.b);
        }



        public static Complex operator ~(Complex c)
        {
            return new Complex(c.a, -c.b);
        }

        public static double operator !(Complex c)
        {
            return Math.Sqrt(c.a * c.a + c.b * c.b);
        }


        public static Complex operator ++(Complex c)
        {
            return new Complex(++c.a, ++c.b);
        }


        public static bool operator true(Complex c)
        {
            return c.b == 0;
        }


        public static bool operator false(Complex c)
        {
            return c.b != 0;
        }


        //перезавантаження  оператора + для двох комплексних чисел
        public static Complex operator +(Complex c1, Complex c2)
        {
            return
            new Complex(c1.a + c2.a, c1.b + c2.b);
        }

        //перезавантаження  оператора + для  комплексного числа та дійсного числа
        public static Complex operator +(Complex c, double d)
        {
            return new Complex(c.a + d, c.b);
        }
        //перезавантаження  оператора + для  комплексного числа та цілого числа
        public static Complex operator +(Complex c, int d)
        {
            return new Complex(c.a + d, c.b);
        }

        //перезавантаження  оператора - для двох комплексних чисел
        public static Complex operator -(Complex c1, Complex c2)
        {
            return
            new Complex(c1.a - c2.a, c1.b - c2.b);
        }

        //перезавантаження  оператора + для  комплексного числа та дійсного числа
        public static Complex operator -(Complex c, double d)
        {
            return new Complex(c.a - d, c.b);
        }
        //перезавантаження  оператора + для  комплексного числа та цілого числа
        public static Complex operator -(Complex c, int d)
        {
            return new Complex(c.a -  d, c.b);
        }


        //перезавантаження  оператора + для десятичного числа та  комплексного числа 
        public static Complex operator +(double i, Complex c)
        {
            return new Complex(c.a + i, c.b);
        }
        //перезавантаження  оператора + для wskjuj числа та  комплексного числа 
        public static Complex operator +(int i, Complex c)
        {
            return new Complex(c.a + i, c.b);
        }



        //перезавантаження  оператора * для  комплексного числа 
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.a * c2.a - c1.b * c2.b, c1.b * c2.a + c1.a * c2.b);
        }

        //перезавантаження  оператора / для  комплексного числа 
        public static Complex operator /(Complex c1, Complex c2)
        {
            return new Complex((c1.a * c2.a + c1.b * c2.b) / (c2.a * c2.b + c2.b * c2.b), (c1.b * c2.a - c1.a * c2.b) / (c2.a * c2.a + c2.b * c2.b));
        }

        //перезавантаження  оператора + для десятичного числа та  комплексного числа 
        public static Complex operator *(decimal a, Complex c)
        {
            return new Complex((double)a * c.a, (double)a * c.b);
        }

        //перезавантаження  оператора + для комплексного числа та   десятичного числа 
        public static Complex operator *(Complex c, decimal a)
        {
            return (double)a * c;
        }

        //порівняння двох комплексних чисел
        public static bool operator ==(Complex c1, Complex c2)
        {
            return c1.a == c2.a && c1.b == c2.b;
        }

        //порівняння двох комплексних чисел
        public static bool operator !=(Complex c1, Complex c2)
        {
            return !(c1 == c2);
        }

        //приведення  дійсного числа до комплексного
        public static implicit operator Complex(double d)
        {
            return new Complex(d, 0);
        }

        //приведення  комплексного числа до дійсного
        public static explicit operator double(Complex c)
        {
            return c.a;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            Complex z = new Complex(1, 1);
            Complex z1;
            z1 = z-(z * z * z - 1) / (3 * z * z);
            Console.WriteLine("z1 = {0}", z1);

          //  b = -b;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

        }
    }
}
