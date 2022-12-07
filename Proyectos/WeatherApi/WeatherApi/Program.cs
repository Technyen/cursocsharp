


using Newtonsoft.Json;

namespace WeatherAp
{
    internal class Program
    {
       

        static async Task Main(string[] args)
        {
            using var client = new HttpClient();
            string folderPath = "C:\\Countries";
            string[] filePaths = Directory.GetFiles(folderPath);
            var tasks = new List<Task<KeyValuePair<string, double>>>();

            foreach (string filePath in filePaths)
            {
               
                var gettingResult = GetResults(client, filePath);
                tasks.Add(gettingResult);
            }

            Console.WriteLine("Todas las tareas se crearon, esperando a que terminen");
            var temperatures = await Task.WhenAll(tasks);
            Console.WriteLine("Todas las tareas terminaron");
            var results = new Dictionary<string, double>(temperatures);

        }
        

        private static async Task<KeyValuePair<string, double>> GetResults(HttpClient client,string filePath)
        {
            Console.WriteLine($"leyendo el archivo {filePath}");
            var stream = await File.ReadAllTextAsync(filePath);
            var country = JsonConvert.DeserializeObject<Country>(stream);

            Console.WriteLine($"location para {country.Name}");
            var locationResponse = await client.GetAsync($"https://restcountries.com/v3.1/name/{country.Name}");
            var locationContent = await locationResponse.Content.ReadAsStringAsync();
            var locationResult = JsonConvert.DeserializeObject<List<CountryResult>>(locationContent);
            var myLat = locationResult[0].Latlng[0];
            var myLog = locationResult[0].Latlng[1];

            Console.WriteLine($"temperatura para {country.Name}");

            var tempResponse = await client.GetAsync($"http://api.weatherapi.com/v1/current.json?key=f4f2b4ef63ef4faa907200629220112&q={myLat},{myLog}");
            var tempContent = await tempResponse.Content.ReadAsStringAsync();
            var tempResult = JsonConvert.DeserializeObject<TempResult>(tempContent);
            var myTemp = tempResult.Current.Temp_c;

            var element = new KeyValuePair<string, double>(country.Name, myTemp);
            return element;
        }
    }

   

    public class Country
    {
        public string Name { get; set; }
    }
    public class CountryResult

    {
       
        public List <double> Latlng { get; set; }
    }
    class TempResult
    {
        public Current Current { get; set; }
    }
    public class Current
    {
        public double Temp_c { get; set; }

        public double Cloud { get; set; }
    }

}