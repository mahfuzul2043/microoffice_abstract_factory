using System;
using System.IO;

namespace MicroOfficeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("WordGeneration.txt");
            string line;

            while ((line = file.ReadLine()) != null)
            {
                switch (line)
                {
                    case "Word90":
                        ProcessFactory(ConcreteWord90.GetInstance(), "word90");
                        break;
                    case "Word00":
                        ProcessFactory(ConcreteWord00.GetInstance(), "word00");
                        break;
                    case "Word10":
                        ProcessFactory(ConcreteWord10.GetInstance(), "word10");
                        break;
                    case "Word18":
                        ProcessFactory(ConcreteWord18.GetInstance(), "word18");
                        break;
                    default:
                        break;
                }
            }

            Console.ReadKey();
        }

        static void ProcessFactory(AbstractWordFactory wordFactory, string generation)
        {
            var word = wordFactory;
            Client client = null;
            if (word != null)
            {
                client = new Client(word);
                client.Run();
            }
            else Console.WriteLine($"This generation ({generation}) has already ran twice.");
        }
    }
}
