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
        public void SaveData(string data, string identifier)
        {
            File.WriteAllText(identifier, data, Encoding.UTF8);
        }
        public string LoadData(string identifier)
        {
            return File.ReadAllText(identifier, Encoding.UTF8);
        }

    }
}
