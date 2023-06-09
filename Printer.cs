using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_nama_printer
{
    public class Printer
    {
        public string NamaPrinter { get; set; }
        public virtual void Merek()
        {
            Console.WriteLine("Merek printer");
        }
    }

    public class Epson : Printer
    {
        public override void Merek()
        {
            Console.WriteLine();
            Console.WriteLine("Epson display dimension : 10*11");
            Console.WriteLine("Epson printer printing....");
        }
    }
    public class Canon : Printer
    {
        public override void Merek()
        {
            Console.WriteLine();
            Console.WriteLine("Canon display dimension : 9.5*12");
            Console.WriteLine("Canon printer printing....");
        }
    }
    public class LasetJet : Printer
    {
        public override void Merek()
        {
            Console.WriteLine();
            Console.WriteLine("LasetJet display dimension : 12*12");
            Console.WriteLine("LasetJet printer printing....");
        }
    }
}
