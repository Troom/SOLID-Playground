using System.Numerics;

namespace OpenClosePrinciple.Bad
{
    internal class InvoiceSenderBad
    {
        //Any additional functionality breaks the principle of SRP
        //Polymorphism can help with OCP.

        private InvoiceBad _invoice;

        public InvoiceSenderBad(InvoiceBad invoice)
        {
            _invoice = invoice;
        }

        public void SendInvoice()
        {
            //...Sending Implementation
            throw new NotImplementedException();
        }

        public void SendOnDiscord()
        {
            //...Sending Implementation
            throw new NotImplementedException();
        }

    }
}
