using System.Diagnostics.Metrics;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
                {
                    new Person {ID= 1, FirstName = "John", LastName = "Doe", Dob = new DateTime(1980, 1, 1), Wage = 1000, Address = new Address { Street = "Main Street", huisnummer = "1", provincie = Address.Provincie.Antwerpen } },
                    new Person {ID= 1, FirstName = "Ammar", LastName = "Doe", Dob = new DateTime(1978, 1, 1), Wage = 1000, Address = new Address { Street = "Main Street", huisnummer = "1", provincie = Address.Provincie.Antwerpen } },
                    new Person {ID= 2, FirstName = "Jane", LastName = "Doe", Dob = new DateTime(1981, 2, 2), Wage = 2000, Address = new Address { Street = "Main Street", huisnummer = "2", provincie = Address.Provincie.WestVlaanderen } },
                    new Person {ID= 3, FirstName = "Jim", LastName = "Doe", Dob = new DateTime(1982, 3, 3), Wage = 3000, Address = new Address { Street = "Main Street", huisnummer = "3", provincie = Address.Provincie.OostVlaanderen } },
                    new Person {ID= 4, FirstName = "Jill", LastName = "Doe", Dob = new DateTime(1983, 4, 4), Wage = 4000, Address = new Address { Street = "Main Street", huisnummer = "4", provincie = Address.Provincie.VlaamsBrabant } },
                    new Person {ID= 5, FirstName = "Jack", LastName = "Doe", Dob = new DateTime(1984, 5, 5), Wage = 5000, Address = new Address { Street = "Main Street", huisnummer = "5", provincie = Address.Provincie.WaalsBrabant } },
                    new Person {ID= 6, FirstName = "Jill", LastName = "Doe", Dob = new DateTime(1983, 4, 4), Wage = 4000, Address = new Address { Street = "Main Street", huisnummer = "4", provincie = Address.Provincie.VlaamsBrabant } },

                };

            //print smollste  person 
            var smollestePerson = people.OrderByDescending(p => p.Dob.Year).First();
            Console.WriteLine("De jongste person is : "+ smollestePerson);


            //last 3 oudstz person 
            var bigstePerson = people.OrderBy(p => p.Dob.Year).Take(3);
            Console.WriteLine("de  oudstz person is ");
            foreach (var person in bigstePerson)
            {
                Console.WriteLine(person);
            }

            //3. Wat is de gemiddelde leeftijd van de personen in Vlaams-Brabant?

            var gemiddeldeLeeftijd = people.Where(p => p.Address.provincie == Address.Provincie.VlaamsBrabant).Average(p => DateTime.Now.Year - p.Dob.Year);
            Console.WriteLine("de gemiddelde leeftijd van de personen in Vlaams-Brabant is : " + gemiddeldeLeeftijd);
            Console.WriteLine(
                "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            var grooterdan40jaar = people.Where(p  => p.Address.provincie == Address.Provincie.Antwerpen).Where(p => DateTime.Now.Year - p.Dob.Year > 40);
            Console.WriteLine("de personen die ouder zijn dan 40 jaar zijn : ");
            foreach (var person in grooterdan40jaar)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine("==================================================================================================");
            Console.WriteLine("==================================================================================================");
            Console.WriteLine("==================================================================================================");

            //Het gemiddelde brutoloon in Belgi¨e is 3558 euro per maand. Toon per persoon hoe veel meer of minder dan gemiddeld ze verdienen.
            var gemiddeldeBrutoloon = 3358;
            var personen = people.Select(p => new { p.FirstName, p.LastName, p.Wage, Verschil = p.Wage - gemiddeldeBrutoloon });
            Console.WriteLine("de gemiddelde brutoloon in Belgi¨e is : ");
            foreach (var person in personen)
            {
                Console.WriteLine(person);
            }

        }
    }
}
