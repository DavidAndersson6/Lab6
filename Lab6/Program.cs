namespace Lab6
{
    public class Program
    {
        static void Main(string[] args)
        {

            Dog myDog = new Dog(4, "Buddy", "Brown", "Golden Retriever", 3, true);

            Cat myCat = new Cat(4, "Misse", "Gray", "Norwegian Forest Cat", 5, true);

            Fish myFish = new Fish(0, "Blubber", "Orange", "Clownfish", 2, false);

            Bulldog myBulldog = new Bulldog(4, "Fido", "Black", "French Bulldog", 3, false, true);

            Chihuahua myChihuahua = new Chihuahua(4, "Lillen", "Orange", "Pomerian", 6, false, true);

            myDog.PrintNumberOfLegs();

            myCat.PrintColor();

            myFish.PrintAge();

            myDog.MakeSound();

            myCat.MakeSound();

            myFish.MakeSound();

            myBulldog.MakeSound();

            myChihuahua.MakeSound();
        }
    }
}
