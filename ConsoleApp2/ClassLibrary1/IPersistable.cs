using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal interface IPersistable
    {

        //persist method property name

         void Persist(String name)
        {
            Console.WriteLine("Persisting...");
        }

    }
}
