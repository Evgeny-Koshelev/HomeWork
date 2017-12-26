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

namespace _7._1._20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreatNewString_Click(object sender, EventArgs e)
        {
            int[] arr = MasStringsUtilits.StrToArray<int>(FirstBox.Text);
            ClassArr obj = new ClassArr(arr);
            int[] newArr = obj.Put(Convert.ToInt32(Long.Text));
            if (newArr!=null)
                OuttextBox.Text = MasStringsUtilits.ArrayToStr<int>(newArr);
        }
    }
}
