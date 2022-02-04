using System;
using System.Collections.Generic;
using System.Text;

namespace Project_05_Random_Numbers_Generator
{
    class ConsoleMenuElement
    {
        public string Label { get; set; }
        public Action ActionToRun { get; set; }
        public ConsoleMenuElement(string label, Action actionToRun)
        {
            Label = label;
            ActionToRun = actionToRun;
        }
        public override string ToString()
        {
            return Label;
        }
    }
}
