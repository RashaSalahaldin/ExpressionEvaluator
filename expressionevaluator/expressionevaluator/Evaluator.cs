using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace expressionevaluator
{
    class Evaluator
    {
  		// Create Stack Object to save the Expression
        private Stack stk = new Stack();
        
       /**
    	* Evaluate
	    * @param: string exp
	    * description: this method goes over the expression char by char
	    * and push characters to stack till it finds a close Parentheses ')'
	    * after that we pop the char from stack till we find the open Parentheses ')' in stack.
	    * We run the operation for elements found in pop result and then push it back to stack 
	    * in case we have more than one operation in an expression
     	*/

        public void Evaluate(string exp)
        {

            try
            {
				
                string Digit = "";
				
				// For loop char in the expression
                foreach (char element in exp)
                {

					
                    if (Char.IsDigit(element))
                    {
                        Digit = Digit + element.ToString();
                    }
                    else
                    {
                        if (element != ')')
                        {
							// This is added to solve numbers with more than one digit
                            if (Digit != "")
                            {
                                stk.Push(Digit);
                                Digit = "";
                            }

                            stk.Push(element.ToString());

                        }
                        else
                        {

                            if (Digit != "")
                            {
                                stk.Push(Digit);
                                Digit = "";
                            }

                            decimal Num2 = decimal.Parse(stk.Pop().ToString());
                            string Op = (string)stk.Pop();
                            decimal Num1 = decimal.Parse(stk.Pop().ToString());
                            string out1 = (string)stk.Pop();

                            switch (Op)
                            {
                                case "+":
                                    stk.Push((Num1 + Num2).ToString());
                                    break;
                                case "-":
                                    stk.Push((Num1 - Num2).ToString());
                                    break;
                                case "*":
                                    stk.Push((Num1 * Num2).ToString());
                                    break;
                                case "/":
                                    stk.Push((Num1 / Num2).ToString());
                                    break;
                                case "%":
                                    stk.Push((Num1 % Num2).ToString());
                                    break;
                            }

                        }

                    }

                }

                string lastValue;
                lastValue = (string)stk.Pop();

                if (lastValue.All(Char.IsDigit))
                    Console.WriteLine(lastValue);
                else
                    Console.WriteLine("Can’t parse the expression");
            }

            catch (Exception e)
            {
                Console.WriteLine("Can’t parse the expression.");
            }

        }

    }
}
