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
    /// <summary>
    /// Membership management operations and how they work
    /// </summary>
    internal class GymManagement
    {
        static List<Member> members = new List<Member>(); // to be able to store all the names
        static void Main(string[] args)
        {

            /// <summary>
            /// Show off the display menu
            /// </summary>

            while (true) //keeps loop going until option 5 is pressed
            {
                try
                {
                    Console.WriteLine("Welcome to your Gym Membership Management!");
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    Console.WriteLine("1. Add Member");
                    Console.WriteLine("2. View Member");
                    Console.WriteLine("3. Edit Member");
                    Console.WriteLine("4. Delete Member");
                    Console.WriteLine("5. Exit");
                    Console.Write("Your choice: ");

                    string choice = Console.ReadLine();

                    switch (choice) // using switch option to handle whichever menu options is picked
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
                            Console.WriteLine("Invalid choice. Please choose from existing choices."); // lets user know to pick a number from the options
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}"); // handles wahtever other errors might happen
                }
            }
        }
        /// <summary>
        /// Adds a new member to the membership list.
        /// </summary>
        static void AddMember()
        {
            try
            {
                Console.Write("Please enter member's name: ");
                string memberName = Console.ReadLine();

                Member newMember = new Member { Name = memberName };
                members.Add(newMember);
                Console.WriteLine("Member added!");
            }
            catch (Exception ex)
            { 
                Console.WriteLine($"Error: {ex.Message}"); 
            }
        }
        /// <summary>
        /// Views all the member's added and also validates if there no names on the list
        /// </summary>
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
        /// <summary>
        /// Edits the name of members already on the list
        /// </summary>
        static void EditMembers()
        {
            try 
            {
                Console.Write("Enter member's current name: ");
                if (int.TryParse(Console.ReadLine(), out int index) && index < members.Count) // checks if input is valid within the list of names
                {
                    Console.Write("Enter new name for the member: ");
                    string newName = Console.ReadLine(); // reads new name

                    if (!string.IsNullOrWhiteSpace(newName)) // validations
                    {
                        members[index].Name = newName;
                        Console.WriteLine("Member's Name updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Name cannot be empty. Please try again"); // handles errors
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again"); // handles errors
                }
            }
            catch
            {
                Console.WriteLine("ERROR. Please try again"); // handles whatever erros might happen
            }
        }
        /// <summary>
        /// Deletes a member from the membership list base on their name
        /// </summary>
        static void DeleteMember()
        {
            Console.Write("Enter member's name to delete:");
            string removeMemberName = Console.ReadLine();
            int indexToRemove = members.FindIndex(m => m.Name == removeMemberName); // looks for member in the list by their name

            if (indexToRemove < 0) // checks if member is on the list
            {
                members.RemoveAt(indexToRemove); // removes member's name from the list
                Console.WriteLine("Member deleted successfully!");
            }
            else
            {
                Console.WriteLine("Member not found. please try again."); // lets user  know that the name isn't found to try again
            }
        }
    }
}
