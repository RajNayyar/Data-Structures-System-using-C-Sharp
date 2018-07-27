using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public abstract class DataStructure
    {
        public DataStructure head = null;
        public DataStructure temp;
        public DataStructure next;
        public int data;
        public int size = 0;
        //public abstract void CreateNode();
        public abstract void Display();
        public abstract void InsertAtEnd();
        public abstract void RemoveAtEnd();
        public abstract void Sorter();
        
    }
}
