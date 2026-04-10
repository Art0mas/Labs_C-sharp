using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class PlayerManager
    {
        PlayerStorage playerStorage = new PlayerStorage();

        public void Run()
        {
            //AddPlayer();
            ShowPlayer();
        }
        private void AddPlayer()
        {
            Player player = new Player { Name = "Іван", Level = 10, Type = "Воїн" };
            playerStorage.Save(player);
        }
        private void ShowPlayer()
        {
            Player player = playerStorage.Load();
            if (player == null)
            {
                Console.WriteLine("Помилка! Не вдалося завантажити гравця.");
                return; 
            }
            Console.WriteLine($"Ім'я: {player.Name}\nРівень: {player.Level}\nКлас: {player.Type}");
        }
    }
}
