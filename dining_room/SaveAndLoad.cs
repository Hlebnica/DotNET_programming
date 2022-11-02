using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;
using Formatting = Newtonsoft.Json.Formatting;


namespace dining_room
{
    public class Json<T> : ISerializeDeserialize<T> where T : Dictionary<string, Product> // Сериализация и десериализация JSON формата
    {
        public void SerializeDictionary(Dictionary<string, Product> dictionary, string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.Write(JsonConvert.SerializeObject(dictionary, Formatting.Indented));
                    writer.Close();
                }
            }
            catch
            {
                throw new FileNotFoundException();
            }
        }

        public Dictionary<string, Product> DeserializeDictionary(string filename)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string dictionary = reader.ReadToEnd();
                    reader.Close();
                    return JsonConvert.DeserializeObject<Dictionary<string, Product>>(dictionary);
                }
            }
            catch
            {
                throw new FileNotFoundException();
            }
        }
    }

    public class Xml<T> : ISerializeDeserialize<T> where T : Dictionary<string, Product>
    {
        public void SerializeDictionary(Dictionary<string, Product> dictionary, string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Dictionary<string, Product>));
                    serializer.Serialize(writer, dictionary);
                    writer.Close();
                }
            }
            catch
            {
                throw new FileNotFoundException();
            }
        }

        public Dictionary<string, Product> DeserializeDictionary(string filename)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Dictionary<string, Product>));
                    Dictionary<string, Product> dictionary = serializer.Deserialize(reader) as Dictionary<string, Product>;
                    reader.Close();
                    return dictionary;
                }
            }
            catch
            {
                throw new FileNotFoundException();
            }
        }
    }
}