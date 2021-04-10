using System;

namespace Task12_3
{
    class Program
    {
        static void Main()
        {
            Antenna antenna = new Antenna();

            Receiver receiver1 = new Receiver(false, "Приёмник 1");
            Receiver receiver2 = new Receiver(true, "Приёмник 2");
            Receiver receiver3 = new Receiver(false, "Приёмник 3");
            Receiver receiver4 = new Receiver(true, "Приёмник 4");

            antenna.Signaled += receiver1.DoReceive;
            antenna.Signaled += receiver2.DoReceive;
            antenna.Signaled += receiver3.DoReceive;
            antenna.Signaled += receiver4.DoReceive;

            Console.WriteLine("Проверка сигнала\n----------------");
            antenna.OnSignal("001");

            Console.WriteLine();

            Console.WriteLine("Отправка сигнала\n----------------");
            antenna.OnSignal("111");

            Console.ReadKey();
        }
    }
}
