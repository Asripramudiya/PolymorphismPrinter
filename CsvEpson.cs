using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class CsvEpson : IConvertEpson
    {
        public void Convert(PrinterWindows Epson)
        {
            string csv = string.Format("{0},{1}", Epson.Show, Epson.Print);

            Console.WriteLine("Hasil Konversi ke csv : \n");
            Console.WriteLine(csv);
        }
    }
}
