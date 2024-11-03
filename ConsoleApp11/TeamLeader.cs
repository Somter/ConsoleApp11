using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp11
{
    class TeamLeader : IWorker
    {
        public int Id { get; private set; }

        public TeamLeader(int id)
        {
            Id = id;
        }

        public void Work(House house, int index)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("Приехал бригадир...");
            Console.ResetColor();

            int BasementCount = 0;
            int WallsCount = 0;
            int WindowsCount = 0;
            int RoofCount = 0;
            int DoorsCount = 0;

            for (int i = 0; i < house.Parts.Count; i++)
            {
                IPart housePart = house.Parts[i] as IPart;

                if (housePart != null && housePart.IsBuilt)
                {
                    if (housePart.Name == "Фундамент")
                    {
                        BasementCount++;
                    }
                    else if (housePart.Name == "Стена")
                    {
                        WallsCount++;
                    }
                    else if (housePart.Name == "Окно")
                    {
                        WindowsCount++;
                    }
                    else if (housePart.Name == "Дверь")
                    {
                        DoorsCount++;
                    }
                    else if (housePart.Name == "Крыша")
                    {
                        RoofCount++;
                    }
                }
            }

            Write("Бригадир: уже готово: ");

            bool isFirst = true;

            if (BasementCount > 0)
            {
                Write($"{(isFirst ? "" : ", ")}Фундамент ({BasementCount})");
                isFirst = false;
            }

            if (WallsCount > 0)
            {
                Write($"{(isFirst ? "" : ", ")}Стена ({WallsCount})");
                isFirst = false;
            }

            if (WindowsCount > 0)
            {
                Write($"{(isFirst ? "" : ", ")}Окно ({WindowsCount})");
                isFirst = false;
            }

            if (DoorsCount > 0)
            {
                Write($"{(isFirst ? "" : ", ")}Дверь ({DoorsCount})");
                isFirst = false;
            }

            if (RoofCount > 0)
            {
                Write($"{(isFirst ? "" : ", ")}Крыша ({RoofCount})");
            }

            WriteLine(); 
            ReadLine();
        }
    }
}
