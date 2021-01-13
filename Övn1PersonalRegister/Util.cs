using System;

namespace Övn1PersonalRegister
{
    internal static class Util
    {
        // prompt because this is user input
        internal static string AskForString(string prompt)
        {
            // Flag to stop loop
            bool success = false;
            string answer;

            do
            {
                Console.WriteLine(prompt);
                answer = Console.ReadLine();


                if (!string.IsNullOrEmpty(answer))
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }

        internal static int AskForInt(string prompt)
        {
            bool success = false;
            int answer;
            do
            {
                // Use the AskForString() method instead of doing the same thing!
                // now we will know that we get a string back to the input string here! 
                string input = AskForString(prompt);

                // If input is parsed to an int we send out the answer and save it in the variable success
                success = int.TryParse(input, out answer);
                if (!success)
                {
                    Console.WriteLine("Wrong format");
                }

            } while (!success);

            return answer;
        }
    }
}