using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Praca_domowa_Projekt_
{
     public class SerializeClass
    {
        public void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(fileName);
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
               var exc = MessageBox.Show(ex.ToString());
            }
        }
        public T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                        reader.Close();
                    }

                    read.Close();
                }
            }
            catch (Exception ex)
            {
                var exc = MessageBox.Show(ex.ToString());
            }

            return objectOut;
        }
        public void SaveValues(Praca v)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Praca));
            using (TextWriter textWriter = new StreamWriter(@"Text.xml"))
            {
                serializer.Serialize(textWriter, v);
            }
        }
        public Praca LoadValues()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Praca));
            using (TextReader textReader = new StreamReader(@"Text.xml"))
            {
                return (Praca)serializer.Deserialize(textReader);
            }
        }

    }
}
