using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubIssues
{
    class ProtectedIssues
    {
        //metoda szyfrowania tekstu
        public  string ToBase64Encode(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return text;
            }

            byte[] textByte = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(textByte);

        }

        //metoda deszyfrwania tekstu
        public  string ToBase64Decode(string encodedText)
        {
            if (String.IsNullOrEmpty(encodedText))
            {
                return encodedText;
            }
            byte[] EncodedBytes = Convert.FromBase64String(encodedText);
            return Encoding.UTF8.GetString(EncodedBytes);
        }



    }   
}
