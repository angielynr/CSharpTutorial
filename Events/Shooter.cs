using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class Shooter
    {
        private Random rnd = new Random();

        //public delegate void Shots(object source, ShotsFiredEventArgs args);
        //public event Shots ShotsFired;

        public event EventHandler<ShotsFiredEventArgs> ShotsFired;

        public string Name { get; set; } = "John";

        public void OnShoot()
        {
            while (true)
            {
                if (rnd.Next(0, 100) % 2 == 0)
                {
                    ShotsFired?.Invoke(this, new ShotsFiredEventArgs(DateTime.UtcNow));
                }
                else
                {
                    Console.WriteLine("I missed");
                }

                Thread.Sleep(500);
            }
        }
    }
}
