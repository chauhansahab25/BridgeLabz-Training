using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Practice.dsascenario.SortAadharNo
{
    class AadharRecord
    {
        private long aadhar;

        public AadharRecord(long a)
        {
            aadhar = a;
        }

        public long GetAadhar()
        {
            return aadhar;
        }
    }
    
}
