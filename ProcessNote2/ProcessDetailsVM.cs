using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessNote2
{
    class ProcessDetailsVM
    {
        

        public ProcessDetailsVM()
        {
            int id = 2736;
            var process = Process.GetProcessById(id);

            StartTime = process.StartTime;
            MemoryUsage = 15;
            CpuUsage = 20;
            runTime = DateTime.Now - StartTime;
        }

        public DateTime StartTime { get; }
        public double MemoryUsage { get; }
        public double CpuUsage { get; }
        public TimeSpan runTime { get; }


    }
}
