namespace AbstractVsInterface.AbstractClasses
{
    public abstract class MichaelWintonAbstract
    {
        public int age;
        public string name = "Michael Winton";
        public abstract void SayMyHobby();
        public void SayMyName()
        {
            Console.WriteLine($"My name is {name}");
        }
    }
}