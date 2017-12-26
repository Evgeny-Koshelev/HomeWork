using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
   public class ClassArr
    {
        public int[] arr { get; set; }
        public ClassArr (int [] arr)
        {
            this.arr = arr;
        }

        public int[] Put (int n)
        {
            if (n < 1)
                return null;
            int[] newarr = new int[arr.Length+(arr.Length/n)];
            int count = 0;
            int countFirstArr = 0;
            for (int i=0; i <newarr.Length; i++)
            {
                if (count == n)
                {
                    newarr[i] = newarr.First();
                    count = -1;
                }
                else
                {
                    newarr[i] = arr[countFirstArr];
                    countFirstArr++;
                }

                count++;
            }
            return newarr;
        }
    }
}
