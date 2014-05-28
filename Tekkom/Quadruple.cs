using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tekkom
{
    class Quadruple
    {
        public int No { get; set; }
        public String Operator { get; set; }
        public String Operand1 { get; set; }
        public String Operand2 { get; set; }
        public String Result { get; set; }

        public Quadruple(int no, String op, String opr1, String opr2, String res)
        {
            this.No = no;
            this.Operator = op;
            this.Operand1 = opr1;
            this.Operand2 = opr2;
            this.Result = res;
        }
    }
}
