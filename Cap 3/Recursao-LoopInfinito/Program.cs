using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        static void Regressiva(int number)
        {
            Console.WriteLine(number);

            if (number < 1) return; // Aqui é o caso-base

            Regressiva(number - 1); // Aqui é caso-recursivo
        }

        Regressiva(10);
    }
}