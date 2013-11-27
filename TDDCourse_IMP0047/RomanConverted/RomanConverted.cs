using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanConverted
{
    public class RomanConverted
    {
        public string Answer(int input)
        {

            string output = "";

                if (input == 0)
                    return "Número Desconocido";
                else if (input == 1)
                    return "I";
                else if (input == 5)
                    return "V";
                else if (input == 10)
                    return "X";
                else if (input == 50)
                    return "L";
                else if (input == 100)
                    return "C";
                else if (input == 500)
                    return "D";
                else if (input == 1000)
                    return "M";
                else if (input < 4)
                {
                    for (int i = 0; i < input; i++)
                    {
                        output = output + "I";
                    }
                    
                    return output;
                }
                else if (input == 4)
                    return "IV";
                else if (input < 9 && input > 5)
                {
                    for (int i = 0; i < input-5; i++)
                    {
                        output = output + "I";
                    }

                    return "V"+ output;
                }
                else if (input == 9)
                    return "IX";

                else if (input < 40)
                {
                    for (int i = 0; i < input; i=i+10)
                    {
                        output = output + "X";
                    }

                    return output;
                }
                else if (input == 40)
                    return "IV";
                else if (input < 90 && input > 50)
                {
                    for (int i = 0; i < input - 50; i = i + 10)
                    {
                        output = output + "X";
                    }

                    return "L" + output;
                }
                else if (input == 90)
                    return "XC";

                else if (input < 400)
                {
                    for (int i = 0; i < input; i = i + 100)
                    {
                        output = output + "C";
                    }

                    return output;
                }
                else if (input == 400)
                    return "CD";
                else if (input < 900 && input > 500)
                {
                    for (int i = 0; i < input - 500; i = i + 100)
                    {
                        output = output + "C";
                    }

                    return "D" + output;
                }
                else if (input == 900)
                    return "CM";
                else
                    return "Número Desconocido";

                string unidad;
                string decena;
                string centena;
                string Long;
                Long = input.ToString();
                unidad = Long.Substring(0, 1);
                decena = Long.Substring(1, 2);
                centena = Long.Substring(2, 3);
               
               

        }
    }
}
