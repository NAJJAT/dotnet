using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee : IHasId
    {
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public Department Department { get; set; }


        //constructor
        public Employee()
        {
        }
        //constructor
        public Employee(long id, string firstName, string lastName, DateTime hireDate, decimal salary, Department department)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            HireDate = hireDate;
            Salary = salary;
            Department = department;
        }   



    }

    //Maak een enum Department 

    public enum Department
    {
        HR,
        IT,
        Sales,
        Marketing,
        Research,
        Development
    }


}
