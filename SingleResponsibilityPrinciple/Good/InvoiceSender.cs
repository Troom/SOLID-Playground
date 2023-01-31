namespace SingleResponsibilityPrinciple.Good
{
    internal class InvoiceSender
    {
        private Invoice _invoice;

        public InvoiceSender(Invoice invoice)
        {
            _invoice = invoice;
        }

        public void SendInvoice()
        {
            //...Sending Implementation
            throw new NotImplementedException();

        }

    }
}
