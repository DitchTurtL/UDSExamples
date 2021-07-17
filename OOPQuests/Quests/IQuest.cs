using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPQuests.Quests
{
    public interface IQuest
    {
        public string Name { get; }

        public void RunSomething(string gameState);

    }
}
