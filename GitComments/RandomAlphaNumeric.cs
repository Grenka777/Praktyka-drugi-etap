using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace GitComments
{
    class RandomAlphaNumeric
    {
        private static Random random = new Random();

        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefhijklmnopqrstumvwxyz0123456789";
            return new string(Enumerable.Range(1, length).Select(_ => chars[random.Next(chars.Length)]).ToArray());
        }
    }
}
