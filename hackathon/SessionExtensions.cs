using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace hackathon
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession sSession,string key, T value)
        {
            sSession.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T Get<T>(this ISession sSession, string key)
        {
            var value = sSession.GetString(key);

            return null == value ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}