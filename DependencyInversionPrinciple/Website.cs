using DependencyInversionPrinciple.Good;

namespace DependencyInversionPrinciple
{
    internal class Website : IWebsite
    {
        public void GetAccess(User user)
        {
                Console.WriteLine("You entered webiste");
        }
    }
}