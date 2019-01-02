using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessNote2
{
    class ProcessVM
    {
        public string Name { get;}
        public int Id { get;}

        public ProcessVM(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
