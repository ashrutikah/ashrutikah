using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Solution
{
    
    /*
     * Complete the function below.
     */
    static void openAndClosePrices(string firstDate, string lastDate, string weekDay)
    {
        List<StockDetails> lstResults = new List<StockDetails>();
        string URL = "https://jsonmock.hackerrank.com/api/stocks/";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
        request.ContentType = "application/json; charset=utf-8";
        request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes("username:password"));
        request.PreAuthenticate = true;
        HttpWebResponse response = request.GetResponse() as HttpWebResponse;

        var content = string.Empty;
        List<StockDetails> lstStockDetails = new List<StockDetails>();
        using (Stream responseStream = response.GetResponseStream())
        {
            StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.UTF8);
            content = reader.ReadToEnd();
            
        }
        var stockData = JsonConvert.DeserializeObject<Stocks>(content);
        int noOfPages = stockData.total_pages;
       

        foreach(StockDetails sd in stockData.data)
        {
           if(Convert.ToDateTime(sd.date) >= Convert.ToDateTime(firstDate) && Convert.ToDateTime(sd.date) <= Convert.ToDateTime(lastDate) && Convert.ToDateTime(sd.date).DayOfWeek.ToString() == weekDay)
            {
                lstResults.Add(sd);
                Console.WriteLine(sd.date + " " + sd.open + " " + sd.close);
            }
        }

        if(noOfPages> 1)
        {
            for(int j = 2;j<=noOfPages;j++)
            {
                URL = "https://jsonmock.hackerrank.com/api/stocks/?page="+j;
                request = (HttpWebRequest)WebRequest.Create(URL);
                request.ContentType = "application/json; charset=utf-8";
                request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes("username:password"));
                request.PreAuthenticate = true;
                response = request.GetResponse() as HttpWebResponse;

                content = string.Empty;
               
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.UTF8);
                    content = reader.ReadToEnd();

                }
                stockData = JsonConvert.DeserializeObject<Stocks>(content);

                foreach (StockDetails sd in stockData.data)
                {
                    if (Convert.ToDateTime(sd.date) >= Convert.ToDateTime(firstDate) && Convert.ToDateTime(sd.date) <= Convert.ToDateTime(lastDate) && Convert.ToDateTime(sd.date).DayOfWeek.ToString() == weekDay)
                    {
                        lstResults.Add(sd);
                        Console.WriteLine(sd.date + " " + sd.open + " " + sd.close);
                    }
                }

            }
        }
        Console.ReadLine();
    }

   public class StockDetails
    {
        public string date { get; set; }
        public float open { get; set; }

        public float high { get; set; }
        public float low { get; set; }

        public float close { get; set; }

    }

    class Stocks
    {

       public int page { get; set; }

        public int per_page { get; set; }

        public int total { get; set; }
        public int total_pages { get; set; }

        public List<StockDetails> data { get; set; }

    }

    static void Main(String[] args)
    {
        string _firstDate;
        _firstDate = Console.ReadLine();

        string _lastDate;
        _lastDate = Console.ReadLine();

        string _weekDay;
        _weekDay = Console.ReadLine();

        openAndClosePrices(_firstDate, _lastDate, _weekDay);

    }
}