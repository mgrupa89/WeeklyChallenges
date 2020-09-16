using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
           if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {   
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Count()== 0)
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
          if  (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }

           
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int sum;
                sum = numbers.Sum();
                return (int)sum;
            }
                
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;

            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                             
                if (numbers[i] % 2 == 0)
                {                  
                    sum = sum + numbers[i];                  
                }
                
            }
              return sum;  
        }
        

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            
           
            if (numbers.Sum() % 2 == 0)
            {
                return false;
            }
            return true;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //if (number <= 0)
            //{
            //    return 0;
            //}

            //int counter = 0;
            //for (int i = 1; i < number; i+=2)
            //{
            //    counter++;
            //}

            //return counter;

            return number <= 0 ? 0 : number / 2 ;
        }
    }
}
