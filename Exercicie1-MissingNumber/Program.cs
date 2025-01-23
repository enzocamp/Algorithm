// https://leetcode.com/problems/missing-number/description/
// Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.

using System.Globalization;

class Program
{
    public static void Main(String[] args)
    {
        int[] nums = { 0, 1 };

        var retorno = MissingNumber(nums);
        Console.WriteLine(string.Join(",", retorno));
    }


    static int MissingNumber(int[] nums)
    {
        var listaOrdenada = nums.OrderBy(a => a).ToArray();

        var menorPosicaoLista = 0;
        var maiorPosicaoLista = nums.Length - 1;
        var posicaoMeio = 0;

        if (listaOrdenada[0] != 0) return 0;

        while (menorPosicaoLista <= maiorPosicaoLista) {

            posicaoMeio = (menorPosicaoLista + maiorPosicaoLista) / 2;

            if(posicaoMeio == listaOrdenada[posicaoMeio])
            {
                var proximaPosicao = posicaoMeio + 1;
                if (listaOrdenada.Length <= proximaPosicao)
                    return listaOrdenada.Length;

                if (listaOrdenada[posicaoMeio] + 1 != listaOrdenada[proximaPosicao])
                {
                    return proximaPosicao;
                }

                menorPosicaoLista = proximaPosicao;
            }

            if (posicaoMeio < listaOrdenada[posicaoMeio])
            {
                maiorPosicaoLista = posicaoMeio - 1;
            }
        }

        return listaOrdenada.Length;
    }
}