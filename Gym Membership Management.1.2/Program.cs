/*
// Author: Isaac Martinez
// Course: COMP-003
// Faculty: Jonathan Cruz
// Purpose: Final Project Part 2
*/
using System.Dynamic;
using System.Linq.Expressions;

namespace Gym_Membership_Management._1._2
{
    internal class GymManagement
    {
        static List<member> members = new List<member>();

        public static object MemberName { get; private set; }

        static void Main(string[] args)
        {
            GymManagement gymManagement = new GymManagement();

            while (true)
            {
                try
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

                    switch (choice)
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
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private static void EditMembers()
        {
            throw new NotImplementedException();
        }

        static void AddMember()
        {
            try
            {
                Console.Write("Please enter member's name: ");
                string memberName = Console.ReadLine();

                member newMember = new member { Name = memberName };
                member.Add(newMember);
                Console.WriteLine("Member added!");
            }
            catch (Exception ex)
            { Console.WriteLine($"Error: {ex.Message}"); }
        }
        static void ViewMembers()
        {
            if (members.Count == 0)
            {
                Console.WriteLine("No members found");
            }
            else
            {
                Console.WriteLine("\nMember's List:");
                foreach (var member in members)
                {
                    member.DisplayDetails();
                }
            }
        }
        static void EditMember()
        {
            try 
            {
                Console.Write("Enter member's current name: ");
                if (int.TryParse(Console.ReadLine(), out int index) && index < members.Count)
                {
                    Console.Write("Enter new name for the member: ");
                    string newName = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(newName))
                    {
                        members[index].Name = newName;
                        Console.WriteLine("Member's Name updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Name cannot be empty. Please try again");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
            }
            catch
            {
                Console.WriteLine("ERROR. Please try again");
            }
        }
        static void DeleteMember()
        {
            Console.Write("Enter member's name to delete:");
            string removeMemberName = Console.ReadLine();
            int indexToRemove = members.FindIndex(m => m.Name == removeMemberName);

            if (indexToRemove < 0)
            {
                members.RemoveAt(indexToRemove);
                Console.WriteLine("Member deleted successfully!");
            }
            else
            {
                Console.WriteLine("Member not found. please try again.");
            }
        }
    }
}
