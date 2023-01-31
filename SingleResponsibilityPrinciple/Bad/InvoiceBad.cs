namespace SingleResponsibilityPrinciple.Bad
{
    //This solution is defective because we're create huge class hard to maintain.
    //In one class we have multiple methods, and changing it will be more harder.
    internal class InvoiceBad
    {
        //Any implementation for invoice

        public float CalculateTotal()
        {
            //Any Implementation
            throw new NotImplementedException();
        }
        public void Print()
        {
            //Any Implementation
            throw new NotImplementedException();

        }
        public void InvoiceSending()
        {
            //Any Implementation
            throw new NotImplementedException();
        }

    }
}
