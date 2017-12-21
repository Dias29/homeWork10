using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class House : IPart
    {
        public const int numberOfWalls = 4;
        public const int numberOfObj = 11;
        public bool IsRightBuild { get; set; }
        public string house { get; set; }
        public Basement basement { get; set; }
        public Door door { get; set; }
        public Roof roof { get; set; }
        public Wall[] wall { get; set; }
        public Window[] window { get; set; }

        public House()
        {
            wall = new Wall[numberOfWalls];
            window = new Window[numberOfWalls];
        }

        public void Build()
        {
            IsRightBuild = true;
        }

        public bool GetIsRightBuild()
        {
            return IsRightBuild;
        }

        public int GetNumberWall()
        {
            return numberOfWalls;
        }

        public int GetNumberObject()
        {
            return numberOfObj;
        }
    }
}
