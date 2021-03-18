using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taksi
{
    class Taxi
    {
        // Properties
        public string NamaDriver { get; set; }
        public bool DalamTugas { get; set; }
        public int Penumpang { get; set; }

        //Method
        public void TaxiInfo()
        {
            Console.WriteLine("Nama Driver: " + NamaDriver);
            Console.Write("Dalam Tugas: ");
            switch (DalamTugas)
            {
                case true:
                    Console.WriteLine("Yes");
                    break;
                default:
                    Console.WriteLine("No");
                    break;
            }
            Console.WriteLine("Nomer penumpang: " + Penumpang + "\n");
        }
        public void JemputPenumpang()
        {
            Console.WriteLine(NamaDriver+ " sedang menjemput penumpang");
        }
        public void TurunPenumpang()
        {
            Console.WriteLine(NamaDriver + " selesai mengantar penumpang");
        }
    }
}
