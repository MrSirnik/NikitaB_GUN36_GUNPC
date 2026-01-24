using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    internal class Casino : IGame
    {
        private static FileInfo _fileInfo = new FileInfo("Save");
        private string way = _fileInfo.DirectoryName;


        public void StartGame()
        {
            Console.WriteLine(way);
            way = Directory.GetParent(way).ToString();
            way = Directory.GetParent(way).ToString();
            way = Directory.GetParent(way).ToString();
            Console.WriteLine(way);
            way = _fileInfo.DirectoryName;

            FileSystemSaveLoadService fileSystemSaveLoadService
                = new FileSystemSaveLoadService(way);

        }

        
    }
}
