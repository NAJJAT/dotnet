using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Document : EntityBase,IStorable
    {
        //deze klaas  bevat Content and  Author CreationDate properties
        public string Content { get; set; }
        public Author Author { get; set; }
        public DateTime CreationDate { get; set; }


        //constructer default met  voor name and  echter name onbekend
        public Document()
        {
            //Author object
            Author = new Author();
            Author.FirstName = "Onbekand";
            Author.LastName = "onbekant";
        }
        public  Document( string firstName)
        {
            //Author object
            Author = new Author();
            Author.FirstName = firstName;
          
        }



        //constructor met Firstname and lastName
        public Document(string firstName, string lastName)
        {
            //Author object
            Author = new Author();
            Author.FirstName = firstName;
            Author.LastName = lastName;
        }

        //override methoed van interface
             public void Read()
        {
            Console.WriteLine("Reading document");
        }

        //override methoed van interface
        public  void persist()
        {
            Console.WriteLine("Persisting document");
        }

        //override methoed van interface 
        public void Transform()

        {
            



        }





        public override string ToString()
        {
            return $"Document:  {Author} ";
        }
    }

   
    }
