using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Bad
{
    internal class PrinterWithoutFax : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Print");
        }
        public void Scan()
        {
            Console.WriteLine("Scan");
        }
        public void Fax() //This printer don't have fax, so this metod is not needed. Here we break ISP
        {
            throw new NotImplementedException();
        }

    }
}
