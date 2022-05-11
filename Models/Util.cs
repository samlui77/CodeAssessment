using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAssessment.Models
{
    public class Util
    {
        public static Boolean chkCommandLine(string StrCommandLine) {
            // Check Command Line has "PriceBasket" from the beginning
            if (StrCommandLine.IndexOf("PriceBasket") < 0)
            {
                return false;
            }
            else { 
                return true;
            }
            
        }

        public static Boolean chkCommandLineItem(ArrayList ArryItemsDefined, string StrCommandLine)
        {   // Check is that any not in list item in command line  
            StrCommandLine=StrCommandLine.Replace("PriceBasket", "");  // replace first Command word
            
            foreach (var item in ArryItemsDefined)
            {
                StrCommandLine = StrCommandLine.Replace((string)item, "");
            }
            StrCommandLine = StrCommandLine.Replace(" ", "");            // replace blank char
                        
            Boolean NoNotInListItem = (StrCommandLine.Length==0) ? true : false;
            
            return NoNotInListItem;
        }

        public static string pence2Pound(int priceValue)
        {   // convert pence to pound , eg. £ 10.1

            string StrReturn = String.Empty;
            if (priceValue >= 100)
            {   // More than 100 pence should be covert to pound and pence
                int pound, pence;
                pound = priceValue / 100;
                pence = priceValue % 100;

                StrReturn = (pence > 0) ? String.Format("£{0}.{1}", pound, pence) : String.Format("£{0}", pound);
            }
            else
            {
                // under 100 pence
                StrReturn = priceValue.ToString() + "p";
            }
            return StrReturn;
        }


    }



}
