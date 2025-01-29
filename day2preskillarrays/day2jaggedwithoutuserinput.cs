internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("jagged array direct input:");
        int[][] ja = new int[5][];
        ja[0] = new int[] { 1 ,2,3,4,5};
        ja[1] = new int[] { 1, 2 };
        ja[2] = new int[] {1,2,3 };
        ja[3] = new int[] {1,2,3,4};
        ja[4] = new int[] {1,2,3,4,5};
        Console.WriteLine("here is your jagged array");
            for (int i = 0; i < ja.Length; i++)
        {

            for (int j = 0; j < ja[i].Length; j++)
            {
                Console.Write(ja[i][j] + " ");
            }
            Console.WriteLine();
        }
       
        
    }
}