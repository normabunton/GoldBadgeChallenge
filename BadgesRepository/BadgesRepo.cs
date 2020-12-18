using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeRepoTest
{
    public class BadgesRepo
    {
        private Dictionary<int, List<string>>repository = new Dictionary<int, List<string>>();
        public object Value;

        public void Add(int badgeID, List<string> doorName) 
        {
            repository.Add(badgeID, doorName);
        }
        public Dictionary<int, List<string>> ListBadges()
        {
            return repository;
        }
        public void UpdateBadge (int badgeId, List<string> newDoors)            
        {
            repository[badgeId] = newDoors;            
        }
        public List<string> GetBadgeById( int badgeId)
        {
            if (repository.ContainsKey(badgeId))
            {
                return repository[badgeId];
            }
            return null;
        }
    }
}
