using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasTaxi
{
    class Program
    {
        static void Main(string[] args) 
        {
            //membuat objek taxi
            Taxi taxi = new Taxi();

            //pengesetan nilai properties
            taxi.DriverName = "ione";
            if (DateTime.Now.Hour > 6 && DateTime.Now.Hour <15)
            {
                taxi.OnDuty = true;
                taxi.NumPassenger = 8;
            }
            else
            {
                taxi.OnDuty = false;
                taxi.NumPassenger = 0;
            }


            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}