using System.Collections;

namespace KataFizzBuzz
{
    public class FizzBuzz
    {
        public ArrayList GetList()
        {
            ArrayList list = new ArrayList();
            for (int i = 1; i <= 20; i++)
            {
                if(IsNumberFizzBuzz(i))
                {
                    list.Add("FizzBuzz");
                }
                else if (IsNumberFizz(i))
                {
                    list.Add("Fizz");
                }
                else if (IsNumberBuzz(i))
                {
                    list.Add("Buzz");
                }
                else
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public bool IsNumberFizz(int number)
        {
            return number % 3 == 0;
        }

        public bool IsNumberBuzz(int number)
        {
            return number % 5 == 0;
        }
        
        public bool IsNumberFizzBuzz(int number)
        {
            return IsNumberFizz(number) && IsNumberBuzz(number);
        }
    }
}