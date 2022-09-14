using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Windows.Forms;

namespace Kurs_walut
{
   public class HttpRequest
    {

        public static Stream httpRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/xml");
                try
                {
                    Task<Stream> request = client.GetStreamAsync(url);
                    request.Wait();

                    return request.Result;
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie masz dostępu do internetu ", "Error!");
                    System.Environment.Exit(0);
                    return new MemoryStream();
                }
            }
        }




    }
}
