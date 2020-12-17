using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesRepository
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
        public void UpdateBadge (int originalBadges, List<string> newBadges)            
        {
            repository[originalBadges] = newBadges;            
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
