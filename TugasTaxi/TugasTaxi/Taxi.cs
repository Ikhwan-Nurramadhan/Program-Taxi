using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasTaxi
{
    internal class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public Boolean OnDuty { get; set; }
        public int NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);
            Console.WriteLine("On Duty: {0}", OnDuty);
            Console.WriteLine("Number of Passenger: {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            if (OnDuty)
            {
                Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
            }
            else
            {
                Console.WriteLine("{0} tidak bisa menjemput penumpang", DriverName);
            }
           
        }

        public void DropOffPassenger()
        {
            if (OnDuty)
            {
                Console.WriteLine("{0} selesai mengantar penumpang\n", DriverName);
            }
            else 
            {
                Console.WriteLine("Mohon maaf atas ketidaknyamanannya");
            }
        }

    }
}
