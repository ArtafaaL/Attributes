using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var empluyeeList = new List<EmployeeInfo>()
            {
                new EmployeeInfo("Max", "Bondarenko", 25),
                new EmployeeInfo("Tom", "Kryachko", 12)
            };

            foreach (var employee in empluyeeList)
                employee.GetEmployeeInfo();

            EmployeeInfo.GetClassInfo();
        }
    }
}
