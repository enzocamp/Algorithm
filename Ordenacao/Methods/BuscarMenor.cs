using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class BuscarMenor
    {
        private int[] numbers;
        public BuscarMenor()
        {
            numbers = new int[] { 10, 14, 7, 2, 5, 20, 65, 51 };
            Console.WriteLine(BuscaMenor(numbers));
        }
        public static int BuscaMenor(int[] array)
        {
            int smallerNumber = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < smallerNumber)
                {
                    smallerNumber = array[i];
                }
            }
            return smallerNumber;

        }

    }
}
