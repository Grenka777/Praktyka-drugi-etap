using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Xml.Serialization;

namespace Kurs_walut
{
    class NbpConnect
    {
        string url = "http://api.nbp.pl/api/exchangerates/rates/";
        string urlTables = "http://api.nbp.pl/api/exchangerates/tables/";
        string table = "a";
        NbpTables nbpTables;

        public List<NbpTableRates> getRates()
        {
            downloadTable();
            return this.nbpTables.Tables[0].Rates;
        }

        private NbpTables downloadTable()
        {
            string url = this.buildUrl();

            Stream response = HttpRequest.httpRequest(url);

            XmlSerializer xml = new XmlSerializer(typeof(NbpTables));

                this.nbpTables = (NbpTables)xml.Deserialize(response);
            return this.nbpTables;
        }

       private string buildUrl(string type = "table")
        {
            if (type.Equals("table"))
            {
                return this.urlTables + this.table;
            }
            else
            {
                return this.url + this.table;
            }
        }
    }
}
