using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ClassArrChar
    {
        public char[] arrChar { get; set; }

        public ClassArrChar(char[] arrChar)
        {
            this.arrChar = arrChar;
        }

        public void ChangePlusMinus(out char[] newarrChar,out int n)
        {
            newarrChar = arrChar;
            n = 0;
            for (int i= 0;i < newarrChar.Length;i++)
            {
                if (newarrChar[i] == '+')
                {
                    n++;
                    newarrChar[i] = '-';
                }
                
            }
            //return arrChar;
        }
    }
}
