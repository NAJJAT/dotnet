using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface Interface1
    {




        //methoed persist geen argumenten en geen return type
        void IPersist(String name);


        //IReadable methoed geen argumenten en geen return type
        void IReadable();
        //methoed IStorbale  implement biede interface IPersist and IReadable
        
        public void IStorable()
        {

            IPersist("ammar");

            IReadable();

        }








    }
}
