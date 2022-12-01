using System;
using System.Text;
using Newtonsoft.Json;


namespace Traduccion22
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Input a word to translate English to Chinese or input 0 to change the languages");

            var wordTranslate = Console.ReadLine();

            string url;

            using var client = new HttpClient();

            if (wordTranslate == "0")
            {
                await PrintLanguages(client);

                Console.WriteLine("Choose the origin languages");
                var languageOrigin = Console.ReadLine();

                Console.WriteLine("Input a word");
                wordTranslate = Console.ReadLine();

                Console.WriteLine("Choose the destiny languages");
                var languageDestiny = Console.ReadLine();

                url = $"https://translate.argosopentech.com/translate?q={wordTranslate}&source={languageOrigin}&target={languageDestiny}";


            }
            else
            {

                url = $"https://translate.argosopentech.com/translate?q={wordTranslate}&source=en&target=zh";
            }

            await PrintTranslation(url, client);
        }

        private static async Task PrintLanguages(HttpClient client)
        {
            var getContent = await client.GetStringAsync("https://translate.argosopentech.com/languages");

            var languageResults = JsonConvert.DeserializeObject<List<LanguageResult>>(getContent);

            foreach (var item in languageResults)
            {
                Console.WriteLine($"For {item.Name} use {item.Code}");
            }
        }

        private static async Task PrintTranslation(string url, HttpClient client)
        {
            var response = await client.PostAsync(url, null);

            var content = await response.Content.ReadAsStringAsync();


            var translationResult = JsonConvert.DeserializeObject<TranslationResult>(content);

            Console.WriteLine(translationResult.TranslatedText);
        }
    }
    class TranslationResult
    {
        public string TranslatedText { get; set; }
    }

    class LanguageResult
    {
        public string Code { get; set; }

        public string Name { get; set; }
    }
}