using ClassLibrary1.DTO;
using Newtonsoft.Json;
using System.Collections.Concurrent;

namespace ClassLibrary1
{
    public class MovieFatcher
    {
        private const String DateFolder = @"C:\Users\ooo77\Downloads\movies";

        public event EventHandler<int>? MovieFetched;


        public  async Task<IEnumerable<Movie>> FetchMoviesAsync()
        {
            // Get all JSON files
            string[] filePaths = Directory.GetFiles(DateFolder, "*.json");
            // Set ProgressBar maximum to the number of files
            var movies = new List<Movie>(50_000);
            // Use a thread-safe collection
            await Parallel.ForEachAsync(filePaths, async (filePath, _) =>
            {
                // Read file content asynchronously
                string jsonContent = await File.ReadAllTextAsync(filePath);
                // Deserialize JSON into Movie object
                var movie = JsonConvert.DeserializeObject<Movie>(jsonContent);
                // Add the movie to the collection
                movies.Add(movie);
                // Raise the MovieFetched event
                await Task.Run(() => MovieFetched?.Invoke(this, movies.Count)); 

                

            }); 
            return movies;
        }



        //filter movies
        public IEnumerable<Movie> FilterMovies(IEnumerable<Movie> movies, String searchTerm)
        {       
                
            if (String.IsNullOrWhiteSpace(searchTerm))
            {
                throw new InvalidInputException("Search term cannot be empty");
            }
            if (searchTerm.Length<= 2)
            {
                throw new InvalidInputException("length under 2");
            }
            var searchResult =
                movies
                  .Where(movie => movie.primaryTitle.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase))
                  .OrderBy(movie => movie.ToString())
                  .ToList();
            return searchResult;
        }

    }
}
