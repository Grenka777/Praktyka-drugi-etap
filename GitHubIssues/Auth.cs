using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;
using System.Windows.Forms;

namespace GitHubIssues
{
   public  class Auth
    {
       
        public async Task<List<Issue>> GetAllIssues(string token, ComboBox comboBox)
        {
         var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            
            var tokenAuth = new Credentials(token);
            client.Credentials = tokenAuth;
            var user = await client.User.Current();
             

            var gitIssues = new List<Issue>();
            var issueAsync = await client.Issue.GetAllForRepository(user.Login, comboBox.Text);
            gitIssues = issueAsync.ToList();
            
            return gitIssues;

        }

        public async  Task CreateIssue(string token, string userIssueTitle, string userIssueBody, ComboBox comboBox)
        {

            var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            var tokenAuth = new Credentials(token);
            client.Credentials = tokenAuth;
            var user = await client.User.Current();

            var createIssue = new NewIssue(userIssueTitle) { Body = userIssueBody};
            var issue = await client.Issue.Create(user.Login,comboBox.Text,createIssue);

            var issueId = issue.Id;
 
        }
       
        public async Task UpdateIssue(string token, string issueTitle, string issueBody, ComboBox ComboBoxRepo, ComboBox comboBoxNum)
        {
            var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            var tokenAuth = new Credentials(token);
            client.Credentials = tokenAuth;
            var user = await client.User.Current();

            var issueUpdate = new IssueUpdate();
            issueUpdate.Title = issueTitle;
            issueUpdate.Body = issueBody;

            await client.Issue.Update(user.Login, ComboBoxRepo.Text, Convert.ToInt32(comboBoxNum.Text), issueUpdate);



        }

      
       
    }
}
