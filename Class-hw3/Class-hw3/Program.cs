using System;

namespace Class_hw3

{
    class Rectangle

    {
        private int a;
        private int b;
        

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public bool isSquared
        {
            get
            {
                if (A == B)
                {
                    return true;
                }
                return false;
            }
            private set { }
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



        public void PrintSides()
        {
            Console.WriteLine($"\nСтороны прямоугольника равны: \n{a}\n{b}");
        }

        public void Perimeter()
        {
            if (isSquared == true)
            {
                Console.WriteLine("Это квадрат");
                int perim = 2 * (a + b);
                Console.WriteLine($"Периметр Квадрата равен = {perim}");
            }
            else
            {
                int perim = 2 * (a + b);
                Console.WriteLine($"Периметр прямоугольника равен = {perim}");
            }
        }

        public void Area()
        {
            if (isSquared == true)
            {
                int area = a * b;
                Console.WriteLine($"Площадь Квадрата равен = {area}");
            }
            else
            {
                int area = a * b;
                Console.WriteLine($"Площадь прямоугольника равен = {area}");
            }
        }



    }

    class Program

    {
        static void Main(string[] args)
        {
            Console.Write("Enter A = ");
            int a = forNumberCheck();
            Console.Write("Enter B = ");
            int b = forNumberCheck();
            Rectangle rectangle = new Rectangle(a, b);

            
            rectangle.PrintSides();
            rectangle.Perimeter();
            rectangle.Area();

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
