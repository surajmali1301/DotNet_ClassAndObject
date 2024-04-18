using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_ClassAndObject.Array
{
    public class RemoveElementUsingIndex
    {
        public static int[] RemoveElement(int[] arr, int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                return arr;
            }

            int[] newArr = new int[arr.Length - 1];
            int newIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != index)
                {
                    newArr[newIndex++] = arr[i];
                }
                else if (arr[i] == index)
                {
                    newArr[newIndex--] = arr[i];
                }
            }
            return newArr;
        }

        //static void Main(string[] args)
        //{
        //    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //    Console.Write("Enter the index to remove element: ");
        //    int index = Convert.ToInt32(Console.ReadLine());

        //    arr = RemoveElement(arr, index);

        //    Console.WriteLine("Array after remove element at index " + index);
        //    foreach (int num in arr)
        //    {
        //        Console.Write(num + " ");
        //    }
        //}
    }
}
