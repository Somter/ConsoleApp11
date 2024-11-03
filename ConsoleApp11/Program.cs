using ConsoleApp11;
using System;

class Task
{
    static void Main()
    {
        try
        {
            House house = new House();
            Team team = new Team();
            team.BuildHouse(house);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);   
        }

    }
}
