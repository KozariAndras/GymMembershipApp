using GymManagerDatabase.Datas;
using GymManagerDatabase.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerDatabase
{
    public class Repository
    {
        Database database = new();
        List<Member> members = new();

        /// <summary>
        /// Adds a new member to the database
        /// </summary>
        /// <param name="member">The member to add to the database</param>
        public void AddNewMember(Member member)
        {
            database.Members.Add(member);
            database.SaveChanges();
        }

        /// <summary>
        /// Adds a new membership to the database
        /// </summary>
        /// <param name="membership">The membership to add to the database</param>
        /// <returns></returns>
        public bool AddNewMembership(Membership membership)
        {
            try
            {
                database.Memberships.Add(membership);
                database.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Querry for all the members in the database
        /// </summary>
        /// <returns>All the members in a Meber type list</returns>
        public List<Member> AllMembers()
        {
            return database.Members.ToList();
        }

        public List<Membership> AllMemberships() 
        {
            return database.Memberships.ToList();
        }

        /// <summary>
        /// Tries modifying an excisting member in the database
        /// </summary>
        /// <param name="selectedMember">The member to modify</param>
        /// <returns>Returns true if member was modified successfuly</returns>
        public bool ModifyMember(Member selectedMember)
        {
            try
            {
                members = database.Members.ToList();
                foreach (Member member in members)
                {
                    if (member.Id == selectedMember.Id)
                    {
                        members[members.IndexOf(member)] = selectedMember;
                        break;
                    }
                }
                database.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }           
        }
        
        /// <summary>
        /// Querry for all the active members in the database (a member is active if he has a valid membership at the time of the querry)
        /// </summary>
        /// <returns>All active members in a Member type list</returns>
        public List<Member> ActiveMembers()
        {
            return database.Members.Include(x => x.Memberships).Where
                (x => x.Memberships.Any
                (x => x.StartDate.Date <= DateTime.Today && x.EndDate.Date >= DateTime.Today)).ToList();
        }

        /// <summary>
        /// Querry for all the valid memberships in the database
        /// </summary>
        /// <returns>All valid memberships in a Membership type list</returns>
        public List<Membership> ValidMemberships()
        {
            return database.Memberships.Where
                (x => x.StartDate.Date <= DateTime.Today && x.EndDate.Date >= DateTime.Today).ToList();
        }


        /// <summary>
        /// Querry for all the expired memberships in the database
        /// </summary>
        /// <returns>All the expired memberships in a Membership type list</returns>
        public List<Membership> ExpiredMemberships()
        {
            return database.Memberships.Where(x => x.EndDate.Date < DateTime.Today).ToList();
        }

        /// <summary>
        /// Querry for all the memberships of a given member (returns both valid and expirted memberships)
        /// </summary>
        /// <param name="selectedmember">The "owner" who's memberships we want top querry</param>
        /// <returns>All the memberships owned my the input member in a Membership type list</returns>
        public List<Membership> MembershipsOfMember(Member selectedmember)
        {
            return database.Memberships.Where(x => x.OwnerId == selectedmember.Id).ToList();
        }
    }
}
