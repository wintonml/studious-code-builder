using AbstractVsInterface.AbstractClasses;

namespace AbstractVsInterface.MichaelWinton
{
    public class MichaelTheSecond : MichaelWintonAbstract
    {
        public MichaelTheSecond(int myAge) => age = myAge;

        public override void SayMyHobby()
        {
            Console.WriteLine("I like going to the gym");
        }
    }
}
