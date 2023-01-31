namespace DependencyInversionPrinciple.Good
{
    internal class AuthenticationManager
    {
        private IWebsite _website;

        public AuthenticationManager(IWebsite website)
        {
            _website = website;
        }

        public void Authenticate(User user, string login, string password)
        {
            if (user.Login == login, user.Password == password)
            {
                Website website = new Website();
                website.GetAccess(user);
            }
        }
    }
}