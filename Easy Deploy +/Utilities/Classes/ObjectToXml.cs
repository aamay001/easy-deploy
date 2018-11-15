using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Easy_Deploy.Utilities
{
    class ObjectToXml
    {
        public static void DumpToFile(String fileName, Object O)
        {
            XmlSerializer ser = new XmlSerializer(O.GetType());
            FileStream file = new System.IO.FileStream(fileName + ".xml", System.IO.FileMode.Create, FileAccess.Write);
            ser.Serialize(file, O);
            file.Close();
        }

        public static String DumpString(Object O)
        {
            XmlSerializer ser = new XmlSerializer(O.GetType());
            MemoryStream stream = new MemoryStream();
            ser.Serialize(stream, O);
            stream.Position = 0;
            StreamReader reader = new StreamReader(stream);
            String dump = reader.ReadToEnd();
            reader.Close();
            return dump;
        }

        public static String DumpSecureString(Object O)
        {
            return DataProtection.Encrypt(DumpString(O));
        }
    }    
}
