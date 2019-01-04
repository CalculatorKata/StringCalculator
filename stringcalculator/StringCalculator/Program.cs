using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        
    }

    public class CalculatorKata
    {
        public int Add(string Input)
        {
            int result = -1;

            if (Input.Trim()==string.Empty)
                result = 0;

            if (result!=0)
            {
                int outPut;

                if (int.TryParse(Input, out outPut))
                    result = outPut;
            }

            if (result==-1)
            {
                List<string> stringNumbers;
                stringNumbers = Input.Split(',').ToList<string>();
                int numConverted = 0;
                int outPut = 0;

                foreach (var item in stringNumbers)
                {
                    if (int.TryParse(item, out outPut))
                    {
                        numConverted += outPut;
                    }
                    else
                    {
                        return result;
                    }
                }

                result = numConverted;

            }
                return result;
        }
    }
}
