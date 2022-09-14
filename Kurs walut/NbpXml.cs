using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Kurs_walut
{
    [XmlRoot(ElementName ="ExchangeRatesSeries")]

   public class NbpXml
    {
        public string Table;
        public string currency;
        public string Code;

        [XmlArray("Rates")]
        [XmlArrayItem("Rase", typeof(NbpRate))]

        public NbpRate[] Rates { get; set; }

    }

    public class NbpRate
    {
        [XmlElement("No")]
        public string No { get; set; }
        [XmlElement("EffectiveDate")]
        public DateTime EffectiveDate { get; set; }
        [XmlElement("Mid")]
        public double Price { get; set; }

    }

    [XmlRoot(ElementName = "ArrayOfExchangeRatesTable")]
    public class NbpTables
    {
        [XmlElement("ExchangeRatesTable")]
        public NbpTable[] Tables;
    }

    public class NbpTable
    {
        public string Table;
        public string No;
        public string EffectiveDate;

        [XmlArray("Rates")]
        [XmlArrayItem("Rate", typeof(NbpTableRate))]
        public List<NbpTableRates> Rates;
    }

    public class NbpTableRates
    {
    }

    public class NbpTableRate : NbpTableRates
    {
        public string Currency { get; set; }
        public string Code { get; set; }
        public double Mid;
    }
}
