namespace LiskovSubstitutionPrinciple.Good
{
    internal class Bird{
        public class FlyingBirds : Bird{ //We need to create this additional class
        public void Fly() { }
        }
        public class Duck : FlyingBirds { }
        public class Ostrich : Bird { }
}
}
