using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_Sorts
{
    public class Sorting
    {
        private Sorting()
        {

        }

        // Сортировка прямым выбором
        static public void Direct_choice(int[] array, int number)
        {
            for (int i = 0; i < number; i++)
            {
                int i_max = 0;
                for (int j = 0; j < number - i; j++)
                {
                    if (array[j] > array[i_max])
                    {
                        i_max = j;
                    }
                }
                int maximum = array[i_max];
                array[i_max] = array[number - i - 1];
                array[number - i - 1] = maximum;
            }
        }

        // Сортировка прямым выбором с запоминанием минимума и максимума
        static public void Direct_choice_minmax(int[] array, int number)
        {
            for (int i = 0; i < number / 2; i++)
            {
                int i_max = i;
                int i_min = i;
                for (int j = i + 1; j < number - i; j++)
                {
                    if (array[j] > array[i_max])
                    {
                        i_max = j;
                    }
                    if (array[j] < array[i_min])
                    {
                        i_min = j;
                    }
                }

                if (number - i - 1 == i_min) // Если правая граница содержит минимальный элемент,
                                             // запоминаем его новый индекс
                {
                    i_min = i_max;
                }

                int element = array[i_max];
                array[i_max] = array[number - i - 1];
                array[number - i - 1] = element;

                element = array[i_min];
                array[i_min] = array[i];
                array[i] = element;
            }
        }

        // Сортировка прямым включением
        static public void Direct_inclusion(int[] array, int number)
        {
            for (int i = 1; i < number; i++)
            {
                int element = array[i];
                int j = i;
                while (j >= 1 && array[j - 1] > element)
                {
                    array[j] = array[i - 1]; // сдвиг элементов вправо
                    j--;
                }
                array[j] = element;
            }
        }
    }
}
