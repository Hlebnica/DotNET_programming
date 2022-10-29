using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;
using Formatting = Newtonsoft.Json.Formatting;

namespace dining_room
{
    public class Json<T> : ISerializeDeserialize<T> where T : Dictionary<string, object>
    {
        public void SerializeDictionary(Dictionary<string, object> dictionary, string filename)
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

        public Dictionary<string, object> DeserializeDictionary(string filename)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string dictionary = reader.ReadToEnd();
                    reader.Close();
                    return JsonConvert.DeserializeObject<Dictionary<string, object>>(dictionary);
                }
            }
            catch
            {
                throw new FileNotFoundException();
            }
        }
    }
}