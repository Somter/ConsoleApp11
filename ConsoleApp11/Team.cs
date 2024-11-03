using ConsoleApp11;
using System;

class Team
{
    private List<IWorker> workers = new List<IWorker>();
    Worker worker;
    public Team()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i == 1 || i == 6) {
                workers.Add(new Worker("Анатолий"));
            }
            else if (i == 2 || i == 8) {
                workers.Add(new Worker("Леонид"));
            }
            else if (i == 3 || (i >= 9 && i <= 10)) {
                workers.Add(new Worker("Евгений"));
            }
            else if ((i >= 7 && i <= 8) || (i >= 4 && i <= 5)) {
                workers.Add(new Worker("Игорь"));
            }
        }
        workers.Add(new TeamLeader(11));
    }

    public void BuildHouse(House house)
    {
        int index = 0;

        workers[0].Work(house, index++);
        for (int i = 1; i <= 4; i++){
            workers[i].Work(house, index++);
        }
        EnterButton();

        workers[10].Work(house, index);
        EnterButton();

        for (int i = 5; i <= 8; i++)
        {
            workers[i].Work(house, index++);
        }
        EnterButton();

        workers[10].Work(house, index);
        EnterButton();

        workers[9].Work(house, index++);
        EnterButton();

        workers[10].Work(house, index++);

        DrawHouse();
    }

    private void EnterButton()
    {
        Console.WriteLine("Нажмите Enter...");
        Console.ReadLine();
    }

    private void DrawHouse()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("   ______");
        Console.WriteLine("  /      \\");
        Console.WriteLine(" /        \\");
        Console.WriteLine(" | [] []  |  ");
        Console.WriteLine(" |   []   |  ");
        Console.WriteLine(" |________| ");
        Console.ResetColor();
    }
}