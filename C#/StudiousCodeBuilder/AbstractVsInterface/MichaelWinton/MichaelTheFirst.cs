using AbstractVsInterface.AbstractClasses;

namespace AbstractVsInterface.MichaelWinton
{
    public class MichaelTheFirst : MichaelWintonAbstract
    {
        public MichaelTheFirst(int myAge) => age = myAge;

        public override void SayMyHobby()
        {
            Console.WriteLine("I like partying");
        }
    }
}
