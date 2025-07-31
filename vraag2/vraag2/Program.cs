namespace vraag2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "panda";
            char result = MostFrequentChar(input);
            Console.WriteLine(result);
           
            string[] words = { "computer", "muis", "toetsenbord", "usb", };
              Console.WriteLine(string.Join(", ", MinimumLength(words)));

            // make Range  methoed   van getallen van 30 tot 100 with LINQ
            //list numbers from 30 to 100
            int[] numbers = { 30,54,3,14,25,82,1,100,23,95};
            Console.WriteLine(string.Join(", ", Range(numbers)));
            int[] nummers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            String[] numb = { "nul" ,"een","twee", "drie" ,"vier"," vijf"};
            var uitvoer = OddOrEven(nummers);
            Console.WriteLine(string.Join(", ", uitvoer));

            //input values  STArt and end with  methoed
            string[] wordss = { "computer", "muis", "toetsenbord", "usb", };
            char start = 'c';
            char end = 'r';
            Console.WriteLine(string.Join(", ", StartAndEndWith(wordss, start, end)));






        }





        // motethoed  MostFrequentChar met  LINQ
        public static char MostFrequentChar(string input)
        {
            return input.GroupBy(c => c)
                .OrderByDescending(g => g.Count())
                .First()
                .Key;
        }

        // method MinimumLength meer  5 tekens with LINQ
        public static IEnumerable<string> MinimumLength(string[] words)
        {
            return words.Where(w => w.Length > 5);
        }


        //make Range  methoed   van getallen van 30 tot 100 with LINQ +sorteer van hoog naar laag
        public static IEnumerable<int> Range(int[] number)
        {
            return number.Where(n => n > 30 && n < 100)
                .OrderByDescending(n => n);
        }


        public static IEnumerable<string> OddOrEven(IEnumerable<int> numbers)
        {
            return numbers.Select(n => n % 2 == 0 ? "even" : "odd");
        }



        //mak  methoed  StartAndEndWith  met LINQ
        public static IEnumerable<string> StartAndEndWith(string[] words, char start, char end)
        {
            return words.Where(w => w.StartsWith(start) && w.EndsWith(end));
        }





    }
}
