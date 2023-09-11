using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Repository
{
    public class DataRepository : IRepository
    {
        private readonly string _path;

        public DataRepository()
        {  
            //Provjera ima li fajla:

            if (File.Exists(_path))
            {
                File.Create(_path).Close();
            }
        }

        //Dohvaćanje sa API

        public async Task<List<T>> GetDataAPI<T>(string path)
        {
            try
            {
                List<T> dataFromApi = new List<T>();

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(path))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                List<T> deJson = JsonConvert.DeserializeObject<List<T>>(data);
                                dataFromApi = deJson;
                            }
                        }
                    }
                }
                return dataFromApi;
            }
            catch (Exception e)
            {
                throw new Exception("Greška pri dohvaćanju podataka.", e);
            }
        }

        //Dohvaćanje podataka iz datoteke

        public List<T> GetDataFile<T>(string path)
        {
            try
            {
                var jsonData = File.ReadAllText(path);
                var data = JsonConvert.DeserializeObject<List<T>>(jsonData);

                return data;
            }
            catch (Exception e)
            {
                throw new Exception("Greška pri dohvaćanju podataka.", e);
            }
        }

        //Čitanje iz datoteke

        public List<string> ReadFromFile(string filePath)
        {
            var list = new List<string>();

            try
            {
                using (StreamReader reader = File.OpenText(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }

                return list;
            }
            catch (Exception e)
            {
                throw new Exception("Greška pri čitanju iz datoteke.", e);
            }
        }

        //Pisanje u datoteku

        public void WriteToFile(string path, List<string> content)
        {
            try
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    foreach (string line in content)
                    {
                        writer.WriteLine(line);
                    }
                }                
            }
            catch (Exception e)
            {
                throw new Exception("Greška pri pisanju u datoteku.", e);
            }
        }
    }
}
