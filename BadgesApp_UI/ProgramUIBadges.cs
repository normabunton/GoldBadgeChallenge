using BadgesRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesApp_UI
{
    class ProgramUIBadges
    {
        private BadgesRepo _badgesRepository = new BadgesRepo();
        public void Run()
        {
            SeeBadges();
            Menu();
        }
        public void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {           
            Console.WriteLine("Hello Security Admin, What would you like to do?\n" +
                              "1.Create a new badge:\n" +
                              "2.Update a badge:\n" +
                              "3.List all Badges:\n" +
                              "4.Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        CreateNewBadge();
                        break;
                    case "2":
                        UpdateBadge();
                        break;
                    case "3":
                        ListBadges();
                        break;
                    case "4":
                        Console.WriteLine("Thank you, Goodbye");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void CreateNewBadge()
        {
            Console.WriteLine("What is the number on the badge to Create: (ie.12345)\n");
            int badgeId = int.Parse(Console.ReadLine());
            Console.WriteLine("List a Door this Badge needs access to:");
            string doorName = Console.ReadLine();
            Console.WriteLine("Any other Doors? (y/n)");
                   Console.ReadLine();
            string input = Console.ReadLine();
                    switch (input.ToLower())
                        {
                        case "y":                            
                            break;
                        case "n":
                            return;                
                        }
        }        
        public void UpdateBadge()
        {
            Console.WriteLine("What is the badge number you would like to update ?");
                int BadgeId = int.Parse(Console.ReadLine());
            //Console.WriteLine(result"12345 "has access to doors" A5 & A7.");

            Console.WriteLine("What would you like to do?" +
                                "1.Remove a door?" +
                                "2.Add a door?");
            string input = Console.ReadLine();

            Console.WriteLine("Which door would you like to remove?"); 

            Console.WriteLine("Door removed.");

            Console.WriteLine("12345 has access to door A7.");

            Console.WriteLine("DeleteAllDoorsFromExistingBadge.");

            Console.WriteLine("The door(s) have been Removed from Access to this Badge.");
        }
        public void ListBadges()
        {
            Console.Clear();
            Console.WriteLine("Badge Id #\t\t Door Access\t\t");
            Dictionary<int, List<string>> badges = _badgesRepository.ListBadges();

                foreach (KeyValuePair<int, List<string>> badge in badges)
                {
                Console.WriteLine       ($"{badge.Key}, {badge.Value}");
                    //($"badge.Key = {0}, doorName.Value = {1}, badge.Key, badge.Value");
                }
        }
        private void SeeBadges()
        {
            Badges badge1 = new Badges(123, new List<string> { "A1", "A2" });
            Badges badge2 = new Badges(1234, new List<string> { "A3", "A4" });
            Badges badge3 = new Badges(12345, new List<string> { "B1", "B2" });

            _badgesRepository.Add(badge1.BadgeId, badge1.DoorName);
            _badgesRepository.Add(badge2.BadgeId, badge2.DoorName);
            _badgesRepository.Add(badge3.BadgeId, badge3.DoorName);
        }
    }
}
