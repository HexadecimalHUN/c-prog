using  System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Application1
{
    public  class Program
    {
        static int Task1()
        {
            Console.WriteLine("Another Task Starting");
            Task.Delay(2000);
            Console.WriteLine("Another Task has finished");
            return 100;
        }
        static int Task2()
        {
            Console.WriteLine("Another Task Starting");
            Task.Delay(2000);
            Console.WriteLine("Another Task has finished");
            return 200;
        }

        static int Count()
        {
            string text = System.IO.File.ReadAllText("/home/hexa/sampleText.txt");

            int Counter = 0;
            int Index = 0;

            while (Index < text.Length && char.IsWhiteSpace(text[Index]))
                Index++;

            while (Index < text.Length)
            {
                while (Index < text.Length && !char.IsWhiteSpace(text[Index]))
                    Index++;
                Counter++;
                while (Index < text.Length && char.IsWhiteSpace(text[Index]))
                    Index++;
            }
            Console.WriteLine(Counter);
            Console.Read();
            return 300;
        }
        static async Task Main(string[] args)
        {
            await Task.Run(() =>
            {
                Task1();
                
            });
            await Task.Run(() =>
            {
                Task2();
            });
            await Task.Run(() =>
            {
                Count();
            });

        }
    }
}
