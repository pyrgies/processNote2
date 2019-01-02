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

        private ProcessDetailsVM adamToCiul;

        public ProcessDetailsVM AdamToCiul
        {
            get => adamToCiul;
            set => adamToCiul = value;
        }

        public ProcessListVM()
        {
            CreateProcessVMObjects();
        }
        
        public List<ProcessVM> Processes { get; set; } = new List<ProcessVM>();

        public void CreateProcessVMObjects()
        {
            Processes = processesListObject.ProcessesList.Select(process => new ProcessVM(process.ProcessName, process.Id)).ToList();
        }

        public void LoadProcessDetails(int id)
        {
            AdamToCiul = new ProcessDetailsVM(id);
        }

    }
}
