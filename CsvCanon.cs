using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class CsvCanon : IConvertCanon
    {
        public void Convert(PrinterWindows Canon)
        {
            string csv = string.Format("{0},{1}", Canon.Show, Canon.Print);

            Console.WriteLine("Hasil Konversi ke csv : \n");
            Console.WriteLine(csv);
        }
    }
}
