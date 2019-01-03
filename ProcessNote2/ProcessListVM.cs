using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;


namespace ProcessNote2
{
    class ProcessListVM: ObservableObject
    {
        private static ProcessesModel processesList = new ProcessesModel();
        private ICommand _saveProductCommand;
        private string adamek = "Adam";

        public string Adamek
        {
            get => adamek;
            set
            {
                adamek = value;
                OnPropertyChanged("Adamek");
            }
        }

        private ProcessDetailsVM adamToCiul;

        public ProcessDetailsVM AdamToCiul
        {
            get => adamToCiul;
            set
            {
                adamToCiul = value;
                OnPropertyChanged("AdamToCiul");
            } 
        }

        public ProcessListVM()
        {
            CreateListOfProcessesVM();
        }
        
        public List<ProcessVM> ProcessVMs { get; set; } = new List<ProcessVM>();

        public void CreateListOfProcessesVM()
        {
            ProcessVMs = processesList.Processes.Select(process => new ProcessVM(process.ProcessName, process.Id)).ToList();
        }

        public void LoadProcessDetails()
        {
            AdamToCiul = new ProcessDetailsVM();
        }

        public ICommand SaveProductCommand
        {
            get
            {
                if (_saveProductCommand == null)
                {
                    _saveProductCommand = new RelayCommand(
                        param => Adamek = "Pedał"

                    );
                }
                return _saveProductCommand;
            }
        }


    }
}
