using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPQuests.Quests
{
    // We're marking the class as abstract, you MUST provide an implementation of it as Quest1, Quest2, etc.
    public abstract class BaseQuest : IQuest
    {
        // Abstract means this method or property MUST be overidden.
        public abstract string Name { get; } 
        

        // Virtual means this method CAN be overidden 
        public virtual void RunSomething(string gameState)
        {
            Console.WriteLine($"{gameState} - RunSomething() on base class");
        }

        // You can access this method from within the child object, but not from outside.
        public void DoSomethingRandom()
        {
            Console.WriteLine($"DoSomethingRandom()");
        }
    }
}
