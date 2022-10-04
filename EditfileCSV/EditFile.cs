using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;

namespace EditfileCSV
{
   
    class EditFile
    {
        

        public void ReadCSV(string path,DataGridView dataGridView)
        {
            string[] str = File.ReadAllLines(path);
            DataTable dt = new DataTable();
            string[] temp = str[0].Split(SeparatorDetector(path));
            dt.Columns.Clear();
            foreach (var item in temp)
            {
                dt.Columns.Add(item, typeof(string));
            }

            for (int i = 0; i < str.Length; i++)
            {
                string[] t = str[i].Split(SeparatorDetector(path));
                dt.Rows.Add(t);
            }
            dataGridView.DataSource = dt;

            
            
        }

        public void EditCSV(DataGridView dataGridView, string path,string NewSeparator)
        {
            string csv = string.Empty;

          

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach  (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        
                        csv += cell.Value.ToString()+NewSeparator;
                         
                    }

                }
               
                csv = csv.Remove(csv.Length - 1);
                csv += "\r\n";
            }
            csv = csv.Remove(csv.Length - 2);
            
           
            File.WriteAllText(path,csv);
            
        }

         private static readonly char[] SeparatorChars = { ';', '|', '\t', ',' };
        public char SeparatorDetector(string path)
        {
            string[] lines = File.ReadAllLines(path);

            var q = SeparatorChars.Select(sep => new
            { Separator = sep, Found = lines.GroupBy(line => line.Count(ch => ch == sep)) })
            .OrderByDescending(res => res.Found.Count(grp => grp.Key > 0))
            .ThenBy(res => res.Found.Count())
            .First();

            return q.Separator;
            
        }

      
    }
}
