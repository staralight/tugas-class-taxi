using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaxi
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("DriverName: {0}", DriverName);
            if (OnDuty) Console.WriteLine("OnDuty: Yes");
            else Console.WriteLine("OnDuty: No");
            Console.WriteLine("NumPassenger: {0}\n", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}
