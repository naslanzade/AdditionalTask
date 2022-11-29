using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models
{

    public delegate T Check<T>(T data);

    public delegate T Check1<T>(T data, T data);

    public class Language
    {
        public string ? Name { get; set; }
        public DateTime CreatingDate { get; set; }
        public int Power { get; set; }
        public int Popularity { get; set; }


        public Language(string name, DateTime creatingdate, int power,int popularity) 
        {
            Name= name;
            CreatingDate= creatingdate; 
            Power= power;   
            Popularity= popularity; 
        }



       
        
        

    }
}
