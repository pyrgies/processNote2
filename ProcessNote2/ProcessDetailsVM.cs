using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessNote2
{
    class ProcessDetailsVM
    {
        

        public ProcessDetailsVM(int Id)
        {
            int id = Id;
            var process = Process.GetProcessById(id);


            StartTime = process.StartTime;
            MemoryUsage = process.WorkingSet64 / 1048576;
            CpuUsage = getCPU(process.ProcessName);
            runTime = DateTime.Now.TimeOfDay - StartTime.TimeOfDay;
        }

        public double getCPU(string processName)
        {
            PerformanceCounter cpuCounter = new PerformanceCounter("Process", "% Processor Time", processName);
            cpuCounter.NextValue();
            Thread.Sleep(1000);
            var cpuPercent = cpuCounter.NextValue();
            return Math.Round(cpuPercent);

        }

        //public float processCPU { get; set; }

        public DateTime StartTime { get; }
        public double MemoryUsage { get; }
        public double CpuUsage { get; set; }
        public TimeSpan runTime { get; }



    }
}
