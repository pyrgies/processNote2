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
        

        public ProcessDetailsVM(int id)
        {
            var process = Process.GetProcessById(id);

            Start = process.StartTime;
            Memory = 15;
            Cpu = 20;
            rTime = DateTime.Now - Start;
        }

        public DateTime Start { get; }
        public double Memory { get; }
        public double Cpu { get; }
        public TimeSpan rTime { get; }


    }
}
