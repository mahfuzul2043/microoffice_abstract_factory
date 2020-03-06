using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOfficeProject
{
    public abstract class AbstractWordFactory
    {
        public abstract AbstractButton CreateButton();
        public abstract AbstractPanel CreatePanel();
        public abstract AbstractTextbox CreateTextbox();
    }
}
