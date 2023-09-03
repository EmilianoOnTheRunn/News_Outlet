using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NewsOutlet
{
    class News
    {
        
        private string _ID;
        private long _Time;
        private string[] _Keywords;
        private string _Content;
        private int _Hits;
        static string path1 = @"C:\Users\Emiliano\Desktop\School\Data_Structures\NewsOutlet\NewsOutlet\NewsOutlet\MOCK_DATA.json";

        public News() {
             _ID = "";
             _Time = 0;
             _Content = "";
             _Hits = 0;
        }
        public News(string ID, long Time, string[] keywordds, string Content, int Hits)
        {
            _ID = ID;
            _Time = Time;
            _Keywords = keywordds;
            _Content = Content;
            _Hits = Hits;
        }


        public string ID { get => _ID; set => _ID = value; }
        public long Time { get => _Time; set => _Time = value; }
        public string[] Keywords { get => _Keywords; set => _Keywords = value; }
        public string Content { get => _Content; set => _Content = value; }
        public int Hits { get => _Hits; set => _Hits = value; }


        public string toString()
        {
            return String.Format("ID:{0}, Time: {1}, Hits: {2}",
                _ID, _Time, _Hits);
        }
        public string toStringNews()
        {
            return String.Format("ID: {0},\n{1}",
                 _ID, _Content);
        }

        public static List<News> FilterRecent(long time) {
           

            string json = File.ReadAllText(path1);

            // Deserialize the JSON data into a list of objects
            List<News> objNews = JsonConvert.DeserializeObject<List<News>>(json);

            List<News> filteredNews = new List<News>();

            

            foreach (News news in objNews)
            {
                long finalTime =  time - news.Time; 

                if (news.Time <= time && finalTime <= 86400) 
                {

                    filteredNews.Add(news); 
                    
                }
                    
            }
            filteredNews.OrderByDescending(n => n.Time).ToList();
            return filteredNews; 
        }


        public static List<News> FilterTrending()
        {

            string json = File.ReadAllText(path1);

            // Deserialize the JSON data into a list of objects
            List<News> objNews = JsonConvert.DeserializeObject<List<News>>(json);

            // Retrieve objects with attribute value of "myvalue"
            List<News> filteredNews = objNews.OrderByDescending(n => n.Hits).ToList();

            // Print out the filtered list of obj

            return filteredNews; 


        }
        public static List<News> Load()
        {
            
            if (!File.Exists(path1))
            {
                return new List<News>();
            }

            string fileContent = File.ReadAllText(path1);

            if (fileContent == "")
            {
                return new List<News>();
            }
            List<News> objNews = JsonConvert.DeserializeObject<List<News>>(fileContent);

            return objNews;
        }


    }


    }

