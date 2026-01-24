using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinalTask
{
    public class FileSystemSaveLoadService : ISaveLoadService<string>
    {
        //public string data;
        //public string way;
        public FileSystemSaveLoadService(string way)
        {
            if (!File.Exists(way))
            {
                File.Create(way);
            }

        }

        public void SaveData(string data, string way)
        {
            File.WriteAllText(way, data, Encoding.UTF8);
        }

        public string LoadData(string way)
        {
            return File.ReadAllText(way, Encoding.UTF8);
        }

    }
}
