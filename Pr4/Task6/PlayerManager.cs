using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class PlayerManager
    {
        PlayerStorage playerStorage = new PlayerStorage();
        public void Run()
        {
            AddPlayer();
            ShowPLayer();

        }
        private void AddPlayer()
        {
            Player player = new Player();
            player.Inventory ??= new Inventory();
            player.Inventory.Items ??= new List<string>();

            player.Name = "Іван";
            player.Inventory.Items.Add("Пістолет");
            player.Inventory.Items.Add("Аптечка");
            player.Inventory.Items.Add("Сокира");
            
            playerStorage.Save(player);
        }
        private void ShowPLayer()
        {
            Player player = playerStorage.Load();
            player.Inventory ??= new Inventory();
            player.Inventory.Items ??= new List<string>();

            Console.Write($"Ім'я: {player.Name}\nІнвентар: ");
            if(player.Inventory.Items.Count == 0) Console.WriteLine("Пусто");
            else
            {
                foreach (var item in player.Inventory.Items)
                {
                    Console.Write($"{item}, ");
                }
            }

                
        }
    }
}
