using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serializador
{
    public class Serializadora<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            XmlTextWriter writer = null;
            XmlSerializer serializer = null;
            try
            {
                writer = new XmlTextWriter(archivo, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, datos);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            return true;
        }
        public bool Leer(string archivo, out T datos)
        {
            using (XmlTextReader reader = new XmlTextReader(archivo))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                datos = (T)serializer.Deserialize(reader);
                return true;
            }

        }
        public bool GuardarB(string archivo, T datos)
        {
            Stream stream = null;
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                stream = new FileStream(archivo, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, datos);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (!ReferenceEquals(stream, null))
                    stream.Close();
            }
        }
        public bool LeerB(string archivo, out T datos)
        {
            Stream stream = null;
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                stream = new FileStream(archivo, FileMode.Open, FileAccess.Read, FileShare.Read);
                datos = (T)formatter.Deserialize(stream);
                //stream.Close();

                return true;
            }
            catch (Exception)
            {
                datos = default(T);
                return false;
            }
            finally
            {
                if (!ReferenceEquals(stream, null))
                    stream.Close();
            }
        }
    }

    
    
}
