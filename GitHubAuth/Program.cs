using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace GitHubAuth
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
       static Root root;
        static async Task Main(string[] args)
        {
            Task.WaitAll(RunAsync());
            

            var repositories = await RunGitRepo();
            Console.WriteLine("Twoje repozytorium:\t");
            foreach (var repo in repositories)
            {
                Console.WriteLine("Nazwa: "+repo.Name);
                Console.WriteLine(repo.GitHubHomeUrl);
                Console.WriteLine("Obserwatorzy " + repo.Watchers);
                Console.WriteLine("\t");
            }

        }


            static async Task RunAsync()
            { 
            var token = string.Empty;
            Console.WriteLine("Wpisz personal access token GitHub ");
            token = Console.ReadLine();



            client.BaseAddress = new Uri("https://api.github.com");
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("AppName", "1.0"));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);


            var response = await client.GetAsync("/user");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
             root = JsonSerializer.Deserialize<Root>(content);

            Console.WriteLine("User: " + root.Login);

            }


           static async Task<List<Repository>> RunGitRepo() 
        {

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
            
            var streamTask = client.GetStreamAsync(root.ReposUrl);
            var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(await streamTask);

            return repositories;


        }







        
    }
}
