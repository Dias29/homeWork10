using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Wall
    {
        public bool IsRightBuild { get; set; }
        public string wall { get; set; }

        public void Build()
        {
            IsRightBuild = true;
        }

        public bool GetIsRightBuild()
        {
            return IsRightBuild;
        }

        public Wall()
        {
            wall =
                   "|_______________________________________|\n" +
                   "|___|___|___|___|___|___|___|___|___|___|\n" +
                   "|_|___|___|___|___|___|___|___|___|___|_|\n" +
                   "|___|___|___|___|___|___|___|___|___|___|\n" +
                   "|_|___|___|___|___|___|___|___|___|___|_|\n" +
                   "|___|___|___|___|___|___|___|___|___|___|\n" +
                   "|_|___|___|___|___|___|___|___|___|___|_|\n" +
                   "|___|___|___|___|___|___|___|___|___|___|\n" +
                   "|_|___|___|___|___|___|___|___|___|___|_|\n";
        }
    }
}
