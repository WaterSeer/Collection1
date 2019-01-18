using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Pattern
{
    class ConcreteIterator : Iterator
    { 
        private readonly ConcreteAggregate aggregate;
        private int current; //закрытый указатель на текущий элемент
        public ConcreteIterator(ConcreteAggregate aggregate) //конструктор
        {
            this.aggregate = aggregate;
        }

        public override object CurrentItem() //тек
        {
            return aggregate[current];
        }

        public override object First() //реализация метода First
        {
            return aggregate[0];
        }

        public override bool IsDone()
        {
            return (current >= (aggregate.Count - 1));
        }

        public override object Next() //метод увеличения курсора
        {
            object element = null;
            if (current < aggregate.Count - 1)
                element = aggregate[++current];

            return element;
        }
    }
}
