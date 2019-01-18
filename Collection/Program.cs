using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection.Pattern;

namespace Collection
{
    public class USerCollection<T>
    {

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Aggregate aggregate = new ConcreteAggregate();

            aggregate[0] = "Element A";
            aggregate[1] = "Element B";
            aggregate[2] = "Element C";
            aggregate[3] = "Element D";

            Iterator myIterator = aggregate.CreateIterator();

            Console.WriteLine("Первый элемент коллекции:" );

            object element = myIterator.First();
            Console.WriteLine(element);

            Console.WriteLine(new string('-',25));

            Console.WriteLine("Итерация по коллекции");
            while (!myIterator.IsDone())
            {
                Console.WriteLine(element);
                element =myIterator.Next();
            }

            Console.ReadKey();
        }
    }
    
}
