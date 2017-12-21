using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Roof
    {
        public bool IsRightBuild { get; set; }
        public string roof { get; set; }

        public void Build()
        {
            IsRightBuild = true;
        }

        public bool GetIsRightBuild()
        {
            return IsRightBuild;
        }
        public Roof()
        {
            roof = "         __         \n" +
                   "       __||__       \n" +
                   "     __||||||__     \n" +
                   "   __||||||||||__   \n" +
                   " __||||||||||||||__ \n" +
                   "_||||||||||||||||||_\n" +
                   "||||||||||||||||||||\n";
        }

    }
}
