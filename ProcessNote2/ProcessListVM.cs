using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessNote2
{
    class ProcessListVM
    {
        private static ProcessList processesListObject = new ProcessList();

        public List<string> Names { get; set; } = new List<string>();

        public void LoadNames()
        {
            foreach (var process in processesListObject.ProcessesList)
            {
                Names.Add(process.ProcessName);
            }
        }
    }
}
