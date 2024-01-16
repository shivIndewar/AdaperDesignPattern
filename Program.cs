using AdaperPattern.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaperPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployee emp = new EmployeeAdapter();
            string value = emp.GetAllEmployees();
            Console.ReadLine();
        }
    }
}
