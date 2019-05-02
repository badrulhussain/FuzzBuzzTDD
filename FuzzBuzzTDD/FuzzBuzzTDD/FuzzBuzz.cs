using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzBuzzTDD
{
    public class FuzzBuzz
    {
        public string FuzzBuzzLogic(int number)
        {
            String answer = "";
            if(number % 3 == 0)
            {
                answer = "fuzz";
            }
            if (number % 5 == 0)
            {
                answer = "buzz";
            }
            if ((number % 3 != 0) && (number % 5 != 0))
            {
                answer = number.ToString();
            }

            return answer;
        }

        static void Main(string[] args)
        {
        }
    }
}
