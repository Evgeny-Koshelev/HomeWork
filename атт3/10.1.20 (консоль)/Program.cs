using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using Utils;

namespace _10._1._20__консоль_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к базе данных");
            string fileName = Console.ReadLine();
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            Abit[] database = FileUtils.DatabaseToAbitur(fileName);
            Console.WriteLine("база данных:");
            for (int i = 0; i < database.Length; i++)
            {
                Print(database[i]);
            }
            Abit[] ansData = new Abit[n];

            SelectAbitur obj = new SelectAbitur(database);

            ansData = obj.Find(n);
            Console.WriteLine(" поступили");
            for (int i = 0; i < ansData.Length; i++)
            {
                Print(ansData[i]);
            }
            Console.WriteLine("Введите путь для сохраниения файла");
            string fname = Console.ReadLine();
            FileUtils.Write(fname, FileUtils.AbiturToTextBox(ansData));
            Console.ReadKey();

        }

        public static void Print(Abit f)
        {
          
            {
                Console.WriteLine(" {0} {1}  {2}  {3} {4} ", f.Fio, f.Russky, f.Mathem, f.Physic, f.Original);
            }
        }
    }

}
