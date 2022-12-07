using System;
using System.Text;

namespace ConstantsExample
{
    public class Bus
    {
        // Static variable used by all Bus instances.
        // Represents the time the first bus of the day starts its route.
        protected static readonly DateTime GLOBAL_START_TIME;

        // Property for the number of each bus.
        // We provide only a getter because the route number should not change after
        // the bus instance is created.
        public int RouteNumber { get;  }

        // Static constructor to initialize the static variable.
        // It is invoked before the first instance constructor is run.
        static Bus()
        {
            GLOBAL_START_TIME = DateTime.UtcNow;

            // The following statement produces the first line of output,
            // and the line occurs only once.
            Console.WriteLine($"Static constructor sets global start time to {GLOBAL_START_TIME.ToLongTimeString()}");                
        }

        // Instance constructor.
        public Bus(int routeNum)
        {
            RouteNumber = routeNum;
            Console.WriteLine("Bus #{0} is created.", RouteNumber);
        }

        /// <summary>
        /// Example of a 
        /// </summary>
        /// <param name="routeNum"></param>
        /// <returns></returns>
        public static Bus CreateBuss(int routeNum)
        {
            return new Bus(routeNum);
        }

        // Instance method.
        public void Drive()
        {
            TimeSpan elapsedTime = DateTime.UtcNow - GLOBAL_START_TIME;

            // For demonstration purposes we treat milliseconds as minutes to simulate
            // actual bus times. Do not do this in your actual bus schedule program!
            Console.WriteLine("{0} is starting its route {1:N2} pseudo-minutes after global start time {2}.",
                                    this.RouteNumber,
                                    elapsedTime.Milliseconds,
                                    GLOBAL_START_TIME.ToShortTimeString());
        }

        public override string ToString()
        {
            TimeSpan elapsedTime = DateTime.UtcNow - GLOBAL_START_TIME;
            StringBuilder sbr = new StringBuilder()
                .Append($@"Route: {this.RouteNumber}")
                .Append($@" started {elapsedTime.Milliseconds}")
                .Append($@" pseudo-minutes after global start time {GLOBAL_START_TIME.ToLongTimeString()}")
                ;
            return sbr.ToString();
            /*
            return  $@"Route: {this.RouteNumber} started {elapsedTime.Milliseconds} "
                  + $@"pseudo-minutes after global start time {GLOBAL_START_TIME.ToLongTimeString()}";   
            */
        }
    }
}
