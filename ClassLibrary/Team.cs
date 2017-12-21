﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Team : IWorker
    {
        public Worker[] worker { get; set; }
        public Team()
        {
            worker = new Worker[5];
        }

        public bool Work(House house)
        {
            if (house.basement.GetIsRightBuild() == false)
            {
                house.basement.Build();
                return true;
            }
            else if (house.door.GetIsRightBuild() == false)
            {
                house.door.Build();
                return true;
            }
            for (int i = 0; i < house.wall.Length; i++)
            {
                if (house.wall[i].GetIsRightBuild() == false)
                {
                    house.wall[i].Build();
                    return true;
                }
            }
            for (int i = 0; i < house.window.Length; i++)
            {
                if (house.window[i].GetIsRightBuild() == false)
                {
                    house.window[i].Build();
                    return true;
                }
            }
            if (house.roof.GetIsRightBuild() == false)
            {
                house.roof.Build();
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetCountWorker()
        {
            return worker.Length;
        }
    }
}
