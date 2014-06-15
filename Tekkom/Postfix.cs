using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tekkom
{
    class Postfix
    {
        private List<Operator> operators = new Operator().GenerateOperator();
        public String item { get; set; }

        public Postfix(String item)
        {
            this.item = item;
        }

        public Postfix()
        {
            // TODO: Complete member initialization
        }

        private Operator getOperator(Postfix postfixItem)
        {
            String token = postfixItem.item;
            int operatorLen = operators.Count;
            for (int i = 0; i < operatorLen; i++)
            {
                if (token == operators[i].Name)
                    return operators[i];
            }

            return null;
        }

        public List<Postfix> defaultPostfix()
        {
            List<Postfix> postfix = new List<Postfix>();
            postfix.Add(new Postfix("X"));
            postfix.Add(new Postfix("A"));
            postfix.Add(new Postfix("B"));
            postfix.Add(new Postfix("C"));
            postfix.Add(new Postfix("-"));
            postfix.Add(new Postfix("*"));
            postfix.Add(new Postfix("D"));
            postfix.Add(new Postfix("E"));
            postfix.Add(new Postfix("+"));
            postfix.Add(new Postfix("/"));
            postfix.Add(new Postfix("="));
            return postfix;
        }

        public List<List<String>> process(List<Postfix> postfix)
        {
            List<Postfix> stack = new List<Postfix>();
            List<Quadruple> quadruples = new List<Quadruple>();
            List<String> quadText = new List<String>();
            List<String> tacText = new List<string>();

            int countTemp = 0;
            for (int i = 0; i < postfix.Count; i++)
            {
                Operator op;
                try
                {
                    op = this.getOperator(postfix[i]);
                    if (op == null)
                    {
                        // not operator
                        stack.Add(postfix[i]);
                    }
                    else
                    {
                        // is operator
                        Quadruple tmp;
                        int lastIndex = stack.Count - 1;

                        if (op.Type == 2)
                        {
                            // a op b
                            String opr2 = stack[lastIndex].item;
                            String opr1 = stack[lastIndex - 1].item;
                            stack.RemoveAt(lastIndex); stack.RemoveAt(lastIndex - 1);
                            countTemp++;
                            String res = "temp" + countTemp;
                            tmp = new Quadruple(quadruples.Count + 1, op.FName, opr1, opr2, res);
                            stack.Add(new Postfix(res));
                            quadruples.Add(tmp);

                            String tac = (tmp.Result + " := " + tmp.Operand1 + " " + op.Name + " " + tmp.Operand2);

                            tacText.Add(tmp.No + ". " + tac + "\n");
                            quadText.Add(tmp.No + ". " + tmp.Operator + "," + tmp.Operand1 + "," + tmp.Operand2 + "," + tmp.Result + "\n");

                        }
                        else
                        {
                            if (op.Name == "=")
                            {
                                // a = b
                                String opr = stack[lastIndex].item;
                                String res = stack[lastIndex - 1].item;
                                stack.RemoveAt(lastIndex); stack.RemoveAt(lastIndex - 1);
                                tmp = new Quadruple(quadruples.Count + 1, op.FName, opr, "", res);
                                quadruples.Add(tmp);

                                String tac = (tmp.Result + " := " + tmp.Operand1);

                                tacText.Add(tmp.No + ". " + tac + "\n");
                                quadText.Add(tmp.No + ". " + tmp.Operator + "," + tmp.Operand1 + "," + tmp.Operand2 + "," + tmp.Result + "\n");

                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            List<List<String>> output = new List<List<String>>();
            output.Add(tacText);
            output.Add(quadText);
            return output;
        }
    }
}
