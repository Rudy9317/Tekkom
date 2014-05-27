using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tekkom
{
    class Operator
    {
        public String Name { get; set; }
        public String FName { get; set; }
        public int Type { get; set; }

        public Operator(String name, String fName, int type)
        {
            this.Name = name;
            this.FName = fName;
            this.Type = type;
        }
    }
}
