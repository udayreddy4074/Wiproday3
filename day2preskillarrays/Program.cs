using day2democlass;

namespace democlass
{
    internal class Program
    {
        private static void Main(string[] args)// for defult contrutor and also paramters are already defined
        {
            employee emp = new employee();
            emp.emp_id = 999;
            emp.name = "uday";
            Console.WriteLine($" Employee id:{emp.emp_id}");
            Console.WriteLine($" Employee name:{emp.name}");


            Console.WriteLine("Enter employee name");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter employee id");
            int id = Convert.ToInt32(Console.ReadLine());
            employee emp2 = new employee(id, name);
            Console.WriteLine($" Employee id:{emp2.emp_id}");
            Console.WriteLine($" Employee id:{emp2.name}");




        }
    }
}