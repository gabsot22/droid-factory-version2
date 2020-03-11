using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment4
{
    // The T in the <T> is the type that the user
    // must specify when they make an instance of a
    // class that implents this interface.
    // The T can by any string of characters, but the standard
    // is to use the letter T for Type.
    // Can put multiple... <T, F, Bar, Baz>... if needed
    interface IGenericStack<T>
    {
        void Push(T Data);
        void AddToBack(T Data);
        T RemoveFromFront();
        T RemoveFromBack();

        void Display();

        bool IsEmpty { get; }
        int Size { get; }
    }
}
