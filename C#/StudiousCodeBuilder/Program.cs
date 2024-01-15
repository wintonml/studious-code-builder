using AbstractVsInterface.MichaelWinton;

namespace StudiousCodeBuilder
{
    public static class MyCoolProgram
    {
        public static void Main()
        {
            var mikeTheFirst = new MichaelTheFirst(25);
            var mikeTheSecond = new MichaelTheSecond(23);

            mikeTheFirst.SayMyName();
            mikeTheFirst.SayMyHobby();

            mikeTheSecond.SayMyName();
            mikeTheSecond.SayMyHobby();
        }
    }

}
