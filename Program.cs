using System;

namespace LV_1_RPPOON
{
    class Program
    {
        static void Main(string[] args)
        {
            Note Unknown = new Note();
            Note Stjepan = new Note("Stjepan", "Hi RPPOON", 10);
            Note Ian = new Note("Ian", "Absolutely");
            Stjepan.SetPriority(20);
            Console.WriteLine(Stjepan.Priority);
            Console.WriteLine(Ian.ToString());

            Time_Note time = new Time_Note("Ian", "You Shall not pass", 100);
            Console.WriteLine(time.Time);
            Console.WriteLine(time.ToString());


        }
    }
}