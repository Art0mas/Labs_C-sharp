using System.Text;

namespace Pr2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var player = new Player();
            var healthBar = new UIHealthBar();
            var soundSystem = new SoundSystem();
            var achievementSystem = new AchievementSystem();
            var gameLogger = new GameLogger();

            player.HealthChanged += healthBar.ShowHealthBar;
            player.HealthChanged += soundSystem.PlayDamageSound;
            player.HealthChanged += achievementSystem.AchievementMessage;
            player.HealthChanged += gameLogger.Log;

            player.PlayerDied += healthBar.ShowDeath;
            player.PlayerDied += soundSystem.PlayDeathSound;

            player.TakeDamage(35); Console.WriteLine();
            player.TakeDamage(20); Console.WriteLine();
            player.TakeDamage(40); Console.WriteLine();
            player.TakeDamage(10); Console.WriteLine();
        }
    }
}
