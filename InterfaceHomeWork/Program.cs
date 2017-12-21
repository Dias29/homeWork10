using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace InterfaceHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Team team = new Team();
            TeamLeader teamLeader = new TeamLeader();
            
            if (teamLeader.Work(house) == true)
            {
                Console.WriteLine("Строительство завершено");
            }
            else
            {
                Console.WriteLine("Строительство не завершено");
            }
        }
    }
}
