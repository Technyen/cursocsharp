

using System.Text.Json;

namespace Testing
{
    internal class Program
    {
        static async Task Main()
        {
            string folderPath = "C:\\Countries";
            string[] filePaths = Directory.GetFiles(folderPath);

            foreach (string filePath in filePaths)
            {
                Console.WriteLine(filePath);
            }




        }

    }

    public class Country22
    {
        public string Name { get; set; }    
     
    }
}