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

        public Operator()
        {
            // TODO: Complete member initialization
        }

        public List<Operator> GenerateOperator()
        {
            List<Operator> operators = new List<Operator>();
            operators.Add(new Operator("+", "ADD", 2));
            operators.Add(new Operator("-", "SUB", 2));
            operators.Add(new Operator("*", "MUL", 2));
            operators.Add(new Operator("/", "DIV", 2));
            operators.Add(new Operator("%", "MOD", 2));
            operators.Add(new Operator("<", "LT", 2));
            operators.Add(new Operator(">", "GT", 2));
            operators.Add(new Operator("=", "MOV", 1));
            return operators;
        }
    }
}
