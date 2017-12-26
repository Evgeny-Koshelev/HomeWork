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

namespace _8._1._20
{
    public partial class Form1 : Form
    {


       
        public Form1()
        {
            InitializeComponent();
           

        }

        private void Changebutton_Click(object sender, EventArgs e)
        {

           List<int> list1= MasStringsUtilits.StrToList(ListOneTextBox.Text);
            List<int> list2 = MasStringsUtilits.StrToList(ListTwoTextBox.Text);
            ClassArrList obj = new ClassArrList(list1);
            List<int> newlist = obj.Create(list2);
            ResultTextBox.Text = MasStringsUtilits.ListToStr(newlist);





        }
    }
}
