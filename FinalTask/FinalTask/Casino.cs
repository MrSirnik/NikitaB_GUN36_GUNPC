using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    internal class Casino : IGame
    {
        private const string way = "C:\\Users\\user\\Desktop\\NikitaB_GUN36_GUNPC\\Saves";

        public void StartGame()
        {
            FileSystemSaveLoadService fileSystemSaveLoadService
                = new FileSystemSaveLoadService(way);

        }

    }
}
