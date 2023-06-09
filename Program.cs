using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_nama_printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer Printer;
            Console.WriteLine("Pilih printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LasetJet");
            Console.WriteLine();
            Console.Write("Nomor printer [1..3]: ");
            
            Printer Epson = new Epson();
            Printer Canon = new Canon();
            Printer LasetJet = new LasetJet();

            int nomorprinter = Convert.ToInt32(Console.ReadLine());

            if (nomorprinter == 1)
                Epson.Merek();
            else if (nomorprinter == 2)
                Canon.Merek();
            else if (nomorprinter == 3)
                LasetJet.Merek();
            else
                Console.WriteLine("Nomor printer tidak valid");

            Console.ReadKey();
        }
    }
}
