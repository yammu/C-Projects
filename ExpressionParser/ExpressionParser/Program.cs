using System;
using System.Collections.Generic;

namespace ExpressionParser
{
    class MyParser
    {
        int result;
        static void Main(string[] args)
        {
            Console.Write("Reading String to parse..... ");
            String[] expression = System.IO.File.ReadAllLines(@"c:\users\yamuna\documents\visual studio 2013\Projects\ExpressionParser\ExpressionParser\exp_str.txt");
            foreach (String line in expression)
            {
                int parsedValue = parser(line);
                Console.Write("parsed value for " +line+ " is: " + parsedValue +"\n");
            }
            Console.ReadLine();
        }

        public static int parser(String ex)
        {
           String[] str_arr = ex.Split(' ');
           Stack<int> store = new Stack<int>();
           MyParser ep = new MyParser();
            int i = 0, op1, op2, value = 0;
            char oper;
           while (i < str_arr.Length)
           {
               if (Char.IsDigit(str_arr[i][0]))
                 store.Push(Int32.Parse(str_arr[i]));
               else
               {
                  oper = str_arr[i][0];
                  op2 = store.Pop();
                  if (store.Count != 0)
                  {
                      op1 = store.Pop();
                      value = ep.operate(op1, op2, oper);
                      store.Push(value);
                  }
                  else
                  {
                      if (oper == '~')
                          store.Push(~op2);
                  }
               }
               i++;
           }
            return store.Pop();
        }

        public  int  operate(int a, int b, char op){
            
            switch (op)
            {
                case '+':
                     result = a + b;
                     break;

                case '-':
                     result = a - b;
                     break;

                case '*':
                     result = a * b;
                     break;

                case '/':
                     result = a / b;
                     break;

                case '%':
                     result = a % b;
                     break;

                case '^':
                     result = a ^ b;
                     break;

                case '&':
                     result = a & b;
                     break;

                case '|':
                     result = a | b;
                     break;
                default :
                     Console.Write("Invalid"); 
                    break;

            }
            return result;
        }

        
    }
}
