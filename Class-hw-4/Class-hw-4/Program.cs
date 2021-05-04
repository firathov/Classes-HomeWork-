using System;

namespace Class_hw_4
{
    class Money
    {
        private int first;
        private int second;

        public Money(int first, int second)
        {
            this.first = first;
            this.second = second;
        }

        public int First
        {
            get
            {
                return first;
            }
            set
            {
                first = value;
            }
        }

        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                second = value;
            }
        }

        public int Sum
        {
            get
            {
                return First + Second;
            }
            private set { }
        }



        public void Bill()
        {
            Console.WriteLine($"Номинал равен {First}, Количество купюр равен {Second}");
        }

        public bool EnoughMoney(int first, int second, int price)
        {
            bool result = false;
            if (first*second>price)
            {
                Console.WriteLine("У Вас достаточно денег");
                result = true;
            }
            else if (first*second<price)
            {
                Console.WriteLine("У Вас недостаточно средств");
                result = false;
            }
            return result;
        }
        public void HowMany (int first, int second, int price, bool temp)
        {
            if (temp==true)
            {
                int howMany = (first * second) / price;
                Console.WriteLine($"Вы можете купить {howMany} штук");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номинал: ");
            int first = forNumberCheck();
            Console.WriteLine("Введите купюру: ");
            int second = forNumberCheck();
            Console.WriteLine("Введите цену товара: ");
            int price = forNumberCheck();
            Money money = new Money(first, second);

            money.Bill();
            bool result = money.EnoughMoney(first,second,price);
            money.HowMany(first, second, price, result);

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