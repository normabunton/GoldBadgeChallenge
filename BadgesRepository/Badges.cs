using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesRepository
{    
    public class Badges
    {
        public int BadgeId { get; set; }
        public string DoorName { get; set; }
    public Badges() { }
    public Badges(int badgeId, string doorName)
    {
            BadgeId = badgeId;
            DoorName = doorName;
    }
}
}
