using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveAllTheMarkedElementsofaList
{
    class Kata
    {
        public static int[] Remove(int[] integerList, int[] valuesList)
        {
            List<int> result = new List<int>();
            
            foreach(int iter in integerList)
            {
                int contains = Array.IndexOf(valuesList, iter);
                if (contains == -1)
                    result.Add(iter);
            }
            int[] resultArray = result.ToArray();
            return resultArray;
        }
    }
}
