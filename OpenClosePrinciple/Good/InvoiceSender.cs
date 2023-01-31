namespace OpenClosePrinciple.Good
{
    internal class InvoiceSender
    {
        private Invoice _invoice;
        private IInvoiceProvider _invoiceProvider;

        public InvoiceSender(Invoice invoice, IInvoiceProvider invoiceProvider)
        {
            _invoice = invoice;
            _invoiceProvider = invoiceProvider;
        }

        public void Send() {
            _invoiceProvider.Send(_invoice);
        }


    }
}
