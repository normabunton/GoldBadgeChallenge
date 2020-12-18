using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeRepoTest
{    
    public class Badges
    {
        public int BadgeId { get; set; }
        public List<string> DoorName { get; set; }        
    public Badges() { }
    public Badges(int badgeId, List<string> doorName)
    {
            BadgeId = badgeId;
            DoorName = doorName;
    }

        public Badges(int v1, string v2)
        {
        }
    }
}
