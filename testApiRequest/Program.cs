
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace testApiRequest
{      
    class Program
    {
        static HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {

         var repositories =  await RunAsync();

            Console.WriteLine("Twoje repozytorium: ");
            foreach (var repo in repositories)
            {
                Console.WriteLine(repo.Name);
                Console.WriteLine(repo.GitHubHomeUrl);
                Console.WriteLine("Obserwatorzy " + repo.Watchers);
                Console.WriteLine();
            }

            
        }

       
        static async Task<List<Repository>> RunAsync()
        {

            string userName;
            Console.WriteLine("Wpisz username konta github");
            userName = Console.ReadLine();
            

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var streamTask = client.GetStreamAsync("https://api.github.com/users/"+userName+"/repos");
            var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(await streamTask);

            return repositories;

          


        }















        }
}
