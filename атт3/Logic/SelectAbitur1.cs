using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace Logic
{
    public class SelectAbitur
    {
        public Abit[] Database { get; set; }
        public SelectAbitur(Abit[] database)
        {
            this.Database = database;
        }

        public Abit[] Find(int n)
        {
            Abit[] selectAbit = new Abit[n];

            for (int i = 0; i < n; i++)
            {
                selectAbit[i] = new Abit(" ", 0, 0, 0, false);

            }
            Sort();
            int j = 0;
            for (int i = 0; i < Database.Length; i++)
            {
                if (Database[i].Original)
                {
                    selectAbit[j] = Database[i];
                    j++;
                    if (j == n)
                        break;
                }
            }
            return selectAbit;
        }
        public void Sort()
        {
            for (int i = Database.Length - 1; i >= 0; i--)
                for (int j = 0; j < i; j++)
                {
                    if (Database[j].SummaBallov < Database[j + 1].SummaBallov)
                        Swap(ref Database[j], ref Database[j + 1]);
                    if (Database[j].SummaBallov == Database[j + 1].SummaBallov)
                    {
                        if (Database[j].Mathem < Database[j + 1].Mathem)
                            Swap(ref Database[j], ref Database[j + 1]);
                        if (Database[j].Mathem == Database[j + 1].Mathem)
                        {
                            if (Database[j].Physic < Database[j + 1].Physic)
                            {
                                Swap(ref Database[j], ref Database[j + 1]);
                            }

                        }
                    }

                }



        }
        private void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
       


    }
}
