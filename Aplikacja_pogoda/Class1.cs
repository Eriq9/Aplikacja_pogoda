using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_pogoda
{
    
    public class Weather
    {
        

        public Coord coord { set; get; }

        public Main main { set; get; }

        public Wind wind { set; get; }


        public List<Hourly> hourly = new List<Hourly>();

    }


    public class baza_danych
    {
       public int ID { set; get; }

       public double temperatura { set; get; } 
    }



    public class Baza : DbContext
    {
        public virtual DbSet<baza_danych> Weathers { get; set; }
    }

    
    public class Coord
    {
        public double lon { set; get; }
        public double lat { set; get; }
    }

    

    public class Main
    {
        public double temp { set; get; }
        public double pressure { set; get; }
    }

    public class Wind
    {
        public double speed { set; get; }
        
    }

    public class Hourly

    {
        public double temp { set; get; }

        public double wind_speed { set; get; }

        public double pressure { set; get; }
    }
}



