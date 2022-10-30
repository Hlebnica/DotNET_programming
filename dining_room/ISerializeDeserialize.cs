using System.Collections.Generic;

namespace dining_room
{
    public interface ISerializeDeserialize<T> where T : Dictionary<string, Product>
    {
        void SerializeDictionary(Dictionary<string, Product> dictionary, string filename);
        Dictionary<string, Product> DeserializeDictionary(string filename);
    }
}