using System;

namespace Task12_3
{
    class Receiver
    {
        private string receiverName;
        private bool IsTurnOn;

        public Receiver(bool IsTurnOn, string receiverName)
        {
            this.IsTurnOn = IsTurnOn;
            this.receiverName = receiverName;

        }

        public void DoReceive(string data, out bool isAccepted)
        {
            isAccepted = IsTurnOn;

            Console.WriteLine(receiverName);
            if (isAccepted)
            {
                Console.WriteLine($"Сигнал принят. Полученый сигнал: {data}");
            }
            else
            {
                Console.WriteLine("Сигнал не принят.");
            }
        }
    }
}
