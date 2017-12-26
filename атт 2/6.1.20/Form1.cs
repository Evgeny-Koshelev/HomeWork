using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace _6._1._20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.BlueViolet;
        }

        private void Changebutton_Click(object sender, EventArgs e)
        {
            char[] massiv = MasStringsUtilits.StrToArray1(InputTextBox.Text);
            ClassArrChar obj = new ClassArrChar(massiv);
            char[] newMassiv = new Char[massiv.Length];
            int n = 0;
            obj.ChangePlusMinus(out newMassiv,out n);
            string str = MasStringsUtilits.ArrayToStr<Char>(newMassiv);
            OutTextBox.Text = str;
            CountBox.Text = Convert.ToString(n);
            
        }
    }
}
