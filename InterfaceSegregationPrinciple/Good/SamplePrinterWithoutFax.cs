namespace InterfaceSegregationPrinciple.Good
{
    internal class SamplePrinterWithoutFax :IPrint, IScan
    {
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
