namespace DependencyInversionPrinciple.Bad
{
    internal class AuthenticationManager
    {
        public void Authenticate(User user, string login, string password)
        {
            if (user.Login == login, user.Password == password)
            {
                Website website = new Website(); //Here we have a problem.
                website.GetAccess(user);
            }
        }
    }
}