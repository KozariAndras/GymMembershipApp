using System;
using System.Collections.Generic;

namespace GymManagerDatabase.Datas
{
    public partial class Membership
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Type { get; set; } = null!;

        public virtual Member Owner { get; set; } = null!;

        public override string ToString()
        {
            return $"{this.StartDate.ToShortDateString()} - {this.EndDate.ToShortDateString()} Owner: {this.Owner.Name}";
        }
    }

    
}
