using System;
using System.Collections.Generic;
using GymManagerDatabase.Datas;

namespace GymManagerDatabase.Datas
{
    public partial class Member
    {
        public Member()
        {
            Memberships = new HashSet<Membership>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? Phone { get; set; }
        public string? EMail { get; set; }

        public virtual ICollection<Membership> Memberships { get; set; }

        public bool AlreadyInDatabase(List<Member> members)
        {
            if (members.Contains(this)) return true;
            return false;
        }

        public override string ToString() 
        {
            return $"Name: {Name} - Address: {Address} - Phone: {Phone} - E-mail: {EMail}";
        }
    }
}
