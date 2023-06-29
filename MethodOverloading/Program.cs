using System.Net.NetworkInformation;
using System.Collections.Generic;
using System;

namespace MethodOverloading
{
    public class Program
    {

        static void Main(string[] args)
        {
            //Create a method named Add, that accepts two integers and returns the sum of those two integers
            int answer1 = Add(5, 5);
            Console.WriteLine(answer1);

            //Now create an overload of the Add method to account for being able to add two decimals together
            // m is needed for decimal type
            Decimal answer2 = Add(3.23m, 543.42m);
            Console.WriteLine(answer2);

            //Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
            //If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
            //You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”

            //String answer3 = Add(10, 10, true);
            //Console.WriteLine(answer3);

            String answer3 = Add(10,10,false);
            Console.WriteLine(answer3);


        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static decimal Add(decimal num3, decimal num4)
        {
            return num3 + num4;
        }
        //with void as a return type is does not expect

        private static string Add(int num1, int num2, bool isMoney)
        {
            int sum = num1 + num2;
            //if (isMoney)
            if (isMoney && sum > 1)
            {
                //Console.WriteLine(" ");
                return $"{sum} dollars";
                //return $”{sum} dollars”;
            }

            else if (isMoney && sum == 1)
            //else if (isMoney == true && sum = 1)
            {
                return $"{sum} dollar";
                //return $"{sum} dollar”;    
            }

            else 
            {
                //return $”{sum}";
                //return sum;
                return sum.ToString();
            }
        }
    }
}

                
           
        



    

