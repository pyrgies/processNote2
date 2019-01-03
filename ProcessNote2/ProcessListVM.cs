using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessNote2
{
    class ProcessListVM
    {
        private static ProcessesModel processesList = new ProcessesModel();

        public ProcessListVM()
        {
            CreateListOfProcessesVM();
        }
        
        public List<ProcessVM> ProcessVMs { get; set; } = new List<ProcessVM>();

        public void CreateListOfProcessesVM()
        {
            ProcessVMs = processesList.Processes.Select(process => new ProcessVM(process.ProcessName, process.Id)).ToList();
        }

        public void LoadProcessDetails(int id)
        {

        }

    }
}
