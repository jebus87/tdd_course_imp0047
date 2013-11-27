using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeBreaker
{
    public class CodeBreaker
    {
        enum Hits {
            ExistsAndPosition,
            Exists,
            DoNotExists
        }

        public string Answer(int input)
        {
            Hits[] hits = { Hits.DoNotExists, Hits.DoNotExists, Hits.DoNotExists, Hits.DoNotExists };
            char[]  value   = {'5', '7', '1', '3'};
            char[]  digits  = input.ToString().ToCharArray();
            string result = "";

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if (value[i] == digits[j])
                    {
                        if (i == j)
                            hits[i] = Hits.ExistsAndPosition;
                        else
                            hits[i] = Hits.Exists;
                    }
                }
            }

            for (int i = 0; i < 4; i++)
                if (hits[i] == Hits.ExistsAndPosition)
                    result += "*";

            for (int i = 0; i < 4; i++)
                if( hits[i] == Hits.Exists)
                    result += "-";

            return result;
        }
    }
}
