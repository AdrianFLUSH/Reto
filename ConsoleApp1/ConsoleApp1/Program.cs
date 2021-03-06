using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
            List<int> lista1 = new ArrayList<int>();
            List<String> lista2 = new ArrayList<String>();

            lista1.add(1);
            lista1.add(4);
            lista1.add(3);
            lista1.add(7);

            lista2.add(" hola");
            lista2.add(" Object ");
            lista2.add(" Oriented ");
            lista2.add(" Programming ");

            lista1.delete(3);

            Console.WriteLine("---------------------");

            Console.WriteLine("El tamaño es:" + lista1.getSize());

            Iterator<int> it = lista1.getForwardIterator();

            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("Dato: " + element);
            }

            Console.WriteLine("---------------------");

            it = lista1.getReverseIterator();

            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("Dato: " + element);
            }

            Console.WriteLine("---------------------");

            Iterator<String> itStrings = lista2.getReverseIterator();

            while (itStrings.hasNext())
            {
                Console.WriteLine(itStrings.next());
            }
        }
	}
}
