using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class CsvLaserJet : IConvertLaserJet
    {
        public void Convert(PrinterWindows LaserJet)
        {
            string csv = string.Format("{0},{1}", LaserJet.Show, LaserJet.Print);

            Console.WriteLine("Hasil Konversi ke csv : \n");
            Console.WriteLine(csv);
        }
    }
}
