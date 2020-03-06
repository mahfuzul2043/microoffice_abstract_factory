using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOfficeProject
{
    public class Client
    {
        private AbstractButton abstractButton;
        private AbstractPanel abstractPanel;
        private AbstractTextbox abstractTextbox;

        public Client(AbstractWordFactory wordGeneration)
        {
            abstractButton = wordGeneration.CreateButton();
            abstractPanel = wordGeneration.CreatePanel();
            abstractTextbox = wordGeneration.CreateTextbox();
        }

        public void Run()
        {
            abstractButton.Display();
            abstractPanel.Display();
            abstractTextbox.Display();
        }
    }
}
