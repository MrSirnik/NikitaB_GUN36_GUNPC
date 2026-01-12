using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystemSaveLoadService
{
    public class FileSystemSaveLoadService : ISaveLoadService<string>
    {

        public FileSystemSaveLoadService(string way)
        {
            if (!File.Exists(way))
            {
                File.Create(way);
            }

        }

        public void SaveData(string data, string way)//, string identifier)
        {
            File.WriteAllText(way, data, Encoding.UTF8);
        }

        public string LoadData(string way)//, string identifier)
        {
            return File.ReadAllText(way, Encoding.UTF8);
        }

    }
}
