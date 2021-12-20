using System;
using System.Linq;

namespace StringKata
{

    public class StringCalculator
    {
        public StringCalculator()
        {
        }

        public int Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            else
            {
                char[] separators = new char[] { };
                string[] numbersArray = new string[] { };
                int sum = 0;
                if (numbers.StartsWith("//"))
                {
                    separators = new char[] { ';', '\n' };
                    numbersArray = numbers.Split(separators).Skip(2).ToArray();
                }
                else 
                {
                    separators = new char[] { ',', '\n' };

                    numbersArray = numbers.Split(separators);
                }

                numbersArray = numbersArray.Where(n => int.Parse(n) <= 1000).ToArray();
               
                foreach (string num in numbersArray)
                {
                  
                    sum += Int32.Parse(num);
                }

                var negatives = numbersArray.Where(n => int.Parse(n) < 0);
                if (negatives.Any())
                {
                    string negativesList = String.Join(',', negatives);
                    throw new Exception("Negatives not allowed: ${negativesList}");
                }
                return sum;
            }

        }
    }
}

