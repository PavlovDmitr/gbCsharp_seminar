using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalArrayMaster
{

    public class ArrayMaster
    {
        int[] storage = new int[0];
        int count = 0;

        public void Add(int item)
        {
            Array.Resize(ref storage, count+1);
            storage[count++] = item;
        }

        public int GetValue(int index)
        {
            return storage[index];
        }

        public int GetCount()
        {
            return count;
        }

        public static int[] ArrConvertDobleToInt(double[] insArray)
        {
            int[] result = new int[insArray.Length];
            for (int i = 0; i < insArray.Length; i++)
            {
                result[i] = Convert.ToInt32(insArray[i]);
            }

            return result;
        }
        /// <summary>
        /// Сортировка выбором
        /// </summary>
        /// <param name="array">массив для сортировки</param>
        /// <param name="select">выбор true - по возрастанию, false - по убыванию</param>
        /// <returns>результат</returns>
        public static int[] SelectionSort(int[] array, bool select)
        {
            if (!select)
            {
                int min = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    min = i;
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j] < array[min]) min = j;
                        (array[min], array[i]) = (array[i], array[min]);
                    }

                }
            }
            else
            {
                int max = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    max = i;
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j] > array[max]) max = j;
                        (array[max], array[i]) = (array[i], array[max]);
                    }

                }
            }
            return array;
        }

        
    }
}
