namespace FizzBuzz
{
    public class FizzBuzz
    {
        const string kIBFizz        = "fizz";
        const string kIBBuzz        = "buzz";
        const string kIBFizzBuzz    = kIBFizz + kIBBuzz;

        public string Answer(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
                return kIBFizzBuzz; 
            else if (input % 3 == 0)
                return kIBFizz;
            else if (input % 5 == 0)
                return kIBBuzz;
            else
                return input.ToString();
        }
    }
}
