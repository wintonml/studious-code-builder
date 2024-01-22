using AbstractVsInterface.MichaelWinton;

namespace StudiousCodeBuilder
{
    public static class MyCoolProgram
    {
        public static void Main()
        {
            var mikeTheFirst = new MichaelTheFirst(25);
            var mikeTheSecond = new MichaelTheSecond(23);

            mikeTheFirst.Occupation = "Professional climber";

            mikeTheFirst.SayMyName();
            mikeTheFirst.SayMyHobby();
            mikeTheFirst.StateProfession();

            mikeTheSecond.SayMyName();
            mikeTheSecond.SayMyHobby();
            mikeTheSecond.StateProfession();
        }
    }

}
