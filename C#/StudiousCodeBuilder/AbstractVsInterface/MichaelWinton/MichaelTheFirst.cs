using AbstractVsInterface.Abstract;
using AbstractVsInterface.Interface;

namespace AbstractVsInterface.MichaelWinton
{
    public class MichaelTheFirst : MichaelWintonAbstract, IProfession
    {
        public string? Occupation { get; set; }

        public MichaelTheFirst(int myAge)
        {
            age = myAge;
        }

        public void StateProfession()
        {
            if (string.IsNullOrEmpty(Occupation))
            {
                Console.WriteLine("I don't really have a job I like to chill");
            }
            else
            {
                Console.WriteLine($"I work as a {Occupation}.");
            }
        }

        public override void SayMyHobby()
        {
            Console.WriteLine("I like partying");
        }
    }
}
