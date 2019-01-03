using System.Collections.Generic;
using System.Diagnostics;

namespace ProcessNote2
{
    class ProcessesModel
    {
        // creating List with objects of type Process

        private List<Process> processes = new List<Process>(Process.GetProcesses());

        public List<Process> Processes
        {
            get => processes;

        }
    }
}
