using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Выбором
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввести количество элементов: ");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            //Заполнение массива и вывод начального массива
            Random ran = new Random();
            Console.Write("Исходный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ran.Next(1, 100);
                Console.Write("  {0}", array[i]);
            }
            Console.WriteLine();
            //Сортировка и ввыод массива
            Console.WriteLine("Упорядоченный массив: {0}", string.Join("  ", СhoiceSort(array)));

            Console.ReadLine();
        }


        //сортировка выбром
        static int[] СhoiceSort(int[] array)
        {
            int min = 0, temp = 0;
            for (int i = 0; i < 5 - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < 5; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                temp = array[i];
                array[i] = array[min];
                array[min] = temp;

            }
            return array;
        }
        
    }
}
