namespace Code.Parsers
{
    public interface IParser
    {
        string Serialize<T>(T data);
        T Deserialize<T>(string data);
    }
}