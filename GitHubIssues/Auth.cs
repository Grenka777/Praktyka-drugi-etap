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

        public async Task CreateIssue(string token, string userIssueTitle, string userIssueBody, ComboBox comboBox)
        {

            var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            var tokenAuth = new Credentials(token);
            client.Credentials = tokenAuth;
            var user = await client.User.Current();
            //instancja klasy NewIssue ta wpisanie do jego konstruktora IssueTitle ta do zmienne Body, dodane przez użytownika
            var createIssue = new NewIssue(userIssueTitle) { Body = userIssueBody};
            //metoda tworzenia Issues która pobiera jako argumenty Login użytownika, nazwa repo do którego będzie dodane issues,
            //ta instancja klasy NewIssues która ma nazwe nowego issues ta jego treść
                var issue = await client.Issue.Create(user.Login,comboBox.Text,createIssue);
                
 
        }
       
        public async Task UpdateIssue(string token, string issueTitle, string issueBody, ComboBox ComboBoxRepo, ComboBox comboBoxNum)
        {
            var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            var tokenAuth = new Credentials(token);
            client.Credentials = tokenAuth;
            var user = await client.User.Current();
            //instancja klasy IssuesUpdate ta wpisanie do jego zmiennych zaktualizowaną nazway ra treść issues
            var issueUpdate = new IssueUpdate();
            issueUpdate.Title = issueTitle;
            issueUpdate.Body = issueBody;
            //metoda aktualizacji istniejącego issues która pobiera jako argumenty login użytownika, nazwa repo w którym istnieję issues,
            //jego numer, ta instancję klasy IssuesUpdate
            await client.Issue.Update(user.Login, ComboBoxRepo.Text, Convert.ToInt32(comboBoxNum.Text), issueUpdate);



        }

      
       
    }
}
