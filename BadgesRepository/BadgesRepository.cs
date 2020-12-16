using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesRepository
{
    public class BadgesRepository
    {
        private Dictionary<int, List<string>>repository = new Dictionary<int, List<string>>();

        public void Add(int badgeID, List<string> doorName) 
        {
            this.Add(badgeID, doorName, true);
        }
        public Dictionary<int, List<string>> ListBadgeNumbersAndDoorAccess()
        {
            return repository;
        }
        public void UpdateDoorsOnExistingBadge (int badgeID, List<string> newDoorName)
        {

        }
        public List<string> GetBadgeById( int badgeId)
        {
            foreach(List<string> badgeId in repository)
            if (BadgesRepository.BadgeId == badgeId)
            {
                return BadgesRepository;
            }
            //if checking to see if badge is in dictionary //methods with getting the key ie. int ofbadge return badgeId
        }
    }
}
