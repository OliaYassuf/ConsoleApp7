using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 3, 7, 2, 8 };

            Array array = new Array(numbers);

            array.Show();
            Console.WriteLine();

            array.SortAsc();
            array.Show("Sorted in ascending order");
            Console.WriteLine();

            array.SortDesc();
            array.Show("Sorted in descending order");
            Console.WriteLine();

            array.SortByParam(true);
            array.Show("Sorted by parameter (ascending)");
            Console.WriteLine();

            array.SortByParam(false);
            array.Show("Sorted by parameter (descending)");
        }
    }
}
