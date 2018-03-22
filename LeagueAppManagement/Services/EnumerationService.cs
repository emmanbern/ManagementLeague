using System;
using System.Collections.Generic;

namespace LeagueAppManagement.Services
{
    public class EnumerationService
    {
        public List<string> GetStringsFromEnumeration<T>() where T : struct
        {
            var enumStrings = new List<string>();
            Type genericType = typeof(T);
            if (genericType.IsEnum)
            {
                foreach (T obj in Enum.GetValues(genericType))
                {
                    enumStrings.Add(obj.ToString());
                }
            }
            return enumStrings;
        }

        public List<KeyValuePair<string, int>> GetEnumerationValues<T>() where T : struct
        {
            var enumValues = new List<KeyValuePair<string, int>>();
            Type genericType = typeof(T);
            if (genericType.IsEnum)
            {
                foreach (T obj in Enum.GetValues(genericType))
                {
                    Enum intValue = Enum.Parse(typeof(T), obj.ToString()) as Enum;
                    int number = Convert.ToInt32(intValue);

                    enumValues.Add(new KeyValuePair<string, int>(obj.ToString(), number));
                }
            }
            return enumValues;
        }
    }
}