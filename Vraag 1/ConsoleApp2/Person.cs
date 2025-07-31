using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IHasId
    {
        long ID { get; set; }
    }
    public class Person :   IHasId
    {
      

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public decimal Wage { get; set; }
        public Address Address { get; set; }
        public long ID { get; set; }

        // print TOString name and lastname  and id

        public override string ToString()
        {
            return  $"{ID} {FirstName}-{LastName}";


        }

    }
}