using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }

        Console.WriteLine("enter you mark");
        string grade = "";
        int m = int.Parse(Console.ReadLine());
        if (m > 95 && m <= 100)
        {
            Console.WriteLine("Grade A");
            grade = "A";
        }
        else if (m > 90 && m <= 95)
        {
            Console.WriteLine("Grade B");
            grade = "B";
        }
        else if (m > 80 && m <= 90)
        {
            Console.WriteLine("Grade C");
            grade = "C";
        }
        else if (m > 70 && m <= 80)
        {
            Console.WriteLine("Grade D ");
            grade = "D";
        }
        else if (m < 70)
        {
            Console.WriteLine("fail");
            grade = "";
        }
        else
        {
            Console.WriteLine(" Enter correct input");
        }
        switch (grade)
        {


            case "A":
                Console.WriteLine(" outstanding");
                break;

            case "B":
                Console.WriteLine("excellent");
                break;
            case "C":
                Console.WriteLine(" very good");
                break;

            case "D":
                Console.WriteLine("good");
                break;
            default:
                Console.WriteLine(" try to improve");
                break;


        }
    }
}