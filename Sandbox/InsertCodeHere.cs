using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            CubeCalculator cc = new CubeCalculator();

            
            String userInput = cc.GetUserInput("Please enter an integer number between 1 and 10:");

            while(Int32.Parse(userInput) <= 10 && Int32.Parse(userInput) >= 1)
            {
                if (cc.IsANumber(userInput))
                {
                    int value = cc.ConvertToNumber(userInput);
                    int result = cc.CalculateCube(value);
                    Console.WriteLine("The cube of {0} is {1}", value, result);
                    userInput = cc.GetUserInput("Please enter an integer number between 1 and 10:");

                }
                else
                {
                    Console.WriteLine("Could not calculate...");
                }
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}
