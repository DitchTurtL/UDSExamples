using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPQuests.Quests
{
    public class Quest2 : BaseQuest
    {
        // return the quest name
        public override string Name => "Another Quest";

        // We choose to override the Virtual method for Quest2.
        public override void RunSomething(string gameState)
        {

            Console.WriteLine($"{gameState} - RunSomething() on child class");

            
            // We can still run the underlying code from this method with base.
            // This is useful if you want to do something Additional with the class,
            //      instead of Instead of the base functionality
            base.RunSomething(gameState);
        }

        
        private void TestClassScope()
        {
            // This isn't called, but it shows that the public method in BaseQuest can be accessed from children
            // but wont be automatically exposed by the child objects.
            this.DoSomethingRandom();
        }



    }
}
