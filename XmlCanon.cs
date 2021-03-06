﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Printer
{
    class XmlCanon : IConvertCanon
    {
        public void Convert(PrinterWindows Canon)
        {
            using (StringWriter writer = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(PrinterWindows));
                serializer.Serialize(writer, Canon);

                string xml = writer.ToString();

                Console.WriteLine("Hasil Konversi ke XML : \n");
                Console.WriteLine(xml);
            };
        }
    }
}
