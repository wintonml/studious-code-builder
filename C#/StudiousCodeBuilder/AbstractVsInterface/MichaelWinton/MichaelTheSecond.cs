using AbstractVsInterface.Abstract;
using AbstractVsInterface.Interface;

namespace AbstractVsInterface.MichaelWinton
{
    public class MichaelTheSecond : MichaelWintonAbstract, IProfession
    {
        public MichaelTheSecond(int myAge)
        {
            age = myAge;
        }

        public string? Occupation { get; set; }

        public override void SayMyHobby()
        {
            Console.WriteLine("I like going to the gym");
        }

        public void StateProfession()
        {
            Console.WriteLine("I am a software engineer");
        }
    }
}
