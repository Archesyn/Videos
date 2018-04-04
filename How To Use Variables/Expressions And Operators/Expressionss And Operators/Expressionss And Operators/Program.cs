using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//An expression is a series of operators and operands
//Operators are symbols that represent a operation which returns a single result
//Operands are data inputs for your operators
namespace Expressionss_And_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal simpleExpression1 = 5 - 10;
            decimal simpleExpression2 = 4 * 10;
            decimal complexExpression = (((6 * 7) - 4) + simpleExpression1) / simpleExpression2;

            Console.WriteLine(simpleExpression1);
            Console.WriteLine(simpleExpression2);
            Console.WriteLine(complexExpression);
        }
    }
}
