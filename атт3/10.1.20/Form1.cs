using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using Logic;


namespace _10._1._20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(abiturDataGridView, 40, false, true, true, true, false);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openF = new OpenFileDialog();
            if (openF.ShowDialog() == DialogResult.OK)
            {
                AbiturDgvConvert.AbitursToDGV(abiturDataGridView, FileUtils.DatabaseToAbitur(openF.FileName));

            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Abit[] abiturs = AbiturDgvConvert.DGVToArrAbit(abiturDataGridView);
            Abit[] ansData = new Abit[(Convert.ToInt32(countPlaceTextBox.Text))];
            SelectAbitur obj = new SelectAbitur(abiturs);
            ansData = obj.Find(Convert.ToInt32(countPlaceTextBox.Text));
            ansTextBox.Text = FileUtils.AbiturToTextBox(ansData);


           
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveF = new SaveFileDialog();
            if (saveF.ShowDialog() == DialogResult.OK)
            {

                FileUtils.Write(saveF.FileName, ansTextBox.Text);
            }
        }

    }
}
