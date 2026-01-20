using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Practice.dsascenario.ParcelTrackerApp{
    class ParcelNode
    {
        private string stage;
        private ParcelNode next;

        public ParcelNode(string stage)
        {
            this.stage = stage;
            next = null;
        }

        public string Stage
        {
            get { return stage; }
            set { stage = value; }
        }

        public ParcelNode Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
