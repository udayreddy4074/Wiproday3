internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter row size ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter col size ");
        int col = Convert.ToInt32(Console.ReadLine());
        int[,] mdarr = new int[row, col];
        for (int i = 0; i < row; i++)//read
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write($" elemnts[{i},{j}]:");
                int ele = Convert.ToInt32(Console.ReadLine());//mdarr=int.Parse(Console.ReadLine());
                mdarr[i, j] = ele;
            }
        }
        Console.WriteLine();

        for (int i = 0; i < row; i++)//display
        {

            for (int j = 0; j < col; j++)
            {

                Console.Write(mdarr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        //sum of elements in mdarray
        int sum = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                sum += mdarr[i, j];
            }
        }
        Console.WriteLine("sum of elements in mdarray is:"+sum);
    }  }