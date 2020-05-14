using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Printer
{
    class JsonCanon : IConvertCanon
    {
        public void Convert(PrinterWindows Canon)
        {
            string json = JsonConvert.SerializeObject(Canon);

            Console.WriteLine("Hasil Konversi ke json : \n");
            Console.WriteLine(json);
        }
    }
}
