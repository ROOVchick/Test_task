using System;

namespace Test_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int money;
            Console.WriteLine("Введите сумму:");

            for (money = 2700; money < 3000; money++)
            {
                Console.WriteLine($"Ваша сумма на счёте: {money} рублей");
            }
            if (money == 3000)
            {
                Console.WriteLine("Вы достигли лимита в 3000р");
            }
            Console.ReadLine();
        }
    }
}
