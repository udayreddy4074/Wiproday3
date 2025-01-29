
internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = new int[4];
        arr[1] = 50;
        arr[3] = 150;
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        int[] a = { 1, 2, 13, 4, 85 };
        show(a);
        findmax(a);
    }

    public static void show(int[] a)
    {
        foreach (int v in a)
        {
            Console.WriteLine(v);
        }
    }

    static void findmax(int[] a)
    {
        int m = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > m)
            {
                m = a[i];
            }
            Console.WriteLine("Max value is: " + m);
        }
        Console.WriteLine("FinalMax value is: " + m);
    }



}