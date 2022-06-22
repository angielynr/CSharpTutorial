using System;

namespace Events
{
    internal class Program
    {
        static int score = 0;
        static void Main(string[] args)
        {

            Shooter shooter = new Shooter();
            shooter.ShotsFired += AddScore;
            shooter.ShotsFired += KilledEnemy;

            shooter.Name = "Angie";

            shooter.OnShoot();

        }

        public static void KilledEnemy(object sender, ShotsFiredEventArgs e)
        {
            var shooter = sender as Shooter;
            Console.WriteLine($"{shooter.Name} killed an enemy. Time of Kill: {e.TimeOfKill}");
            Console.WriteLine($"My score now is: {score}");
        }

        public static void AddScore(object sender, EventArgs e)
        {

            ++score;


        }
    }
}
