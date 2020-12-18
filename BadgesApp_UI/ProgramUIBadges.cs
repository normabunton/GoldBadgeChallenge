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
            Console.Clear();
            List<string> doors = new List<string>();
            Console.WriteLine("What is the number on the badge to Create: (ie.12345)\n");
            int badgeId = int.Parse(Console.ReadLine());
            Console.WriteLine("List a Door this Badge needs access to:");
            bool doorInput = true;
            while (doorInput)
            {
                string addedDoor = Console.ReadLine();
                doors.Add(addedDoor);
                Console.WriteLine("Any other Doors? (y/n)");
                string secondDoor = Console.ReadLine().ToLower();
                if (secondDoor == "y")
                {
                    Console.WriteLine("What other door would you like to assign:");
                    string doorResponse = Console.ReadLine();
                    doors.Add(doorResponse);
                }
                else
                {
                    doorInput = false;
                }
            }
            Badges newBadge = new Badges(badgeId, doors);
            _badgesRepository.Add(newBadge.BadgeId, newBadge.DoorName);
            Console.WriteLine("This door(s) has been added. Thank you");
        }
        public void UpdateBadge()
        {
            Console.WriteLine("What is the badge number you would like to update ?");
            int BadgeId = int.Parse(Console.ReadLine());
            List<string> doors = _badgesRepository.GetBadgeById(BadgeId);
            Console.WriteLine("What would you like to do?\n" +
                                "1.Remove a door?\n" +
                                "2.Add a door?");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    DeleteDoor(BadgeId, doors);
                    break;
                case "2":
                    AddDoor(BadgeId, doors);
                    break;
                
            }
            //Console.WriteLine(result"12345 "has access to doors" A5 & A7.");

            Console.WriteLine("Door was removed.");
            Console.Clear();

            Console.WriteLine("12345 has access to door A7.");

            Console.WriteLine("DeleteAllDoorsFromExistingBadge.");

            Console.WriteLine("The door(s) have been Removed from Access to this Badge.");
            Console.Clear();
        }
        public void AddDoor(int badgeId, List<string> doors)
        {
            Console.WriteLine("Which door would you like access to for this Badge:");
            string input = Console.ReadLine();
            doors.Add(input);
            _badgesRepository.UpdateBadge(badgeId, doors);
        }
        public void DeleteDoor(int badgeId, List<string> doors)
        {
            Console.WriteLine("Which door would you like to Remove?:");
            string input = Console.ReadLine();
            doors.Remove(input);
            _badgesRepository.UpdateBadge(badgeId, doors);
        }

        public void ListBadges()
        {
            Console.Clear();
            Console.WriteLine("Badge Id #\n Door Access\n");
            Dictionary<int, List<string>> badges = _badgesRepository.ListBadges();

            foreach (int badgeId in badges.Keys)
            {
                DisplayContent(badgeId, badges[badgeId]);
            }
        }
        private void DisplayContent(int badgeId, List<string> doors)
        {
            Console.WriteLine($"{badgeId},");
            foreach (string door in doors)
            {
                Console.WriteLine($"{door}");
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
