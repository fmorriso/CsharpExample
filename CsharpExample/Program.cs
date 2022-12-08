using System;

namespace ConstantsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntegerFun();

            //IntegerOverflow();

            //UnsignedFun();

            //StringFun();

            //CityBusFun();

            Console.WriteLine("press any key to close");
            ConsoleKeyInfo key = Console.ReadKey();
            Environment.Exit(0);
        }

        /// <summary>
        /// Demonstrates using custom classes, including one that has a 
        /// special static variable.
        /// </summary>
        private static void CityBusFun()
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
            Thread.Sleep(25);

            // Send bus2 on its way.
            bus2.Drive();

            // use fatory method to create a bus
            Bus bus3 = Bus.CreateBus(73);
            Thread.Sleep(20);
            bus3.Drive();
        }
        
        /// <summary>
        /// Demonsrates various techniques that can be used with strings
        /// </summary>
        private static void StringFun()
        {
            string test = "abc";
            if (string.IsNullOrEmpty(test)) // ""
            {
                Console.WriteLine("it was null or empty");
            }

            test = " ";
            if (String.IsNullOrWhiteSpace(test) && test != null)
            {
                Console.WriteLine("it was whitespace");
            }
        }

        /// <summary>
        /// Demonstrates various techniques that can be used with
        /// unsigned whole numbers
        /// </summary>
        private static void UnsignedFun()
        {
            // example of unsigned primitives when you know you will never
            // have to deal with negative values:
            uint a = uint.MaxValue;
            Console.WriteLine($"The largest unsigned integer is: {a:n0}");

            ulong b = ulong.MaxValue;
            Console.WriteLine($"The largest unsigned long is: {b:n0}");

            // https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

            ulong nationalDebt = 31_415_000_000_000;
            Console.WriteLine($"USA national debt is approximately {nationalDebt:n0}");
        }

        /// <summary>
        /// Demonstrates various techniques of controlling integer
        /// overflow.
        /// </summary>
        private static void IntegerOverflow()
        {
            // example of integer overflow (result too big to fit into 32 bits)
            int j = Int32.MaxValue;
            int k = int.MaxValue;

            // first, prove that primitive and class versions of MaxValue are the same
            Console.WriteLine($"j={j:n0}, k={k:n0}");
            try
            {
                checked
                {
                    int product = j * k; // should be too big to fit into 32 bits
                    //Console.WriteLine($"checked result = {product}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ignoring integer overflow: {ex.Message}");
            }

            // use of unchecked to allow 32-bit overflow to be ignored
            unchecked
            {
                int product = j * k; // should be too big to fit into 32 bits
                Console.WriteLine($"unchecked result = {product}");
            }
        }

        /// <summary>
        /// Examples of printing integer values
        /// </summary>
        private static void IntegerFun()
        {
            int i = 54321;
            Console.WriteLine(i != 6);

            // following is analagous to str(i) in Python:
            Console.WriteLine(Convert.ToString(i) + " is a number");
            Console.WriteLine(i.ToString() + " is a number");

            // following is analagous to print(f"{i} is a number") in Python:
            Console.WriteLine($"{i:n0} is a number");
        }
    }
}