using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeBreaker
{
    public class CodeBreaker
    {
        public string Answer(int input)
        {
            char[]  value   = {'5', '7', '1', '3'};
            char[]  digits  = input.ToString().ToCharArray();
            string result = "";

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (value[i] == digits[j])
                        if (i == j)
                            result = "*" + result;
                        else
                            result += "-";

            return result;
        }
    }
}
