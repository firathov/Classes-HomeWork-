using System;

namespace Class_hw5
{
    class MyArray
    {
        private int[] intArray;
        private int n;

        public int N
        {
            get
            {
                return n;
            }
            private set
            {
                n = value;
            }
        }

        public MyArray(int n)
        {
            this.n = n;
            intArray = new int[N];
        }

        public int Scalar
        {
            private get
            {
                return intArray[n];
            }
            set
            {
                for (int i = 0; i < intArray.Length; i++)
                {
                    intArray[i] *= value;
                    Console.Write($"\n{intArray[i]}");
                }
            }
        }

        public void MonitArray()
        { 
            intArray = new int[n];
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine($"Введите {i+1} индекс числа");
                intArray[i] = forNumberCheck2();
                    
            }
        }

        public void WithdrawArray()
        {
            for (int i=0; i<intArray.Length; i++)
            {
                Console.WriteLine($"Индек номера {i+1} равняется {intArray[i]}");
            }
        }

        public void BubbleArray ()
        {
            int temp;
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Отсортировка элементов массива в порядке возрастание");
        }
        public void Print()
        {
            foreach (int nums in intArray)
            {
                Console.WriteLine(nums);
            }
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
            Console.Write("Введите длину массива: ");
            int length = forNumberCheck();
            MyArray array = new MyArray(length);
            array.MonitArray();
            array.WithdrawArray();
            array.BubbleArray();
            array.Print();
            Console.Write("Укажите скаляр: ");
            int scalar = forNumberCheck();
            array.Scalar = scalar;

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
