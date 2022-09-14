using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_walut
{
    class Calculate
    {
        public static double MainCalculate(double amount, NbpTableRate from, NbpTableRate to, bool round = true)
        {
            double convert;

            if (from.Code.Equals("PLN"))
            {
                convert = calculatePlnTo(amount, from, to);
            }
            else if (to.Code.Equals("PLN"))
            {
                convert = calculateOtherToPln(amount, from, to);
            }
            else
            {
                convert = calculateOtherToPln(amount, from, to);
                convert = calculatePlnTo(convert, from, to);
            }
            if (!round)
            {
                return convert;
            }
            else
            {
                return Math.Floor(convert * 100) / 100;
            }

        }

        public static double calculatePlnTo(double amount, NbpTableRate from, NbpTableRate to)
        {
            return amount / to.Mid;
        }
       public static double calculateOtherToPln(double amount, NbpTableRate from, NbpTableRate to)
        {
            return amount * from.Mid;
        }
        
    }
}
