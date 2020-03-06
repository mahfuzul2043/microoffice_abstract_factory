using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOfficeProject
{
    public class ConcreteWord10 : AbstractWordFactory
    {
        private static int instanceCount = 0;

        private ConcreteWord10() { }

        public static ConcreteWord10 GetInstance()
        {
            if (instanceCount != 2)
            {
                instanceCount++;
                return new ConcreteWord10();
            }

            return null;
        }

        public override AbstractButton CreateButton()
        {
            return new ButtonWord10();
        }

        public override AbstractPanel CreatePanel()
        {
            return new PanelWord10();
        }

        public override AbstractTextbox CreateTextbox()
        {
            return new TextboxWord10();
        }
    }
}
