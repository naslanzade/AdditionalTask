using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models.Controller
{
    public  class LanguageController 
    {
        

        public static string CheckPower(int languagepower, string languagename)
        {
            if (languagepower>100)
            {
                return languagename + "-gucu yeterlidir";
            }
            else
            {
                return languagename + "-gucu yeterli deyil";
            }
        }

        
        public static double UpDatePopularity(int popularity)
        {
            return Math.Pow(popularity, 2);

        }



        public static void GetUsefullLanguage(Check1<string> checkpower,Check<int> popularity,List<Language> dictionary)
        {
            foreach (var item in dictionary)
            {
                if (item.Power==100)
                {
                  
                }


            }



        }


    }
}
