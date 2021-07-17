using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPQuests.Quests
{
    public class Quest1 : BaseQuest
    {
        // Return the quest name
        public override string Name => "My First Quest";

        // Since RunSomething() is virtual, we're going to ignore it here. When we call 
        //      quest1.RunSomething(), it'll actually run from the base class
        // public override void RunSomething(string gameState) {}
    }
}
