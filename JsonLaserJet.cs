using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Printer
{
    class JsonLaserJet : IConvertLaserJet
    {
        public void Convert(PrinterWindows LaserJet)
        {
            string json = JsonConvert.SerializeObject(LaserJet);

            Console.WriteLine("Hasil Konversi ke json : \n");
            Console.WriteLine(json);
        }
    }
}
