using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Logic
{
    public class MasStringsUtilits
    {
        public static Char[] StrToArray1(string str)
        {
            NumberFormatInit();
            //return Array.ConvertAll(
            ///str.Split(new char[] { '', }, StringSplitOptions.RemoveEmptyEntries),
            //(s) => StrToValue<T>(s)
            //);
            char[] mass = new Char[str.Length];
            for ( int i = 0; i < str.Length; i++)
            {
                mass[i] = Convert.ToChar(str.Substring(i, 1));
            }
            return mass;
        }
        public static T[] StrToArray<T>(string str)
        {
            NumberFormatInit();
            return Array.ConvertAll(
            str.Split(new char[] { ' ', ',','\r'}, StringSplitOptions.RemoveEmptyEntries),
            (s) => StrToValue<T>(s)
            );
        }

        public static string ArrayToStr<T>(List<T> list2)
        {
            throw new NotImplementedException();
        }

        public static string ArrayToStr<T>(T[] arr, string separator = " ")
        {
            return arr == null ? "null" : String.Join(separator, arr);
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
        public static List<int> StrToList(string str)
        {
            NumberFormatInit();
            //return List<T>.ConvertAll( 
            // str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries), 
            // (s) => StrToValue<T>(s) 
            //); 
            //List<int> lst= new List<int>; 
            //re List < int > lst = new List<int>(); 
            return new List<int>(str.Split(',',' ').Select(int.Parse));

        }
        /* public static T[] ListToArray<T>(string str) 
        { 
        T[] A= Array.ConvertAll( 
        str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries), 
        (s) => StrToValue<T>(s)); 
        List<T> l = A; 

        }*/
        public static string ListToStr(List<int> list1)
        {
            string str = Convert.ToString(list1[0]);
            for (int i = 1; i < list1.Count; i++)
            {
                str += "," + list1[i];
            }
            return str;
        }
    }
}
