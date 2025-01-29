internal class Program
{
    private static void Main(string[] args)
    {
        int a = 10;
        for (; ; )
        {
            if (a <= 0)
            {
                break;
            }
            else
            {
                a = a - 2;


            }
            Console.WriteLine(a);

        }
        int x = 0;
        while (x < 5)
        {
            x++;
            if (x == 2)
            {
                break;
            }
            Console.WriteLine(x);
        }
    }
}