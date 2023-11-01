using System;
using Events.Models;

namespace Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            CollegeClassModel history = new CollegeClassModel("History 101", 3);
            CollegeClassModel math = new CollegeClassModel("Calculus 201", 2);

            history.EnrollmentFull += CollegeClass_EnrollmentFull;

            history.SignUpStudent("Shavaine Brown").PrintToConsole();
            history.SignUpStudent("John Doe").PrintToConsole();
            history.SignUpStudent("Sue Storm").PrintToConsole();
            history.SignUpStudent("Bob Catcher").PrintToConsole();
            history.SignUpStudent("Jimmy Neutron").PrintToConsole();
            Console.WriteLine();

            math.EnrollmentFull += CollegeClass_EnrollmentFull;

            math.SignUpStudent("Ash Catchum").PrintToConsole();
            math.SignUpStudent("Will Smith").PrintToConsole() ;
            math.SignUpStudent("Brad Pitt").PrintToConsole();

            TeamModel Jets = new TeamModel { Name="Jets", MaximumPlayers = 2 };
            PlayerModel Sam = new PlayerModel { PlayerName = "Sam" };
            PlayerModel John = new PlayerModel { PlayerName = "John" };
            PlayerModel Bob = new PlayerModel { PlayerName = "Bob" };
            PlayerModel Jill = new PlayerModel { PlayerName = "Jill" };

            Console.WriteLine();
            Console.WriteLine();

            Jets.MaxedPlayers += Team_Full;

            Jets.AddPlayer(Sam).PrintToConsole();
            Jets.AddPlayer(John).PrintToConsole();
            Jets.AddPlayer(Bob).PrintToConsole();
            Jets.AddPlayer(Jill).PrintToConsole();
        }

        private static void Team_Full(object sender, string e)
        {
            TeamModel model = (TeamModel)sender;


            Console.WriteLine();
            Console.WriteLine($"{model.Name} is Full.");
            Console.WriteLine();
        }

        private static void CollegeClass_EnrollmentFull(object sender, string e)
        {
            CollegeClassModel model = (CollegeClassModel)sender;
            Console.WriteLine();
            Console.WriteLine($"{model.CourseTitle}: Full" );
            Console.WriteLine();
        }
    }
}
