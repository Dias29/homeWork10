using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Door : IPart
    {
        public bool IsRightBuild { get; set; }
        public string door { get; set; }

        public void Build()
        {
            IsRightBuild = true;
        }

        public bool GetIsRightBuild()
        {
            return IsRightBuild;
        }

        public Door()
        {
            door = "_______\n" +
                   "|_____|\n" +
                   "|_____|\n" +
                   "|___*_|\n" +
                   "|_____|\n";
        }
    }
}
