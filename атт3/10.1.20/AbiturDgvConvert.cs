using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Utils
{
    class AbiturDgvConvert
    {
        public static Abit[] DGVToArrAbit(DataGridView dgv)
        {
            Abit[] abiturs = new Abit[dgv.Rows.Count];
            int i = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                string fio = (string)Convert.ChangeType(row.Cells["Fio"].Value, typeof(string));
                int russky = (int)Convert.ChangeType(row.Cells["Russky"].Value, typeof(int));
                int mathem = (int)Convert.ChangeType(row.Cells["Mathem"].Value, typeof(int));
                int physic = (int)Convert.ChangeType(row.Cells["Physic"].Value, typeof(int));
                bool original = (bool)Convert.ChangeType(row.Cells["Original"].Value, typeof(bool));



                abiturs[i] = new Abit(fio, russky, mathem, physic, original);
                i++;
            }

            return abiturs;
        }

        public static void AbitursToDGV(DataGridView dgv, IList<Abit> arrAbiturs)
        {
            dgv.Rows.Clear();

            foreach (Abit abitur in arrAbiturs)
            {
                dgv.Rows.Add();

                DataGridViewRow lastRow = dgv.Rows[dgv.RowCount - 1];
                lastRow.Cells["Fio"].Value = abitur.Fio;
                lastRow.Cells["Russky"].Value = abitur.Russky;
                lastRow.Cells["Mathem"].Value = abitur.Mathem;
                lastRow.Cells["Physic"].Value = abitur.Physic;
                lastRow.Cells["Original"].Value = abitur.Original;
            }
        }
    }
}
