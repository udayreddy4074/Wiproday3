using System;
using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        // immutable
        string str = "hello";//memory will allocated
      
           str += "world";//new string in mem will be created
        
           Console.WriteLine(str);     
        //mutable
         StringBuilder sb= new StringBuilder(" Hello");
         sb.Append("world");//mem will allocated to string builder and gets appended in the same mem
        Console.WriteLine(sb);
        Console.WriteLine("Enter string by normal string input");
        string? userinput=Console.ReadLine();//removes warning
        Console.WriteLine(userinput);
        Console.WriteLine("Enter the string append");
        string appendstr=Console.ReadLine();
        userinput += appendstr;
        Console.WriteLine(userinput);
        Console.WriteLine("Enter string using string builder");
        StringBuilder sbobj = new StringBuilder(Console.ReadLine());
        sbobj.Append(appendstr);
        Console.WriteLine(sbobj); ;

    }
}