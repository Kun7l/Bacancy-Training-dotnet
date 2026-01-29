class Animal
{
    public void Introduce() => Console.WriteLine("Hi i am animal");
    public void MakeSound() => Console.WriteLine("Making sound");

}
class Dog : Animal
{
    public new void MakeSound() => Console.WriteLine("bark");
    public void MoveTail() => Console.WriteLine("Move tail");
}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Dog dog = new Dog();
//        dog.MakeSound();
//    }
//}
