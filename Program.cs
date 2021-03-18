using System;

namespace taksi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat Object Taxi
            Taxi taxi = new Taxi();

            // Set Nilai Properties
            taxi.NamaDriver = "Jono";
            taxi.DalamTugas = true;
            taxi.Penumpang = 10;

            // Memanggil Method
            taxi.TaxiInfo();
            taxi.JemputPenumpang();
            taxi.TurunPenumpang();

            Console.ReadKey();
        }
    }
}
