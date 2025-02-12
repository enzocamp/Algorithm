class Program
{
    public static void Main(string[] args)
    {
        int fat(int x)
        {
            if (x == 1) return 1;

            else return x * fat(x - 1);
        }

        fat(3);

    }
}