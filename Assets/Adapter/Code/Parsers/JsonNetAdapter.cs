using Newtonsoft.Json;

namespace Code.Parsers
{
    public class JsonNetAdapter : IParser
    {
        public string Serialize<T>(T data)
        {
            return JsonConvert.SerializeObject(data);
        }

        public T Deserialize<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}