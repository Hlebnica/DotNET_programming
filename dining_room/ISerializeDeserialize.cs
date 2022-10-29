using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;
using System.Xml.Serialization;
using Formatting = Newtonsoft.Json.Formatting;

namespace dining_room
{
    public interface ISerializeDeserialize<T> where T : Dictionary<string, object>
    {
        void SerializeDictionary(Dictionary<string, Product> dictionary, string filename);
        Dictionary<string, object> DeserializeDictionary(string filename);
    }
}