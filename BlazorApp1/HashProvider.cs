namespace BlazorApp1
{
    public interface IHashProvider
    {
        string Hash(string key);
    }

    public class HashProvider : IHashProvider
    {
        public string Hash(string key)
        {
            return HashUtility.MD5Hash(key);
        }
    }
}
