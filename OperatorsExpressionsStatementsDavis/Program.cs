using System;

namespace OperatorsExpressionsStatementsDavis
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //like a period in English, use a ";" to denote you want to end a line of code
            //Statements are complete thoughts/sentences in C#, which are made up of 1+ expressions
            //Expressions are made up of operators(+, = variable assignment, == does it equal?, (), '.', etc.)
            //Expressions cont: made up of operands(like objects) as well
            /*
             Expressions: 
              Console.WriteLine("Hello World");
              if(userValue == 1)
              y = x + 7;
              myFirstString = "Bob";            
             */

            //below is easy way to declare variables, not recommended
            int x, y, a, b;

            //Assignment Operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            //There are many mathematical operators...

            //Addition Operators
            x = 3 + 4;

            //Subtraction Operator
            x = 4 - 3;

            //Multiplication Operator
            x = 10 * 5;

            //Division Opperator
            x = 10 / 5;

            //There are many operators used to evaluate values

            //Equality Opperator
            if(x == y){
                
            }

            //Greater than Opperator
            if(x > y){
                
            }

            //Less than opperator
            if(x < y){
                
            }

            //Greater than/equal to opp.
            if(x >= y){
                
            }

            //Less than/equal to opp.
            if(x <= y){
                
            }

            //There are 2 additional opperators as well, and they can be used multiple times

            //Conditional AND Operator
            if((x > y) && (a > b)){
                
            }

			//Conditional OR Operator
			if ((x > y) || (a > b))
			{

			}

            //Conditional in-line opperator
            string message = (x == 1) ? "Car" : "Boat";

            //Member access and Method invocation
            Console.WriteLine("Hi");
        }
    }
}
