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

        public ProcessListVM()
        {
            CreateProcessVMObjects();
        }
        
        public List<ProcessVM> Processes { get; set; } = new List<ProcessVM>();

        public void CreateProcessVMObjects()
        {
            Processes = processesListObject.ProcessesList.Select(process => new ProcessVM(process.ProcessName, process.Id)).ToList();
        }

    }
}
