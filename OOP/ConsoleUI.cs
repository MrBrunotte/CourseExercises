using System;

namespace OOP
{
    internal class ConsoleUI : IUI
    {
        public ConsoleUI()
        {
        }
        public string GetInput()
        {
            return Console.ReadLine();
        }
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}