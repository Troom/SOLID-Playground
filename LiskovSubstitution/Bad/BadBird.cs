namespace LiskovSubstitution.Bad
{
    internal class BadBird{
        public void Fly() { }
    }
    internal class Duck : BadBird {  //OK Duck can fly
    }
    internal class Ostrich : BadBird {  // Ostrich can't fly. So therefore, inheritance from the duck break LSP
    }
}
