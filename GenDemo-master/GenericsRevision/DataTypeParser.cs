using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsRevision
{
    public class DataTypeParser
    {
        public static T1 Parse<T1, T2>(string stringToParse)
            where T1 : T2
            where T2 : IAsyncResult
        {
            try
            {
                return (T1)Convert.ChangeType(stringToParse, typeof(T1));
            }
            catch
            {
                return default(T1);
            }
        }
        public static bool ParseBool(string stringToParse)
        {
            bool resBool;
            bool.TryParse(stringToParse, out resBool);
            return resBool;
        }
        public static int ParseInt(string stringToParse)
        {
            int resInt;
            int.TryParse(stringToParse, out resInt);
            return resInt;
        }
        public static decimal ParseDecimal(string stringToParse)
        {
            decimal resDec;
            decimal.TryParse(stringToParse, out resDec);
            return resDec;
        }
        public static Object Parse(string stringToParse, DataType type)
        {
            switch (type)
            {
                case DataType.Int:
                    return ParseInt(stringToParse);
                case DataType.Decimal:
                    return ParseDecimal(stringToParse);
                case DataType.Boolean:
                    return ParseBool(stringToParse);
                default:
                    return stringToParse;
            }
        }
        public static Object Parse(string stringToParse, Type type)
        {

            if (type == typeof(int))
            {
                return ParseInt(stringToParse);
            }
            else if (type == typeof(bool))
            {
                return ParseBool(stringToParse);
            }
            else if (type == typeof(decimal))
            {
                return ParseDecimal(stringToParse);
            }
            else
            {
                return stringToParse;
            }
            //switch (type.ToString())
            //{
            //    case typeof(int).ToString():
            //        return ParseInt(stringToParse);
            //    case DataType.Decimal:
            //        return ParseDecimal(stringToParse);
            //    case DataType.Boolean:
            //        return ParseBool(stringToParse);
            //    default:
            //        return stringToParse;
            //}
        }
    }
    public enum DataType
    {
        Int,
        Boolean,
        Decimal
    }
}
