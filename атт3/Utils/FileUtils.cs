using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using System.IO;

namespace Utils
{
    public class FileUtils
    {
        public static Abit[] DatabaseToAbitur(string fileName)
        {
            string[] arrProperty = File.ReadAllLines(fileName);
            Abit[] arrAriturs = new Abit[arrProperty.Length];
            for (int i = 0; i < arrProperty.Length; i++)
            {
                string[] properties = MassStringUtils.StrToArray<string>(arrProperty[i]);
                arrAriturs[i] = new Abit(Convert.ToString(properties[0]), Convert.ToInt32(properties[1]), Convert.ToInt32(properties[2]), Convert.ToInt32(properties[3]), Convert.ToBoolean(properties[4]));
            }
            return arrAriturs;
        }


        public static string AbiturToTextBox(Abit[] arrAbitur)
        {
            string str = "";
            for (int i = 0; i < arrAbitur.Length; i++)
            {
                str += Convert.ToString(arrAbitur[i].Fio) + " " + Convert.ToString(arrAbitur[i].Russky) + " " + Convert.ToString(arrAbitur[i].Mathem) + " " + Convert.ToString(arrAbitur[i].Physic) + " " + Convert.ToString(arrAbitur[i].Original) + '\n' + Environment.NewLine;
            }
            return str;
        }
        public static void Write(string path, string str)
        {
            File.WriteAllText(path, str);
        }
    }
}
