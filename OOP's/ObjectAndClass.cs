using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetSession.OOP_s
{
    internal class Employee
    {
        // Object : 
        public string EmpName;
        public int EmployeeID;
        public void EmployeeMethod()
        {
            Console.WriteLine($"This is employee method: {EmpName} & {EmployeeID}");
        }
    }
}
