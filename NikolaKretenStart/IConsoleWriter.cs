using System;

namespace NikolaKretenStart
{
    interface IWriter
    {
        void WriteToConsole(string text);
    }

    public class ConsoleWriter : IWriter
    {
        public void WriteToConsole(string text)
        {
            Console.WriteLine(text);
        }
    }
}



