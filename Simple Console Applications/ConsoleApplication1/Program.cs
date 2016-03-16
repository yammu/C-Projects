using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleExamples
{
    class FizzBuzz
    {
    static void Main(string[] args)
        {
            Console.WriteLine(IndexOfLongestRun("abbcccddddcccbbbbbbbbbac"));
            List<int> list1 = new List<int> { 1, 3, 5, 7, 9 };
            Tuple<int, int> indices = ConsoleApplication1.FizzBuzz.FindTwoSum(list1, 12);
            Console.WriteLine(indices.Item1 + " " + indices.Item2);

           /* Checking Anagrams */
            String a ="momd0d";
            String b ="dadmom";
           if( sortedStr(a) == sortedStr(b))
               Console.WriteLine("Yes Anagrams");
           else
               Console.WriteLine("Not Anagrams");

             /* End of Anagrams */

            Console.Write(" FizzBuzz Program.....\n");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if(i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5== 0)
                    Console.WriteLine("Buzz");

                else
                    Console.WriteLine(i);
            }
            Console.ReadLine();    
        }
   
    private static string  sortedStr(String a)
    {
           var ch = a.ToCharArray();
            Array.Sort(ch);
            return new String(ch);
}


    public static int IndexOfLongestRun(string str)
    {
        int index = 0, maxcount = 0, count = 0;
        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == str[i + 1])
            {
               // index = 0;
                count++;
            }

            else
            {
                if (maxcount < count)
                {
                    maxcount = count;
                    index = i - count;
                }
                count = 0;
            }
            
        }
        return index;
    }

    private static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        Tuple<int, int> tuple1 = null;
       for(int i = 0; i < list.Count; i++){
           for(int j = 0; j < list.Count; j++)
               if (i == j)
                   continue;
               else{
                   if (list.ElementAt(i) + list.ElementAt(j) == sum)
                   {
                        tuple1 = new Tuple<int, int>(i, j);
                       break;
                   }
               }
           }

       return tuple1;
       }
          
    }

}

