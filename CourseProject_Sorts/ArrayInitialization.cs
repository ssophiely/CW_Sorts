using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_Sorts
{
    public class ArrayInitialization
    {
        private int[] array;
        private Random rand = new Random();
        private const int MaxValue = 10_000;
        private const int MinValue = -10_000;

        // Конструктор с параметрами
        public ArrayInitialization(int _size)
        {
            array = new int[_size];
        }

        public int GetLength()
        {
            return array.Length;
        }

        public int[] GetArray()
        {
            return array;
        }

        // Инициализация упорядоченного массива
        public void Ordered()
        {
            array[0] = rand.Next(MinValue, 0);
            for (int i = 1; i < array.Length; i++)
                array[i] = array[i - 1] + rand.Next(1, 5);
        }

        // Инициализация массива, упорядоченного в обратном порядке 
        public void ReverseOrdered()
        {
            array[array.Length - 1] = rand.Next(MinValue, 5);
            for (int i = array.Length - 2; i >= 0; i--)
                array[i] = array[i + 1] + rand.Next(1, 5);
        }

        // Инициализация частично упорядоченного массива
        public void PartOrdered(double p)
        {
            int up_index = Convert.ToInt32(array.Length * p);
            array[0] = rand.Next(MinValue, 0);
            for (int i = 1; i < up_index; i++)
                array[i] = array[i - 1] + rand.Next(1, 5);
            for (int i = up_index + 1; i < array.Length; i++)
                array[i] = rand.Next(MinValue, MaxValue);
        }

        // Инициализация неупорядоченного массива
        public void NonOrdered()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(MinValue, MaxValue);
            }
        }
    }
}
