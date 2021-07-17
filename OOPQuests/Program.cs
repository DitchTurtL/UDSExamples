using OOPQuests.Quests;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPQuests
{
    class Program
    {
        static void Main(string[] args)
        {
            // We need a list of Quests to work with.
            var allQuests = new List<IQuest>();
            /*
             * Look at the IQuest interface. It's defines WHAT IS a quest, but does nothing.
             * Anything that IS or CAN BE a quest is by this definition.
             */


            // Then we can add some quests to it
            allQuests.Add(new Quest1());
            allQuests.Add(new Quest2());
            /* 
             * Look at the Quest1 class. It derives from BaseQuest. 
             * It IS a baseQuest, but can do stuff of it's own too.
             */

            /* 
             * Look at BaseQuest. This isn't necessary
             * We could just make an interface and classes that implement it and job done.
             * BUT then we would HAVE TO implement functionality from the interface for EVERY CLASS.
             * That's exhausting since a quest is a quest more or less, there just needs some customization between them.
             * SO the base class lets us add some base level functionality and decide what we want to require the child classes to handle.
             */


            // Once we tell the compiler these are all the same TYPE of object, we can use them the same, but let them decide how it's done.


            // List all Quests
            foreach (var q in allQuests)
                Console.WriteLine($"{q.Name} - {q.GetType()}");


            // Find a quest by name
            var searchFor = "My First Quest";
            var currentQuest = allQuests.FirstOrDefault(m => m.Name == searchFor);


            // Run a method on a Quest (abstract methods are exposed
            currentQuest.RunSomething("RunOnCurrentQuest");


            // Run a method on all quests
            foreach (var q in allQuests)
                q.RunSomething("RunOnAllQuests");


            // This works
            if (currentQuest is Quest1)
            {
                Console.WriteLine($"Yep, it's a quest1");
            }


        }
    }
}
