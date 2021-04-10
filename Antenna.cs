using System;

namespace Task12_3
{
    class Antenna
    {
        public delegate void SignalHandler(string data, out bool isAccepted);

        public event SignalHandler Signaled;

        public void OnSignal(string data)
        {
            if (Signaled != null)
            {
                foreach (var handler in Signaled.GetInvocationList())
                {
                    bool a = false;

                    object[] args = { data, a };

                    handler.Method.Invoke(handler.Target, args);

                    if (!(bool)args[1])
                    {
                        Signaled -= (SignalHandler)handler;
                    }
                }
            }
            else
            {
                Console.WriteLine("Нет доступных приёмников.");
            }
        }
    }
}
