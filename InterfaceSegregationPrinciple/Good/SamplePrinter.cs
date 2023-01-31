namespace InterfaceSegregationPrinciple.Good
{
    internal class SamplePrinter : IFax, IPrint, IScan
    {
        public void Fax()
        {
            Console.WriteLine("Fax");
        }

        public void Print()
        {
            Console.WriteLine("Print");
        }

        public void Scan()
        {
            Console.WriteLine("Scan");
        }
    }
}
