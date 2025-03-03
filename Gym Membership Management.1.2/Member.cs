using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Membership_Management._1._2
{
    class Member : MemberBase
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name can't be empty");
                }
            }
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Member Name: {Name}");
        }
    }
}
