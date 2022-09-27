using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace GitHubIssues
{
    class DBConnect
    {
        ProtectedIssues protectedIssues = new ProtectedIssues();
        Auth auth = new Auth();
        static string connString = @"Data Source=C:\Users\Xopero\Desktop\Program\Praktyka 2 etap\GitHubIssues\BazaDanych\BDIssues.db; Version=3;";
        readonly SQLiteConnection sql_con = new SQLiteConnection(connString);
        
        public async void InsertDataAsync(Auth auth, string token, ComboBox comboBox)
        {

            sql_con.Open();
            try
            {
                //odbieram wszysckie issues z github i dodaję do Bazy danych
                var data = await auth.GetAllIssues(token, comboBox);
                foreach (var item in data)
                {

                    //comanda dodawania danych do bazt=y
                    SQLiteCommand insertSQL = sql_con.CreateCommand();
                    insertSQL.CommandText = "INSERT INTO Issues1 (Title, Body) VALUES ('" + item.Title + "','" + protectedIssues.ToBase64Encode(item.Body) + "')";
                    insertSQL.ExecuteNonQuery();
                    
                }

                MessageBox.Show("Issues bylo zapisane w bazie danych");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sql_con.Close();
        }

        

        public void ReadData(DataGridView dataGrid)
        {
            sql_con.Open();
            DataTable data = new DataTable();
            string command_string = "SELECT * FROM Issues1";
 
            using (SQLiteCommand cmd = new SQLiteCommand(command_string, sql_con))
            {
                var sqlDataAdapter = new SQLiteDataAdapter(cmd.CommandText, sql_con);
                sqlDataAdapter.Fill(data);
            }
            dataGrid.DataSource = data;
            
            sql_con.Close();
        }
        
        public async void RestoreGit(string token,ComboBox comboBox)
        {

            DataTable data = new DataTable();
            SQLiteCommand command= new SQLiteCommand( "SELECT * FROM Issues1",sql_con);
           sql_con.Open();
            SQLiteDataReader reeader = command.ExecuteReader();
            
            //czytam wszystkie dane z bazy i dodaję bezpośriednio do wybranego repo 
            try
            {

                while (reeader.Read())
                {
                    string originaltxt = protectedIssues.ToBase64Decode(reeader[1].ToString());
                    auth.CreateIssue(token, reeader[0].ToString(), originaltxt, comboBox);
                    MessageBox.Show("Issues było przywracone do GitHub");
                }   

 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            reeader.Close();
            sql_con.Close();
        }


        public void BackupDb(SaveFileDialog ofd1)
        {
            if (ofd1 is null)
            {
                throw new ArgumentNullException(nameof(ofd1));
            }

            ofd1.Filter = "Database Files (*.db)|*.db";
            ofd1.FileName = "database";

            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                var path = Path.GetFullPath(ofd1.FileName);
                var destinationCnx = "Data Source=" + path + "; Version=3;";

                

                 using (var source = new SQLiteConnection(connString))
                using (var destination = new SQLiteConnection(destinationCnx))
                 {
                source.Open();
                destination.Open();
                source.BackupDatabase(destination, "main", "main", -1, null, 0);
                 
                 }



            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        public void RestoreDb(OpenFileDialog ofd2)
        {
          
            ofd2.Filter = "Database Files (*.db)|*.db";
            if (ofd2.ShowDialog() == DialogResult.OK)
            {


                var Backuppath = Path.GetFullPath(ofd2.FileName);
                var restorePath = @"C:\Users\Xopero\Desktop\BazaDanych\BDIssues.db";

                File.Copy(Backuppath, restorePath,true);

            }
        }
    }
}
