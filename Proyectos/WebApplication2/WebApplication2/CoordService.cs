using System.Diagnostics.Metrics;
using Newtonsoft.Json;
using System.IO;
using System.Xml.Linq;

namespace WebApplication2
{

    public class CoordService
    {
        private readonly HttpClient _httpClient;
        public CoordService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Coordiantes> GetCoordinates()
        {
                var locationResponse = await _httpClient.GetAsync($"https://restcountries.com/v3.1/name/Argentina");
                var locationContent = await locationResponse.Content.ReadAsStringAsync();
                var locationResult = JsonConvert.DeserializeObject<List<CountryResult>>(locationContent);
                var mycoord = new Coordiantes();
                mycoord.myLat= locationResult[0].Latlng[0];
                mycoord.myLog= locationResult[0].Latlng[1];
                return mycoord;
        }
    }
    public class CountryResult
    {
        public List<double> Latlng { get; set; }
    }

    public class Coordiantes
    {
        public double myLat;
        public double myLog;    

    }

}

