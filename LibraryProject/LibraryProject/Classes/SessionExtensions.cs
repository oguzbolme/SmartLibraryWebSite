using LibraryProject.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Classes
{
    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }

        public static List<Book> GetList(this ISession session,string key)
        {
            return session.GetObjectFromJson<List<Book>>(key) ?? new List<Book>();
        }

        public static void SetList(this ISession session, List<Book> cart,string key)
        {
            session.SetObjectAsJson(key, cart);
        }
    }
}
