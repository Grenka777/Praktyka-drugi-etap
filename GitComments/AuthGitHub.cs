using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;
using System.Windows.Forms;

namespace GitComments
{
    class AuthGitHub : RandomAlphaNumeric
    {

        public async Task<List<Issue>> GetAllIssues(string token, ComboBox comboBox)
        {
            //tworzą nowy objekt klasy GGitHubClient z biblioteki Octokit
            var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            //wpisuje do clienta token autoryzacji
            var tokenAuth = new Credentials(token);
            client.Credentials = tokenAuth;
            var user = await client.User.Current();

            //pobieram wszyskie issues w wybranym przez combobox repo i zwracam wynik
            var gitIssues = new List<Issue>();
            var issueAsync = await client.Issue.GetAllForRepository(user.Login, comboBox.Text);
            gitIssues = issueAsync.ToList();

            return gitIssues;



        }



        public async Task CreateComents(string token, ComboBox comboBoxRepo,ComboBox comboBoxNum, int ComentsLegth, int length)
        {
            var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            var tokenAuth = new Credentials(token);
            client.Credentials = tokenAuth;
            var user = await  client.User.Current();

            try
            {
                for (int i = 0; i < length; i++)
                {
                    var ComentCreate = client.Issue.Comment.Create(user.Login, comboBoxRepo.Text, Convert.ToInt32(comboBoxNum.Text), RandomString(ComentsLegth)); 
                }
                MessageBox.Show("Komentarzy dodane");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

          

        }


        public async Task ShowLimit(string token,System.Windows.Forms.Label labelLimit1, System.Windows.Forms.Label labelRemaining1, System.Windows.Forms.Label labelReset1)
        {
            var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            var tokenAuth = new Credentials(token);
            client.Credentials = tokenAuth;

            var miscellaneousRateLimit = await client.Miscellaneous.GetRateLimits();

            var searchRateLimit = miscellaneousRateLimit.Resources.Search;

            var limit = searchRateLimit.Limit;
            var remaining = searchRateLimit.Remaining;
            var reset = searchRateLimit.Reset;
            

            labelLimit1.Text = Convert.ToString(limit);
            labelRemaining1.Text = Convert.ToString(remaining);
            labelReset1.Text = Convert.ToString(reset);
        }

        public async void CompleteComboboxRepo(string token, ComboBox comboBoxRepo)
        {
           
            var client = new GitHubClient(new Octokit.ProductHeaderValue("my-cool-app"));
            var tokenAuth = new Credentials(token);
            client.Credentials = tokenAuth;
            var user = await client.User.Current();
            var repos = await client.Repository.GetAllForCurrent();

            foreach (var item in repos)
            {
                comboBoxRepo.Items.Add(item.Name);
            }
            comboBoxRepo.SelectedItem = comboBoxRepo.Items[0];

           
        }

        public async void CompleteComboBoxIssues(string token,ComboBox comboBoxRepo, ComboBox comboBoxNumIssues)
        { 
            var data = await GetAllIssues(token, comboBoxRepo);
            foreach (var item in data)
            {
                comboBoxNumIssues.Items.Add(item.Number);
            }
            if (comboBoxNumIssues.Items.Count == 0)
            {
                MessageBox.Show("Wybrany repozytorium nie ma issues");
            }
            else
            {
                comboBoxNumIssues.SelectedItem = comboBoxNumIssues.Items[0];
            }
           


        }
















    }
}
