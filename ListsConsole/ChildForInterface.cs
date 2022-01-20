using System;
using System.Collections.Generic;
using System.Text;

namespace ListsConsole
{
    public class ChildForInterface : IInterfaceA, IInterfaceB
    {
        public void A()
        {
            Console.WriteLine(nameof(A));
        }

        void IInterfaceB.B()
        {
            Console.WriteLine("B");
        }

        private void T()
        {
            Console.WriteLine("T global");
        }

        void IInterfaceB.T()
        {
            Console.WriteLine("T by B");
        }

        void IInterfaceA.T()
        {
            Console.WriteLine("T by A");
        }
    }
}
