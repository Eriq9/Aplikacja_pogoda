using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Data.Entity;

namespace Aplikacja_pogoda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //load();
        
        }

        /*
        public  async void load()
        {
            
            string call = "http://api.openweathermap.org/data/2.5/weather?id=3081368&appid=ac7c75b9937a495021393024d0a90c44";
            

            HttpClient httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(call);
            

            Weather weather_list = JsonConvert.DeserializeObject<Weather>(json);
            Weather temperatura = JsonConvert.DeserializeObject<Weather>(json);

            Temp_akt.Text = temperatura.main.temp.ToString();
           
        }

        */

      
        public async void button1_Click(object sender, EventArgs e)

        {
            
            string miasto = comboBox1.SelectedItem.ToString();
            string call = "";
            if (miasto == "Londyn")
            {
                call = "http://api.openweathermap.org/data/2.5/weather?id=2643743&appid=ac7c75b9937a495021393024d0a90c44";
            }
            else if (miasto == "Moskwa")
            {
                call = "http://api.openweathermap.org/data/2.5/weather?id=5601538&appid=ac7c75b9937a495021393024d0a90c44"; 
            }
            else if (miasto == "Wrocław")
            {
                call = "http://api.openweathermap.org/data/2.5/weather?id=3081368&appid=ac7c75b9937a495021393024d0a90c44";
            }
            else if (miasto == "Amsterdam")
            {
                call = "http://api.openweathermap.org/data/2.5/weather?id=2759794&appid=ac7c75b9937a495021393024d0a90c44"; 
            }


            
            HttpClient httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(call);
            Weather pogoda = JsonConvert.DeserializeObject<Weather>(json);
            Temp_akt.Text = pogoda.main.temp.ToString() + "\r\n" + "\r\n" + pogoda.main.pressure + "\r\n" + "\r\n" + pogoda.wind.speed;

          


            //////// konwersja na stopnie celsjusza

            double temp_kel = pogoda.main.temp;
            double temp_cel = temp_kel - 273.15;
            Temp_con.Text = temp_cel.ToString();

            

        }


        private async void Historyczna_pogoda_Click(object sender, EventArgs e)
        {

            ///////////////////// kalendarz zwracanie daty

            string data = monthCalendar1.SelectionRange.Start.ToShortDateString();
            Data.Text = data;


            /////////////// konwersja na unix
            



            DateTime data_konwersja = Convert.ToDateTime(data).ToUniversalTime();

            long unixTime = ((DateTimeOffset)data_konwersja).ToUnixTimeSeconds();

            Data_convert.Text = unixTime.ToString();
            string czas_po_konwersji = unixTime.ToString();

            ////////////////////////////////////

            string miasto2 = comboBox1.SelectedItem.ToString();
            string result = "";
            string lat = "";
            string lon = "";
            string skladnik1, skladnik2, skladnik3, skladnik4;



            if (miasto2 == "Londyn")
            {
                lat = "51.50853";
                lon = "-0.12574";
            }
            else if (miasto2 == "Moskwa")
            {
                lat = "60.99";
                lon = "30.9";
            }
            else if (miasto2 == "Wrocław")
            {
                lat = "51.099998";
                lon = "17.033331";
            }
            else if (miasto2 == "Amsterdam")
            {
                lat = "52.374";
                lon = "4.8897";
            }


            skladnik1 = "http://api.openweathermap.org/data/2.5/onecall/timemachine?lat=";
            skladnik2 = "&lon=";
            skladnik3 = "&dt=";
            skladnik4 = "&appid=bb13cebaaaaa1a82316b3eef6bebdfe6";
            result = skladnik1 + lat + skladnik2 + lon + skladnik3 + czas_po_konwersji + skladnik4;

            pomocniczy.Text = result;

            HttpClient httpClient2 = new HttpClient();
            var json2 = await httpClient2.GetStringAsync(result);

            

            Weather pogoda2 = JsonConvert.DeserializeObject<Weather>(json2);

            

            Temp_hist.Text = pogoda2.hourly[0].temp.ToString() + "\r\n" + "\r\n" + pogoda2.hourly[0].pressure + "\r\n" + "\r\n" + pogoda2.hourly[0].wind_speed;

            double temp_kel2 = pogoda2.hourly[0].temp;
            double temp_cel2 = temp_kel2 - 273.15;
            Temp_con2.Text = temp_cel2.ToString();
            
            var context = new Baza();
            var obiekt_baza = new baza_danych();
            obiekt_baza.temperatura = pogoda2.hourly[0].temp;
            context.Weathers.Add(obiekt_baza);
            context.SaveChanges();
            var nowa_dana_wyswietl = context.Weathers.Where(x=>x.ID >0).ToList<baza_danych>();
            baza_text.Text = "";
            foreach (var w in nowa_dana_wyswietl)
                baza_text.Text +=  "." + obiekt_baza.temperatura.ToString();
                    
            
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void baza_text_TextChanged(object sender, EventArgs e)
        {

        }
    }



}
