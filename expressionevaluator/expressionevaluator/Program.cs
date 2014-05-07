using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace expressionevaluator
{
    class Program
    {

        static void Main(string[] args)
        {
        	// Output Message For User to Enter Expression
            Console.WriteLine("Please Enter Expression:");
            
            string str;
            // Read Input From User
            str = Console.ReadLine();
            
            // While Input From User Not Equal Quit Run Expression, Otherwise quit the Console Application
            while (str != "quit")
            {
	            // Create Object Evaluator
                Evaluator ev = new Evaluator();
                
                // Pass Express to object to be evaluated and to show result output 
                // Each mathematical operation in the expression should be between a Parentheses
                // Example (((1+6) – 2) / 2 )
                ev.Evaluate(str);
                
                // ReEnter a new Expression
                Console.WriteLine("Please Enter Expression Ex. (a+b) :");
                
                str = Console.ReadLine();
            }
        }

    }

}