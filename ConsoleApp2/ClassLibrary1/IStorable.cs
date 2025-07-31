using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal interface IStorable :IReadable, IPersistable
    
    {
        
        //read method
        public void Read()
        {
            Console.WriteLine("Reading...");
        }
        //persist method property name
        public void Persist(String name)
        {
            Console.WriteLine("Persisting...");


        }
        //Transform method met argumenten een  delegate en  die referentie naar een methoed met geen argumenten en geen return type
        public void Transform(Func<string> transform)
        {
            Console.WriteLine("Transforming...");
        }

    }

}
