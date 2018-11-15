using System;
using System.IO;
using System.Xml.Serialization;

namespace Easy_Deploy.Utilities
{
    static class XmlToObject
    {
        public static Object Parse(String XML, Type type)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(type);
                MemoryStream stream = new MemoryStream();
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(XML);
                writer.Flush();
                stream.Position = 0;
                Object o = ser.Deserialize(stream);
                return o;
            }

            catch (Exception e)
            {
                Log.CriticalError("Unable to load collection data.", e);
            }

            return null;            
        }
    }
}
