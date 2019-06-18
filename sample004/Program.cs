using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample04
{
    class Program
    {
        static int[] randDataLists =
        {
        41,50,44,42,27,82,89,28,30,24,
        76,11,93,22,12,36,43,98, 3,66,
        74,88,65,67, 1,60,78,23,85,33,
        15,73, 2,58,20, 4,95,16,19,71,
        45,10,18,21,79,13,29,32,81,00,
        14,59, 9,39,51,84,56,57,61,52,
        26,75, 5,91,72,87,46,92,40,34,
        6,100, 7,80,64,17,38,77,25,48,
        63,69,70,55,31,96,54,49,86,83,
        68,47,97,35,90, 8,99,37,94,53,62
        };

        static void Main(string[] args)
        {
            // リストを全て順番通りに出力するLinqプラグラム
            randDataLists.ToList().ForEach(x => Console.WriteLine(x));
            // ソートプログラムを呼ぶ
            //bubbleSort(randDataLists, randDataLists.Length);
            //q_sort(randDataLists, 0, randDataLists.Length - 1);
            var req = randDataLists.ToList().OrderByDescending(x => x).ToList();
            req.ForEach(x => Console.WriteLine(x));
            // 下のforと同じ意味だ。

            // リストを全て順番通りに出力する通常のプログラム
            for (int i = 0; i < randDataLists.Length; i++)
                Console.WriteLine(randDataLists[i]);
        }

        static void bubbleSort(int[] numbers, int array_size)
        {
            int i, j, temp;

            for (i = 0; i < (array_size - 1); i++)
            {
                for (j = (array_size - 1); j > i; j--)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }

        static void q_sort(int[] numbers, int left, int right)
        {
            int pivot, l_hold, r_hold;

            l_hold = left;
            r_hold = right;
            pivot = numbers[left];
            while (left < right)
            {
                while ((numbers[right] >= pivot) && (left < right))
                    right--;
                if (left != right)
                {
                    numbers[left] = numbers[right];
                    left++;
                }
                while ((numbers[left] <= pivot) && (left < right))
                    left++;
                if (left != right)
                {
                    numbers[right] = numbers[left];
                    right--;
                }
            }
            numbers[left] = pivot;
            pivot = left;
            left = l_hold;
            right = r_hold;
            if (left < pivot)
                q_sort(numbers, left, pivot - 1);
            if (right > pivot)
                q_sort(numbers, pivot + 1, right);
        }

    }
}
