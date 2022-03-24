using System;

namespace HanoiTower
{
    class Program
    {
        private static int moves;
        private static void HanoiTower(int n, char start, char destination, char via)
        {
           
            if (n == 0)
            {
                return;
            }
            HanoiTower(n - 1, start, via, destination);          
            Console.WriteLine($"Move disk {n} from tower {start} to tower {destination} ");
            HanoiTower(n - 1, via, destination, start);
            moves++;
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter amount of disks: ");
            int disks = int.Parse(Console.ReadLine());
            
            HanoiTower(disks, 'A', 'C', 'B');
            Console.WriteLine($"Disk moves: {moves}");
           
            
        }
    }
}
