using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    
    public class EncodeAndDecodeTinyURL
    {
        private readonly string shortUrl = "http://tinyurl.com/";
        Dictionary<string, string> memory = new Dictionary<string, string>();
        string shortStringSource = "abcdefthijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            var url = $"http://tinyurl.com/{Guid.NewGuid():N}";
            memory[url] = longUrl;
            return url;
        }

        public string encode2(string longUrl)
        {
            StringBuilder shortString = new StringBuilder();
            for (int i = 0; i <= 5; i++)
                shortString.Append(shortStringSource[new Random().Next(0, 61)]);
            var url = shortUrl + shortString.ToString();

            memory[url] = longUrl;

            return url;
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            return memory[shortUrl];
        }
    }
}
