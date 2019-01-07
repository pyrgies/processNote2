using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;


namespace ProcessNote2
{
    class ProcessListVM: ObservableObject
    {
        private static ProcessesModel processesList = new ProcessesModel();
        private ICommand _saveProductCommand;
        private string startTime = "StartTime";

        public string StartTime
        {
            get => startTime;
            set
            {
                startTime = value;
                OnPropertyChanged("StartTime");
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
        
        private ObservableCollection<ProcessVM> processVMs = new ObservableCollection<ProcessVM>();

        public ObservableCollection<ProcessVM> ProcessVMs
        {
            get => processVMs;
            set
            {
                processVMs = value;
                OnPropertyChanged("ProcessVMs");
            }
        }

        public void CreateListOfProcessesVM()
        {
            foreach (var process in processesList.Processes)
            {
                ProcessVMs.Add(new ProcessVM(process.ProcessName, process.Id));
            }
        }

        public void LoadProcessDetails(object param)
        {
            var param2 = (ProcessVM) param;
            ProcessDetailsVM details = new ProcessDetailsVM(param2.Id);
            StartTime = details.StartTime.ToString();
        }

        public ICommand SaveProductCommand
        {
            get
            {
                if (_saveProductCommand == null)
                {
                    _saveProductCommand = new RelayCommand(
                        
                        param => LoadProcessDetails(param)
                    );
                }
                return _saveProductCommand;
            }
        }


    }
}
