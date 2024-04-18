using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp7
{
    class Array : IOutput, IMath, ISort
    {
        private int[] array;

        public int[] Elements
        {
            get
            {
                return array;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                array = value;
            }
        }

        public Array(int[] array)
        {
            Elements = array;
        }

        public void Show()
        {
            Console.WriteLine("Array elements:");
            foreach (int element in Elements)
            {
                Console.WriteLine(element);
            }
        }

        public void Show(string info)
        {
            Console.WriteLine($"Array elements ({info}):");
            foreach (int element in Elements)
            {
                Console.WriteLine(element);
            }
        }

        public int Max()
        {
            return Elements.Max();
        }

        public int Min()
        {
            return Elements.Min();
        }

        public float Avg()
        {
            return (float)Elements.Sum() / Elements.Length;
        }

        public bool Search(int valueToSearch)
        {
            return Elements.Contains(valueToSearch);
        }

        public void SortAsc()
        {
            for (int i = 0; i < Elements.Length - 1; i++)
            {
                for (int j = 0; j < Elements.Length - i - 1; j++)
                {
                    if (Elements[j] > Elements[j + 1])
                    {
                        int temp = Elements[j];
                        Elements[j] = Elements[j + 1];
                        Elements[j + 1] = temp;
                    }
                }
            }
        }

        public void SortDesc()
        {
            for (int i = 0; i < Elements.Length - 1; i++)
            {
                for (int j = 0; j < Elements.Length - i - 1; j++)
                {
                    if (Elements[j] < Elements[j + 1])
                    {
                        int temp = Elements[j];
                        Elements[j] = Elements[j + 1];
                        Elements[j + 1] = temp;
                    }
                }
            }
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }
}
