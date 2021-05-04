using System;

namespace Class_hw1
{
    class Point
    {
        private int x;
        private int y;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Point()
        {
            this.x = 0;
            this.y = 0;

        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Distance ()
        {
            double distance;

            distance = x * x + y * y;

            distance = Math.Sqrt(distance);
            Console.WriteLine($"Расстояние от начало координат до точки равен {distance}");
        }

        public int ScalarXY
        {
            set
            {
                x *= value;
                y *= value;
            }
        }

        public void Vector (int a, int b)
        {
            x += a;
            y += b;
        }
        

        public void PrintCoord()
        {
            Console.WriteLine($"Координаты x равен {x} и y равен {y}");
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Point num = new Point();
            num.PrintCoord();

            Console.Write("Введите число X: ");

            num.X = forNumberCheck();
            Console.Write("Введите число Y: ");
            num.Y = forNumberCheck();

            num.PrintCoord();

            num.Distance();
            Console.WriteLine("Введите скаляр ");
            int numberScalar = forNumberCheck();
            num.ScalarXY = numberScalar;

            num.PrintCoord();

            Console.WriteLine("Введите число оси x");
            int a = forNumberCheck();
            Console.WriteLine("Введите число оси y");
            int b = forNumberCheck();

            num.Vector(a, b);

            num.PrintCoord();

            Console.ReadKey();
        }

        static int forNumberCheck()
        {
            int number;

            for (; ; )
            {
                string checkingNumber = Console.ReadLine();

                if (Int32.TryParse(checkingNumber, out number))
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
