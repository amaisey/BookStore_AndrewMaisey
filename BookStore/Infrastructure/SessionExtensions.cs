using System;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace BookStore.Infrastructure
{
    public static class SessionExtensions
    {
        //this makes the cart object into a json string file, then back again. Cant store material for session without it.
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);

            return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}
