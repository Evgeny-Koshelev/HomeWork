using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Subsequence
    {
        public int firstIndex;
        int[] sequence;

        public Subsequence()
        {
            firstIndex = 0;
        }

        public int[] FindSubsequence(int[] input)
        {
            int[] maxSequence = new int[0];
            sequence = new int[1];
            sequence[0] = input[0];
        

            for (int i = 1; i < input.Length; i++)
            {
                if (Math.Abs(input[i - 1] % 2) != Math.Abs(input[i] % 2) )
                {
                    int length = sequence.Length;
                    Array.Resize<int>(ref sequence, length + 1);
                    sequence[length] = input[i];
               
                }
                else
                {
                    if (sequence.Length == 1)
                    {
                        //firstIndex = i;
                        sequence[0] = input[i];
                    }
                    else
                    {
                        if (maxSequence.Length <= sequence.Length)
                        {
                            ArrToArr(sequence, ref maxSequence);
                            firstIndex = Math.Abs(maxSequence.Length - i);
                        }
                        sequence = new int[1];
                        sequence[0] = input[i];
                    }
                }

                if (maxSequence.Length <= sequence.Length)
                {
                    ArrToArr(sequence, ref maxSequence);
                    firstIndex = Math.Abs(maxSequence.Length - i);
                }
            }
            return maxSequence;
        }
        
        void ArrToArr(int[] arr1, ref int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                Array.Resize<int>(ref arr2, i + 1);
                arr2[i] = arr1[i];
            }
        }
    }
}
