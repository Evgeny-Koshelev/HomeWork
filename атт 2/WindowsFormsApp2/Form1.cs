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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Subsequence subsequence;

        public Form1()
        {
            InitializeComponent();
            subsequence = new Subsequence();
        }

        private void solutionButton_Click(object sender, EventArgs e)
        {
            int[] result = subsequence.FindSubsequence(
                                MasStringsUtilits.StrToArray<int>(arrayInputTB.Text));
            outputTB.Text = MasStringsUtilits.ArrayToStr<int>( result, "\t");
            firstIndexTB.Text = subsequence.firstIndex.ToString();
            legtnTB.Text = result.Length.ToString();
        }
    }
}
