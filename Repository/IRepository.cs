using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository
    {
        Task<List<T>> GetDataAPI<T>(string path);

        List<T> GetDataFile<T>(string path);


        void WriteToFile(string path, List<string> content);

        List<string> ReadFromFile(string path);
    }
}
