using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2democlass
{
    internal class employee
    {
        public int emp_id { get; set; }
        public string name {  get; set; }   

        public employee(int eid,string ename)//parameterized constructor 
        {
            emp_id = eid;
            name = ename;

        }
        public employee() //default constuctor
        {
            Console.WriteLine("default constuctor");
        }
    }
}
