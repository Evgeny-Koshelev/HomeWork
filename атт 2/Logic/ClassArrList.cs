using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ClassArrList
    {
        public List<int> arrlist1 { get; set; }

        //public List<int> arrlist { get; set; }
        public ClassArrList(List <int> arrlist)
        {
            //this.arrlist = arrlist;
            this.arrlist1 = arrlist;
        }

        public List<int> Create(/*out List<int> LIST,**/ List<int> LIST2)
        {

            List<int> newList = arrlist1;
          //  newList = arrlist1;
            for(int i = 0; i < LIST2.Count; i++)
            {
                newList.Add(LIST2[i]);
            }
            newList.Sort();
            /*LIST2 = arrlist1;
            LIST = arrlist;
            LIST.Concat(LIST2);
             for (int i=0;i<LIST.Count;i++)
            {
                for (int j=i+1;j<LIST.Count;j++)
                {
                    if (LIST[i]<LIST[j])
                    {
                        int temp = LIST[i];
                        LIST[i] = LIST[j];
                        LIST[j] = temp;
                    }
                    

                }
               
            }*/
            return newList;
           

        }




    }
}
