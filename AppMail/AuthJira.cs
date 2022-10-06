using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Newtonsoft.Json;

namespace AppMail
{
    class AuthJira
    {
        public AllDataJSON.Temperatures root;
        public AllDataJSON.Fields fields;

       private string name;
       private string password;
       public  string BaseUrl;

        public string emailToAddres;

        public string BodyEmail;
        


        public async Task GetDataProjects(TextBox name, TextBox password, TextBox host)
        {
            this.name = name.Text;
            this.password = password.Text;
            this.BaseUrl = $"{host.Text}/rest/api/3/";

            HttpClient client = new HttpClient();
            
            client.DefaultRequestHeaders.Clear();
            client.BaseAddress = new Uri(BaseUrl+"project");
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("AppName", "1.0"));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",GetEncodedCredentials());

            var response = await client.GetAsync(client.BaseAddress);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();

            List<ProjectsJSON> projects = JsonConvert.DeserializeObject<List<ProjectsJSON>>(content);

           
            await GetEmailUser();
            await GetAllData( projects);
           
        }


      private async Task GetEmailUser()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Clear();
            client.BaseAddress = new Uri(BaseUrl + "users");
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("AppName", "1.0"));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", GetEncodedCredentials());

            var response = await client.GetAsync(client.BaseAddress);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();

            var users = JsonConvert.DeserializeObject<UsersJSON[]>(content);

          this.emailToAddres =  users[0].EmailAddress;

           
          
        }

        private async Task GetAllData( List<ProjectsJSON> projects)
        {
            foreach (var item in projects)
            {
                HttpClient client = new HttpClient();

                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(BaseUrl + "search?jql=project="+item.Key );
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("AppName", "1.0"));
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", GetEncodedCredentials());

                var response = await client.GetAsync(client.BaseAddress);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();

                root = JsonConvert.DeserializeObject<AllDataJSON.Temperatures>(content);


                BodyEmail += $"Nazwa projektu: {root.Issues[0].Fields.Project.Name}\nKlucz projektu: {root.Issues[0].Fields.Project.Key}\nId projektu: {root.Issues[0].Fields.Project.Id}";
               
                for (int i = 0; i < root.Issues.Count(); i++)
                {
                    BodyEmail += $"\tKlucz issues: {root.Issues[i].Key}\n\tId Issues: {root.Issues[i].Id}\n\tCiało issues: {root.Issues[i].Fields.Summary}\n\tData tworzenia: {root.Issues[i].Fields.Created}\n";

                   

                }
            }
           
        }
       
        private  string GetEncodedCredentials()
        {
            string mergedCredentials = string.Format("{0}:{1}",name , password);
            byte[] byteCredentials = UTF8Encoding.UTF8.GetBytes(mergedCredentials);
            return Convert.ToBase64String(byteCredentials);
        }
    }
}
