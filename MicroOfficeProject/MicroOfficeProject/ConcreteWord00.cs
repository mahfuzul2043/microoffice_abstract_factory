using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOfficeProject
{
    public class ConcreteWord00 : AbstractWordFactory
    {
        private static int instanceCount = 0;

        private ConcreteWord00() { }

        public static ConcreteWord00 GetInstance()
        {
            if (instanceCount != 2)
            {
                instanceCount++;
                return new ConcreteWord00();
            }

            return null;
        }

        public override AbstractButton CreateButton()
        {
            return new ButtonWord00();
        }

        public override AbstractPanel CreatePanel()
        {
            return new PanelWord00();
        }

        public override AbstractTextbox CreateTextbox()
        {
            return new TextboxWord00();
        }
    }
}
