/*
// Author: Isaac Martinez
// Course: COMP-003
// Faculty: Jonathan Cruz
// Purpose: Final Project Part 2
*/
using System.Dynamic;

namespace Gym_Membership_Management._1._2
{
    internal class GymManagement
    {
        static List<Member> members = new List<Member>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to your Gym Membership Management!");
                Console.ReadLine();
                Console.WriteLine("1. Add Member");
                Console.WriteLine("2. View Member");
                Console.WriteLine("3. Edit Member");
                Console.WriteLine("4. Delete Member");
                Console.WriteLine("5. Exit");
                Console.Write("Yout choice: ");

                string choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        AddMember();
                        break;
                    case "2":
                        ViewMembers();
                        break;
                    case "3":
                        EditMembers();
                        break;
                    case "4":
                        DeleteMember();
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please choose from existing choices.");
                        break;
                }
            }
        }
    }
}
