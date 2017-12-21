using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Window
    {
        public bool IsRightBuild { get; set; }
        public string window { get; set; }

        public void Build()
        {
            IsRightBuild = true;
        }

        public bool GetIsRightBuild()
        {
            return IsRightBuild;
        }

        public Window()
        {
            window = "_________________\n" +
                     "|       ||      |\n" +
                     "|       ||      |\n" +
                     "|_______||______|\n" +
                     "|       ||      |\n" +
                     "|       ||      |\n" +
                     "|_______||______|\n";
        }
    }
}
