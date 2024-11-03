using System;
using System.Collections;
class House
{
    public ArrayList Parts { get; private set; }
    public House()
    {
        Parts = new ArrayList
        {
            new Basement()
        };
        for (int i = 0; i < 4; i++)
        {
            Parts.Add(new Wall());
        }
        for (int i = 0; i < 4; i++)
        {
            Parts.Add(new Window());
        }
        Parts.Add(new Door());
        Parts.Add(new Roof());
    }

    public bool IsComplete
    {
        get
        {
            foreach (var part in Parts)
            {
                if (part is IPart housePart && !housePart.IsBuilt)
                {
                    return false;
                }
            }
            return true;
        }
    }

    public class Basement : IPart
    {
        public string Name { get; } = "Фундамент";
        public bool IsBuilt { get; private set; } = false;

        public void Build()
        {
            IsBuilt = true;
        }
    }

    public class Wall : IPart
    {
        public string Name { get; } = "Стена";
        public bool IsBuilt { get; private set; } = false;

        public void Build()
        {
            IsBuilt = true;
        }
    }

    public class Window : IPart
    {
        public string Name { get; } = "Окно";
        public bool IsBuilt { get; private set; } = false;

        public void Build()
        {
            IsBuilt = true;
        }
    }
    public class Door : IPart
    {
        public string Name { get; } = "Дверь";
        public bool IsBuilt { get; private set; } = false;

        public void Build()
        {
            IsBuilt = true;
        }
    }

    public class Roof : IPart
    {
        public string Name { get; } = "Крыша";
        public bool IsBuilt { get; private set; } = false;

        public void Build()
        {
            IsBuilt = true;
        }
    }
}