using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IPart
{
    string Name { get; }
    void Build();
    bool IsBuilt { get; }
}
interface IWorker
{
    void Work(House house, int index);  
}