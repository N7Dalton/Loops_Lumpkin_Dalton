using System;

namespace Loops_Lumpkin_Dalton
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for joke
            Console.WriteLine("Give me a funny Joke!");

            //calls the method
            CalculateWords(Console.ReadLine());

            string outInputThingy = "0";
            //asks for nunber
            Console.WriteLine("Now ima add up the digits of any number you give me!");
            Console.WriteLine($"{AddNum(Console.ReadLine())} is the added number of {outInputThingy}!");



            void CalculateWords(string input)
            {
                //this will count the words inside of input
                int numOfWords = 1;

                //for loop thing
                for (string calulationString = input; calulationString.IndexOf(" ") != -1; numOfWords++)
                {
                    //gives the calculation a variable
                    calulationString = calulationString.Substring(calulationString.IndexOf(" ") + 1);

                }
                //prints out to the user how many words are in the string
                Console.WriteLine($"{input} has {numOfWords} words inside of it");
            }

            int AddNum(string input)
            {

               //sets addednum to 0
                int addedNum = 0;

                //a stupid freaking for each loop 
                //i hate these things
                foreach (char num in input)
                {
                    
                    addedNum += (int)char.GetNumericValue(num);
                }

                //sets outputthingy to input
                outInputThingy = input;
                //returns addedNum
                return addedNum;
            }


        }
    }
}
