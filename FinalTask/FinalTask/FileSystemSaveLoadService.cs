using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    public class FileSystemSaveLoadService : ISaveLoadService<string>
    {
        //public string data;
        public readonly string way;
        private int _initial_amount_money = 100;

        public FileSystemSaveLoadService(string way)
        {
            if (!File.Exists(way))
            {
                Console.WriteLine("Создание профиля...");
                SaveData(_initial_amount_money.ToString(), way);
            }
            this.way = way;
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
