using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;


namespace ProcessNote2
{
    class ProcessListVM: INotifyPropertyChanged
    {
        private static ProcessesModel processesList = new ProcessesModel();

        private ProcessDetailsVM adamToCiul;

        public ProcessDetailsVM AdamToCiul
        {
            get => adamToCiul;
            set
            {
                adamToCiul = value;
                NotifyPropertyChanged();
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

        public void LoadProcessDetails(int id)
        {
            AdamToCiul = new ProcessDetailsVM(id);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")  
        {  
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand costam;

        public ICommand ShowProcessNameCommand
        {
            get
            {
                return costam = new RelayCommand(CanView, DisplayMessage);
            }
        }

        private bool CanView(object parameter)
        {
            return true;
        }       
        

        private void DisplayMessage(object parameter)
        {
             MessageBox.Show("BLA BLA");
            
        }
    }
}
