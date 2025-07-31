namespace Vraag3
{
    internal class Program
    {
        static void Main(string[] args)
        {





        }


        // link to  file 
        public string DateFolder = @"C:\Users\moham\source\repos\Examen\Examen\bin\Debug\net5.0\movies.json";

        public async Task<IEnumerable<string>> ReadFile(string filePath)
        {
            // Get all JSON files
            string[] filePaths = Directory.GetFiles(DateFolder, "*.json");
            List<string> jsonContents = new List<string>();

            // Set ProgressBar maximum to the number of files
            await Parallel.ForEachAsync(filePaths, async (filePath, _) =>
            {
                if (Path.GetExtension(filePath) == ".json")
                {
                    // Read file content asynchronously
                    string jsonContent = await File.ReadAllTextAsync(filePath);
                    jsonContents.Add(jsonContent);
                }
            });

            return jsonContents;
        }
    }
}

