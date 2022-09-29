using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitLabApiClient;
using GitLabApiClient.Models.Issues.Responses;
using GitLabApiClient.Models.Issues.Requests;
using GitLabApiClient.Models.Notes.Requests;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System;
namespace GitComments
{
    class GitLabAuth : RandomAlphaNumeric
    {
        HttpClient httpClient = new HttpClient();
        Projects[] projects;
        public async Task<string> GetApi(string token, string url)
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            return responseBody;
        }


        public async Task GetAllProject(string token, ComboBox comboBoxID)
        {
            var resultString = await GetApi(token, "https://gitlab.com/api/v4/projects?owned=true");
            projects = JsonConvert.DeserializeObject<Projects[]>(resultString);

            comboBoxID.Items.Clear();
            foreach (Projects project in projects)
            {
                comboBoxID.Items.Add(project.ProjectId);
            }

            comboBoxID.SelectedItem = comboBoxID.Items[0];

        }


        public async Task<List<Issue>> GetIssues(string token, ComboBox comboBoxID)
        {
            var client = new GitLabClient("https://gitlab.com", token);
            
            var user = await client.Users.GetCurrentSessionAsync();
            
            
            var labIssues = new List<Issue>();
            var issuesAsync = await client.Issues.GetAllAsync(comboBoxID.Text);
           
            labIssues = issuesAsync.ToList();

            return labIssues;
            
        }

        public async Task CreateNotes(string token, ComboBox comboBoxID, ComboBox comboBoxIssuesId, int CommentLength, int quantity)
        {
            var client = new GitLabClient("https://gitlab.com", token);
           

            try
            {

                for (int i = 0; i < quantity; i++)
                {
                   
                    var CreateComments = new CreateIssueNoteRequest(RandomString(CommentLength));
                    var issues = client.Issues.CreateNoteAsync(comboBoxID.Text,Convert.ToInt32(comboBoxIssuesId.Text), CreateComments);
                }

                MessageBox.Show("Komentarzy dodane");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
   
        }


        public async void completeComboBoxIssuesId(ComboBox comboBocIssuesID, string token, ComboBox comboBoxID)
        {         
            var data = await GetIssues(token,comboBoxID);
            foreach (var item in data)
            {
                comboBocIssuesID.Items.Add(item.Iid);
            }
            comboBocIssuesID.SelectedItem = comboBocIssuesID.Items[0];          
        }
    }
}
