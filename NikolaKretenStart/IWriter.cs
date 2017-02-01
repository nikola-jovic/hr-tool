using System;

namespace NikolaKretenStart
{
    internal interface IWriter
    {
        void WriteToConsole(string text);
    }

    public class ConsoleWriter : IWriter
    {
        public string text { get; set; }

        public void WriteToConsole(string text)
        {
            Console.WriteLine(text);
        }
    }


    public class DBWriter : IWriter
    {
        public string text { get; set; }

        public void WriteToConsole(string text)
        {
            Console.WriteLine(text);
        }
    }
}