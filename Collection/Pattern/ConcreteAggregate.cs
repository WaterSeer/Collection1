using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Pattern
{
    class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList elements = new ArrayList();
        private ConcreteIterator iterator;

        public override object this[int index]
        {
            get { return elements[index]; }
            set { elements.Insert(index, value); }

        }

        public int Count
        {
            get { return elements.Count; }
        }

        public override Iterator CreateIterator()
        {
            iterator=new ConcreteIterator(this);
            return iterator;
        }
    }
}
