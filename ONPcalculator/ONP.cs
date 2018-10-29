using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONPcalculator {
    class ONP {
        public static double Calculate(ArrayList infixNotation) {
            ArrayList ONPNotation = toONPNotation(infixNotation);
            Stack<double> numbers = new Stack<double>();
            double result = 0;
            foreach (object o in ONPNotation) {
                if (!isOperator(o)) numbers.Push(Convert.ToDouble(o));
                else {
                    double a = numbers.Pop();
                    double b = numbers.Pop();
                    result = useOperator(o, a, b);
                    numbers.Push(result);
                }                    
            }
            return result;
        }



        public static ArrayList toONPNotation(ArrayList infixNotation) {
            ArrayList ONPNotation = new ArrayList();
            Stack operators = new Stack();
            foreach (object o in infixNotation) {
                if (isOperator(o)) {
                    if (operators.Count == 0 || getPriority(o) > getPriority(operators.Peek()))
                        operators.Push(o);
                    else {
                        while (operators.Count > 0 && getPriority(operators.Peek()) >= getPriority(o)) {
                            ONPNotation.Add(operators.Pop());
                        }
                        operators.Push(o);
                    }                        
                } else if (o == "(") operators.Push(o);
                else if (o == ")") {
                    while (operators.Peek() != "(") {
                        ONPNotation.Add(operators.Pop());
                    }
                    operators.Pop();
                } else ONPNotation.Add(o);
            }
            while (operators.Count > 0) {
                ONPNotation.Add(operators.Pop());
            }
            return ONPNotation;
        }

        public static bool isOperator(object o) {
            if (o == "+" || o == "-" || o == "*" || o == "/" || o == "^")
                return true;
            return false;
        }

        public static int getPriority(object element) {
            switch (element) {
                case "(": return 0;
                case ")": return 1;
                case "+": return 1;
                case "-": return 1;
                case "*": return 2;
                case "/": return 2;
                case "^": return 3;
                default: throw new Exception("No such operator");
            }
        }

        public static double useOperator(object o, double a, double b) {
            switch (o) {
                case "*":
                    return a * b;
                case "/":
                    return b / a;
                case "+":
                    return a + b;
                case "-":
                    return b - a;
                case "^":
                    return Math.Pow(b, a);
                default:
                    throw new Exception("No such operator");
            }
        } 
    }
}
