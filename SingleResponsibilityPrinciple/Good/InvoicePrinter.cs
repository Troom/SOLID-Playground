namespace SingleResponsibilityPrinciple.Good
{
    internal class InvoicePrinter
    {
        private Invoice _invoice;

        public InvoicePrinter(Invoice invoice)
        {
                _invoice= invoice;
        }

        public void Print(){
            //...Printing Implementation
            throw new NotImplementedException();

        }
    }
}
