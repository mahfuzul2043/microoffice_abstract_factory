using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOfficeProject
{
    public class ConcreteWord90 : AbstractWordFactory
    {
        private static int instanceCount = 0;

        private ConcreteWord90() { }

        public static ConcreteWord90 GetInstance()
        {
            if (instanceCount != 2)
            {
                instanceCount++;
                return new ConcreteWord90();
            }

            return null;
        }

        public override AbstractButton CreateButton()
        {
            return new ButtonWord90();
        }

        public override AbstractPanel CreatePanel()
        {
            return new PanelWord90();
        }

        public override AbstractTextbox CreateTextbox()
        {
            return new TextboxWord90();
        }
    }
}
