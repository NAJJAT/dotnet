using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Author
    {
        //FirstName and LastName properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

    

    //tostring 
    public override string ToString()
        {
            return $"Author: {FirstName} {LastName}";
        }

    }
}