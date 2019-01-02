using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessNote2
{
    class ProcessList
    {
        // creating List with objects of type Process

        private List<Process> processesList = new List<Process>(Process.GetProcesses());

        public List<Process> ProcessesList
        {
            get => processesList;
            set => processesList = value;
        }
    }
}
