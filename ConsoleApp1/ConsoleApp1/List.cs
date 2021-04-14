using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface List<T>
    {
        void add(T data);

        T get(int index);

        void delete(int index);

        int getSize();

        Iterator<T> getForwardIterator();

        Iterator<T> getReverseIterator();
    }
}
