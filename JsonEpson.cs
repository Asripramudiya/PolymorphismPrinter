using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Printer
{
    class JsonEpson : IConvertEpson
    {
        public void Convert(PrinterWindows Epson)
        {
            string json = JsonConvert.SerializeObject(Epson);

            Console.WriteLine("Hasil Konversi ke json : \n");
            Console.WriteLine(json);
        }
    }
}
