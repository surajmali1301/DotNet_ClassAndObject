using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_ClassAndObject.Array
{
    public class FrequencyOfElements
    {
        public void GetCount(int[]arr)
        {
            int count;

            for (int i = 0; i< arr.Length; i++)
            {
                if (arr[i] == '\0')
                    continue;
                count = 1;
            for(int j = i+1; j < arr.Length; j++)
            {
                    if (arr[i] == arr[j])
                    {
                        arr[j] = '\0';
                        count++;
                    }
            }
                Console.WriteLine(arr[i] + " ---> " + count);
            }

        }
    }
}
