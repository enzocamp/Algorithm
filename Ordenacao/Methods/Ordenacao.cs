using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Methods
{
    public class Ordenacao
    {
        private int[] numbers;
        private int[] sortedArray;

        public Ordenacao()
        {
            numbers = new int[] { 10, 14, 7, 2, 5, 20, 65, 51 };
            sortedArray = OrdernacaoSelecao(numbers);
            Console.WriteLine(string.Join(", ", sortedArray));
        }

        public static int[] OrdernacaoSelecao(int[] array)
        {
            var arraySize = array.Length;
            int[] newArray = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                var smallerNumber = BuscarMenor.BuscaMenor(array);
                int posicaoMenorNumero = Array.IndexOf(array, smallerNumber);
                newArray[i] = smallerNumber;
                array[posicaoMenorNumero] = int.MaxValue;
            }
            return newArray;

        }
    }
}
