using System;



namespace Class_hw2

{

    class Triangle

    {
        public int a;
        public int b;
        public int c;
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public int C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }

        public bool isTriangle
        {
            get
            {
                if (a+b>c && a+c>b && b+c>a)
                {
                    return true;
                }
                return false;
            }
            private set { }
        }

        public void Sides()
        {
            Console.WriteLine($"\n{a}\t{b}\t{c}");
        }

        public void Perimeter()
        {
            if (isTriangle==true)
            {
                int perim = a + b + c;
                Console.WriteLine($"\n Периметр треугольника равен {perim}");
            }
            else
            {
                Console.WriteLine("Не может быть такого треугольника");
            }
            
        }

        public void Area()
        {
            if (isTriangle==true)
            {
                double p = (a + b + c) / 2;
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                int convert = Convert.ToInt32(area);
                Console.WriteLine($"Площадь треугольника равен {convert}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону A");
            int a = forNumberCheck();

            Console.WriteLine("Введите сторону B");
            int b = forNumberCheck();

            Console.WriteLine("Введите сторону C");
            int c = forNumberCheck();

            Triangle triangle = new Triangle(a, b, c);

            triangle.Sides();
            triangle.Perimeter();
            triangle.Area();
            Console.ReadKey();

        }

        static int forNumberCheck()
        {
            int number;

            for (; ; )
            {
                string checkingNumber = Console.ReadLine();
                number = 0;
                Int32.TryParse(checkingNumber, out number);
                if (number > 0)
                {
                    return number;
                }
                else
                {
                    Console.Write("Вы ввели неправильный символ, попробуйте ещё: ");
                }
            }
        }
    }
}