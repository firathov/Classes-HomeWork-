using System;

namespace Class_hw6
{
    class Array
    {
        private double [,] DoubleArray;
        private int n, m;

        public int Quantity
        {
            get
            {
                return n * m;
            }
            private set
            {

            }
        }

        public Array (int n, int m)
        {
            this.n = n;
            this.m = m;
            DoubleArray = new double [n,m];
        }

        public double Scalar
        {
            private get
            {
                return DoubleArray[n, m];
            }
            set
            {
                Console.WriteLine($"Увеличить значение всех элементов массива на скаляр:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        DoubleArray[i, j] += value;
                    }
                }
            }
        }


        public void EnterQuantity()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Введите элементы [{i},{j}] :  ");
                    DoubleArray[i, j] = forNumberCheck2();
                }
            }
        }

        public void PrintQuantity()
        {
            Console.WriteLine($"\n");
            //Console.WriteLine("\nЭлементы введенные вами равны: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"[{i}{j}] = {DoubleArray[i, j]}\t");
                }
                Console.WriteLine($"\n");
            }
        }

        public void BubbleArray()
        {
            int n = DoubleArray.GetLength(0), m = DoubleArray.GetLength(1);
            for (int a = 0; a < n; a++)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < m - 1; j++)
                    {
                        if (DoubleArray[a, j] < DoubleArray[a, j + 1])
                        {
                            double temp = DoubleArray[a, j];
                            DoubleArray[a, j] = DoubleArray[a, j + 1];
                            DoubleArray[a, j + 1] = temp;
                        }
                    }
                }
            }
            Console.WriteLine("Отсортировка элементов массива в порядке убивание");
        }
    

        static int forNumberCheck2()
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




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введтие размеры массива");
            int length1 = forNumberCheck();
            int length2 = forNumberCheck();
            Array array = new Array(length1, length2);

            array.EnterQuantity();
            array.PrintQuantity();

            Console.WriteLine($"Количество элементов равен {array.Quantity}\n"); 

            Console.Write("Укажите скаляр: ");
            int scalar = forNumberCheck();
            array.Scalar = scalar;
            array.PrintQuantity();

            array.BubbleArray();
            array.PrintQuantity();

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
