using GymManagerDatabase;
using GymManagerDatabase.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GymManagerLogic
{
    public class Logic
    {
        Repository repo = new();
        List<Member> members = new();

        /// <summary>
        /// Returns all members in the database
        /// </summary>
        /// <returns>Returns all member is a Member type list</returns>
        public List<Member> AllMembers()
        {
            return repo.AllMembers();
        }

        public List<Membership> AllMemberships()
        { 
            return repo.AllMemberships();
        }

        /// <summary>
        /// Tries to add a new member to the database, doese error checking and provides status message for user
        /// </summary>
        /// <param name="name">Name of the member</param>
        /// <param name="address">Address of the mebmer</param>
        /// <param name="phone">Phone number of the member(optional so can be empty)</param>
        /// <param name="email">Email address of the member(optiona so van be empty)</param>
        /// <param name="message">Universal status message for the user</param>
        /// <returns>Returns true on successful adding of new member</returns>
        public bool AddNewMember(string name, string address, string phone, string email,out string message)
        {
            members = repo.AllMembers();           

            try
            {
                Member member = new();
                member.Name = name;
                member.Address = address;
                member.Phone = phone;
                member.EMail = email;

                //Check if the input is valid (Name and Address is filled out)
                if(!IsGoodInput(member,out message)) return false;
                
                //Check if the member already excists
                if (member.AlreadyInDatabase(members))
                {
                    message = "This person already excists!";
                    return false;
                }

                //Adding member
                repo.AddNewMember(member);
                return true;

            }
            catch (Exception)
            {
                message = "Error!";
                return false;
            }

        }

        /// <summary>
        /// Checks if the Members name and address are filled out correctly, used for list box item selection (No error message provided)
        /// </summary>
        /// <param name="member">Member to validate</param>
        /// <returns>Returns true if all values are correct</returns>
        public bool IsGoodInput(Member member)
        {
            try
            {
                if(member == null) return false;
                if (member.Name == null || member.Name == "")
                {
                    return false;
                }
                if (member.Address == null || member.Address == "")
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            

            return true;

        }


        /// <summary>
        /// Checks if the Members name and address are filled out correctly, used when adding new members (Message for the user is provided)
        /// </summary>
        /// <param name="member">Member to validate</param>
        /// <param name="message">Universal message for user</param>
        /// <returns>Returns true if all values are correct</returns>
        public bool IsGoodInput(Member member, out string message) 
        {
            try
            {
                //Message to be returned (if an error occurs it will be changed to appropiate error message)
                message = "Save successful!";

                if (member.Name == null || member.Name == "")
                {
                    message = "Name must be given!";
                    return false;
                }
                if (member.Address == null || member.Address == "")
                {
                    message = "Address must be given!";
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                message = "Error!";
                return false;
            }
            
        }


        /// <summary>
        /// Checks if the new Membership is filled out correctly and sets type for the membership, used when adding new memberships (Message for the user is provided)
        /// </summary>
        /// <param name="membership">Membership to validate and set type for</param>
        /// <param name="daily">.Checked value of radiobutton representing daily membership choice</param>
        /// <param name="monthly">.Checked value of radiobutton representing monthly membership choice</param>
        /// <param name="annual">.Checked value of radiobutton representing annual membership choice</param>
        /// <param name="message">Universal message for user</param>
        /// <returns>Returns true if all values are correcct</returns>
        private bool IsGoodInput(ref Membership membership, bool daily, bool monthly, bool annual, out string message)
        {

            try
            {
                //setting type property of membership
                message = "Membership has been added!";
                if (daily)
                {
                    membership.Type = "Daily";
                }
                else if (monthly)
                {
                    membership.Type = "Monthly";
                }
                else if (annual)
                {
                    membership.Type = "Annual";
                }
                else
                {
                    message = "Please choose a membership type!";
                    return false;
                }

                if (membership.EndDate < membership.StartDate)
                {
                    message = "End date cannot precede start date!";
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                message = "Error!";
                return false;
            }
            
        }


        
        /// <summary>
        /// Tries modifying an excisting member
        /// </summary>
        /// <param name="selectedMember">Member to be modified</param>
        /// <param name="message">Univversal message for the user</param>
        /// <returns>Returns true if member was modified successfuly</returns>
        public bool ModifyMember(Member selectedMember, out string message)
        {
            try
            {
                if(!IsGoodInput(selectedMember, out message)) return false;
                if(!repo.ModifyMember(selectedMember)) return false;

                return true;
            }
            catch (Exception)
            {
                message = "Error!";
                return false;
            }

        }


        /// <summary>
        /// Tries adding a new membership
        /// </summary>
        /// <param name="selectedMember">Member who "owns" the mebmership</param>
        /// <param name="daily">.Checked value of radiobutton representing daily membership choice</param>
        /// <param name="monthly">.Checked value of radiobutton representing monthly membership choice</param>
        /// <param name="annual">.Checked value of radiobutton representing annial membership choice</param>
        /// <param name="startdate">Starting date of the membership</param>
        /// <param name="enddate">End date of the membersip</param>
        /// <param name="message">Universal message for the user</param>
        /// <returns>Returns true if the new membership could be added</returns>
        public bool AddNewMembership(Member selectedMember, bool daily, bool monthly, bool annual, DateTime startdate, DateTime enddate,out string message)
        {
            try
            {
                Membership membership = new();
                membership.OwnerId = selectedMember.Id;
                membership.StartDate = startdate;
                membership.EndDate = enddate;

                if (!IsGoodInput(ref membership, daily, monthly, annual, out message)) return false;
                if (!repo.AddNewMembership(membership)) return false;

                return true;
            }
            catch (Exception)
            {
                message = "Error!";
                return false;
            }          
        }


        /// <summary>
        /// Returnes all active members in a Member type list
        /// </summary>
        /// <returns>Returns all active members</returns>
        public List<Member> ActiveMembers()
        {
            return repo.ActiveMembers();            
        }

        /// <summary>
        /// Returnes all passive members in a Member type list
        /// </summary>
        /// <returns>Returns all active members</returns>
        public List<Member> PassiveMembers()
        {
            return repo.AllMembers().Except(repo.ActiveMembers()).ToList();
        }

        /// <summary>
        /// Returns all valid memberships in a Memberships type list
        /// </summary>
        /// <returns>Returns all valid memberships</returns>
        public List<Membership> ValidMemberships()
        {
            repo.AllMembers();
            return repo.ValidMemberships();
        }

        /// <summary>
        /// Returns all expired memberships in a Memberships type list
        /// </summary>
        /// <returns>Returns all expired memberships</returns>
        public List<Membership> ExpiredMemberships()
        {
            repo.AllMembers();
            return repo.ExpiredMemberships();
        }

        /// <summary>
        /// Returns all memberships of the selected member in a Membership type list
        /// </summary>
        /// <param name="selectedmember">Member who's memberships will be returned</param>
        /// <returns>Returns all memberships of the selected member</returns>
        public List<Membership> MembershipsOfMember(Member selectedmember)
        {
            return repo.MembershipsOfMember(selectedmember);
        }

        /// <summary>
        /// Returns a Dictionary containing data to be represented in the chart
        /// </summary>
        /// <returns>Returns a Dictionary where the key is the month and the values is the number of the sold memberships</returns>
        public Dictionary<string,int> GetChartData()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<Membership> memberships = repo.AllMemberships();

            memberships.Sort((x, y) => DateTime.Compare(x.StartDate.Date, y.StartDate.Date));

            DateTime start = memberships.MinBy(x => x.StartDate).StartDate;
            DateTime end = memberships.MaxBy(x => x.StartDate).StartDate;

            for (int i = start.Month; i <= end.Month; i++)
            {
                if (!dict.ContainsKey(start.AddMonths(i - start.Month).ToString()))
                {
                    dict.Add(start.AddMonths(i - start.Month).ToString("MMMM"), 0);
                }
            }

            foreach (var item in memberships)
            {
                if (dict.ContainsKey(item.StartDate.ToString("MMMM")))
                {
                    dict[item.StartDate.ToString("MMMM")]++;
                }
                else
                {
                    dict.Add(item.StartDate.ToString("Y"), 1);
                }
            }

            return dict;
        }
    }
}
