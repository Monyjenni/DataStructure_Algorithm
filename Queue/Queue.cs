using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Cell
        // every object created from this class will contain these fucking 3
    {
        public string Value;
        public Cell Next;
        public Cell Prev;

    =    public void enqueue(Cell TopSentinel, string data)
        {
            Cell cell = new Cell();
            cell.Value = data;
            cell.Next = TopSentinel.Next;
            cell.Next.Prev = cell;
            cell.Prev = TopSentinel;
            TopSentinel.Next = cell;

        }
        public void dequeue() // to be called by bottomsentinel object
        {
            if(this.Prev != null)
            {
                this.Prev.Next = this;
                this.Prev= this.Prev.Prev;
            }
        }
    }
}
