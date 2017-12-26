using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Utils
{
    public class MassStringUtils
    {
        public static T[] StrToArray<T>(string str)
        {
            NumberFormatInit();
            return Array.ConvertAll(
                str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue<T>(s)
            );
        }
        static T StrToValue<T>(string str)
        {
            try
            {
                return (T)Convert.ChangeType(str, typeof(T));
            }
            catch { return default(T); }
        }
        public static void NumberFormatInit()
        {
            // чтобы вещественные числа разделялись точкой, а не запятой
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }
    }
}
