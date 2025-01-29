
internal class Program
{
    private static void Main(string[] args)
    {
        // jagged array using user input
        Console.WriteLine("Enter no.of teams");
        int team = Convert.ToInt32(Console.ReadLine());
        int[][] jaggeduser = new int[team][];
        for (int i = 0; i < team; i++)
        {
            Console.WriteLine($"Enter No.of rounds played by teams {i + 1}");
            int runs = Convert.ToInt32(Console.ReadLine());
            jaggeduser[i] = new int[runs];
            for (int j = 0; j < runs; j++)
            {
                Console.Write($"No.of runs of each round {j + 1} ");
                jaggeduser[i][j] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine();
        }

        for (int i = 0; i < jaggeduser.Length; i++)
        {
            int sum = 0;

            for (int j = 0; j < jaggeduser[i].Length; j++)
            {
                sum = sum + jaggeduser[i][j];
            }
            Console.WriteLine($"The Score by team {i + 1} : {sum}");
        }

    }
}