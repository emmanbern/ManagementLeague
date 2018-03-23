using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace LeagueAppManagement.Helpers
{
    public static class JsonHelper
    {
        public static string Serialize<T>(this T obj)
        {
            return new JavaScriptSerializer().Serialize(obj);
        }

        public static string Serialize<T>(this IEnumerable<T> list)
        {
            return new JavaScriptSerializer().Serialize(list);

        }
    }
}