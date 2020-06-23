using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS
{
    [Serializable]
    abstract class Record
    {
        private int id;

        public Record()
        {
            id = 0;
        }

        public Record(int id)
        {
            this.id = id;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public abstract bool addRecord();
    }
}