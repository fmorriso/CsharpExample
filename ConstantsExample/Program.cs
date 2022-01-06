using System;

namespace ConstantsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // static constructor example
            Console.WriteLine(BankAccount.ACCOUNT_NUMBER);

            // Bus example begins here:
            // The creation of this instance activates the static constructor.
            Bus bus1 = new Bus(71);
            Console.WriteLine(bus1);

            // Create a second bus.
            Bus bus2 = new Bus(72);

            // Send bus1 on its way.
            bus1.Drive();

            // Wait for bus2 to warm up.
            System.Threading.Thread.Sleep(25);

            // Send bus2 on its way.
            bus2.Drive();

            Console.WriteLine("press any key to close");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}