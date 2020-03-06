using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOfficeProject
{
    public class ConcreteWord18 : AbstractWordFactory
    {
        private static int instanceCount = 0;

        private ConcreteWord18() { }

        public static ConcreteWord18 GetInstance()
        {
            if (instanceCount != 2)
            {
                instanceCount++;
                return new ConcreteWord18();
            }

            return null;
        }

        public override AbstractButton CreateButton()
        {
            return new ButtonWord18();
        }

        public override AbstractPanel CreatePanel()
        {
            return new PanelWord18();
        }

        public override AbstractTextbox CreateTextbox()
        {
            return new TextboxWord18();
        }
    }
}
