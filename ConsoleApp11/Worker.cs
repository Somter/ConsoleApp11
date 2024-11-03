using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Worker : IWorker
    {

        public string Name { get; private set; }

        public Worker(string name)
        {
            Name = name;
        }
        public void Work(House house, int index)
        {
            ValidatePartIndex(house, index);
            IPart part = house.Parts[index] as IPart; 

            BuildPart(part);
            DisplayCompletionMessage(part);
        }

        private void ValidatePartIndex(House house, int partIndex)
        {
            if (partIndex >= house.Parts.Count)
            {
                throw new IndexOutOfRangeException("Нет такой части дома");
            }
        }

        private void BuildPart(IPart part)
        {
            if (part != null)
            {
                part.Build();
            }
        }

        private void DisplayCompletionMessage(IPart part)
        {
            Console.WriteLine($"Рабочий {Name}: часть ({part?.Name}) строится!");
        }
    }

}

