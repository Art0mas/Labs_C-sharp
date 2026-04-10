using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class PlayerManager
    {
        PlayerStorage playerStorage = new PlayerStorage();
        public void Run()
        {
            AddPlayer();
            ShowPlayer();
        }
        private void AddPlayer()
        {
            Player player = new Player { Name = "Іван", Level = 6 };
            playerStorage.Save(player);
        }
        private void ShowPlayer()
        {
            Player player = playerStorage.Load();
            Console.WriteLine($"Ім'я: {player.Name}\nРівень: {player.Level}");
        }
    }
}
