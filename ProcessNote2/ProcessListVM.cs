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
        private ICommand displayDetailsCommand;
        private string startTime = "StartTime";
        private string cpuUsage = "CpuUsage";
        private string memoryUsage = "MemoryUsage";
        private string runTime = "RunTime";

        public string StartTime
        {
            get => startTime;
            set
            {
                startTime = value;
                OnPropertyChanged("StartTime");
            }
        }

        public string CpuUsage
        {
            get => cpuUsage;
            set
            {
                cpuUsage = value;
                OnPropertyChanged("CpuUsage");
            }

        }

        public string MemoryUsage
        {
            get => memoryUsage;
            set
            {
                memoryUsage = value;
                OnPropertyChanged("MemoryUsage");
            }

        }

        public string RunTime
        {
            get => runTime;
            set
            {
                runTime = value;
                OnPropertyChanged("RunTime");
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
                //OnPropertyChanged("ProcessVMs");
            }
        }

        public void CreateListOfProcessesVM()
        {
            foreach (var process in processesList.Processes)
            {
                ProcessVMs.Add(new ProcessVM(process.ProcessName, process.Id));
            }
        }

        public void LoadProcessDetails(object selectedItem)
        {
            var convertedSelectedItem =  selectedItem as ProcessVM;
            ProcessDetailsVM details = new ProcessDetailsVM(convertedSelectedItem.Id);
            StartTime = details.StartTime.ToString();
            CpuUsage = details.CpuUsage.ToString() + " %";
            MemoryUsage = details.MemoryUsage.ToString() + " MB";
            RunTime = details.runTime.ToString();
        }

        


        public ICommand DisplayDetailsCommand
        {
            get
            {
                if (displayDetailsCommand == null)
                {
                    displayDetailsCommand = new RelayCommand(
                        
                        selectedProcess => LoadProcessDetails(selectedProcess)
                    );
                }
                return displayDetailsCommand;
            }
        }


    }
}
