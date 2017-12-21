using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Basement : IPart
    {
        public string basement { get; set; }
        public bool IsRightBuild { get; set; }

        public bool GetIsRightBuild()
        {
            return IsRightBuild;
        }

        public void Build()
        {
            IsRightBuild = true;
        }

        public Basement()
        {
            basement = "######################";
        }

        
    }
}
