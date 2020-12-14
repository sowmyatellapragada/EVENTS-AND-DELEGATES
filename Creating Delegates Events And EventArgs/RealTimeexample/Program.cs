using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateRealtimeExample
{
    public class Program
    {

        static void main(string args[])
        {
            Employee emp1 = new Employee()
            {


                ID = 101,
                Name = "Pranav",
                Gender = "Male",
                Experience = 5,
                Salary = 10000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Sowmya",
                Gender = "Female",
                Experience = 10,
                Salary = 20000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Sriram",
                Gender = "Male",
                Experience = 15,
                Salary = 30000
            };
            List<Employee> listEmployess = new List<Employee>();
            listEmployess.Add(emp1);
            listEmployess.Add(emp2);
            listEmployess.Add(emp3);
            Employee.PromoteEmployee(listEmployess, x => x.Experience > 5);
            Console.ReadKey();
        }
    }
}
