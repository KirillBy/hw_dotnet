using System;

namespace HW09_AirportRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Passanger passanger = new Passanger("Kiryl", "Balanovich", new DateTime(1991, 06, 23), 21);
            PreFlightProcedure registration  = new PreFlightProcedure(passanger);
            registration.CallThePoliceEvent += Registration_CallThePoliceEvent;
            registration.HaveANiceFlightEvent += Registration_HaveANiceFlightEvent;
            registration.CheckInEvent += Registration_CheckInEvent;
            registration.RagistrationFailEvent += Registration_RagistrationFailEvent;
            registration.SecurityCheckEvent += Registration_SecurityCheckEvent;
            registration.Start();
            
        }

        private static void Registration_SecurityCheckEvent()
        {
            Console.WriteLine("***********************************************************************************\n\n");
            Console.WriteLine("Aiport administrator: Security check in progress...");
            Console.WriteLine("Aiport administrator: Follow Security Staff intrusctions...");
        }

        private static void Registration_RagistrationFailEvent(PreFlightProcedure registration)
        {
            Console.WriteLine("Aiport administrator: You will not pass. " +
                "Please return back with correct documents ");
            registration.Stop();
        }

        private static void Registration_CheckInEvent()
        {
            Console.WriteLine("***********************************************************************************\n\n");
            Console.WriteLine("Aiport administrator: Check-In in progress...");
            Console.WriteLine("Aiport administrator: Follow Registrator Staff intrusctions...");
        }

        private static void Registration_HaveANiceFlightEvent(PreFlightProcedure registration)
        {
            Console.WriteLine("Aiport administrator: Have a nice flight. " +
                "We will be glad to see you again in Minsk");
            registration.Stop();
        }

        private static void Registration_CallThePoliceEvent(PreFlightProcedure registration)
        {
            Console.WriteLine("Aiport administrator: Police calling ");
            Console.Beep(); Console.Beep(); Console.Beep();
            Console.WriteLine("Police: Lay down!!! You are held on suspicion on illegal transporting of " +
                "illegal staff !!!!! ");
            registration.Stop();
        }
    }
}
