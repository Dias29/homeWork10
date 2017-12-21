using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TeamLeader :IWorker
    {
        public bool Work(House house)
        {
            int countСorrectly = 0;
            Console.WriteLine("-----------Отчет---------");
            if (house.basement.GetIsRightBuild() == true)
            {
                Console.WriteLine("Основа построена");
                countСorrectly++;
            }
            else if (house.door.GetIsRightBuild() == true)
            {
                Console.WriteLine("Дверь построена");
                countСorrectly++;
            }
            for (int i = 0; i < house.wall.Length; i++)
            {
                if (house.wall[i].GetIsRightBuild() == true)
                {
                    Console.WriteLine("Стена " + i + " построена");
                    countСorrectly++;
                }
            }
            for (int i = 0; i < house.window.Length; i++)
            {
                if (house.window[i].GetIsRightBuild() == true)
                {
                    Console.WriteLine("Окно " + i + " построено");
                    countСorrectly++;
                }
            }
            if (house.roof.GetIsRightBuild() == false)
            {
                Console.WriteLine("Крыша построена");
                countСorrectly++;
            }
            if (countСorrectly == house.GetNumberObject())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
