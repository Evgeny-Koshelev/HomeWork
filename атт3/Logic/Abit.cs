using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Abit
    {
        public string Fio { get; set; }
        public int Russky { get; set; }
        public int Mathem { get; set; }
        public int Physic { get; set; }
        public bool Original { get; set; }

        public int SummaBallov { get; set; }


        public Abit(string fio, int russky, int mathem, int physic, bool orig)
        {
            Fio = fio;
            Russky = russky;
            Mathem = mathem;
            Physic = physic;
            Original = orig;
            SummaBallov = russky + mathem + physic;
        }





    }
}

