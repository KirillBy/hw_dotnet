using System;

namespace HW09_AirportRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Passanger passanger = new Passanger("Kiryl", "Balanovich", new DateTime(1991, 06, 23));
            PreFlightProcedure registration  = new PreFlightProcedure(passanger);
            registration.CallThePoliceEvent += Registration_CallThePoliceEvent;
            registration.Start();
            
        }

        private static void Registration_CallThePoliceEvent()
        {
            Console.WriteLine("Aiport administrator: Police calling ");
            Console.Beep(); Console.Beep(); Console.Beep();
        }
    }
}
