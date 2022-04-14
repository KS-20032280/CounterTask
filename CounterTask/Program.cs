using System;

namespace CounterTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();

            //tick one every second for 10 seconds
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(clock.GetTimeAsString());
                System.Threading.Thread.Sleep(1000);
                clock.Tick();
            }
        }
    }
}
