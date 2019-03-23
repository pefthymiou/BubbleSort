using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
  {
  class Program
    {
    public static class BubbleSort
      {
      public static T[] Sort<T>(T[] array) where T : IComparable
        {
        for (int i = 0; i < array.Length; i++)
          {
          bool isAnyChange = false;
          for (int j = 0; j < array.Length - 1; j++)
            {
            if (array[j].CompareTo(array[j + 1]) > 0)
              {
              isAnyChange = true;
              Swap(array, j, j + 1);
              }
            }
          if (!isAnyChange)
            {
            break;
            }
          }
        return array;
        }
      }

    public static void Swap<T>(T[] array, int first, int second)
      {
      T temp = array[first];
      array[first] = array[second];
      array[second] = temp;
      }
    static void Main(string[] args)
      {
      int[] testValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
      BubbleSort.Sort(testValues);
      Console.WriteLine(string.Join(" | ", testValues));

      Console.ReadKey();
      }
    }
  }
