using ClaimsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsConsoleApp
{
    class ProgramUIClaims
    {
        public void Run()
        {
            SeeClaims();
            Claims();
        }
        public void Claims()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select A Menu Item:\n" +
                                    "1.See all Claims:\n" +
                                    "2.Take Care of the Next Claim in the Queue:\n" +
                                    "3.Enter a new Claim:\n" +
                                    "4.Exit:");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        GetClaims();
                        break;
                    case "2":
                        UpdateClaim();
                        break;
                    case "3":
                        AddClaimToList();
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
        public void GetClaims()///ClaimsintheQueue
        {
            Console.Clear();
            Queue<Claims> claims = Queue<Claims>.SeeClaims();
            foreach (Claims claims in Queue<Claims>)
            {
                Console.WriteLine($"Claims Id:{claims.ClaimId}\n" +
                                  $"Type Of Claim:{claims.TypeOfClaim}\n" +
                                  $"Description:{claims.Description}\n" +
                                  $"Claim Amout:{claims.ClaimAmount}\n +" +
                                  $"Date of Incident:{claims.DateOfClaim}\n" +
                                  $"Date of Claim:{claims.DateOfClaim}\n" +
                                  $"Is Claim Valid:{claims.IsValid}");
            }
        }
        public void UpdateClaim()
        {
            //RemoveClaimFromQueue after updated
        }
        public void AddClaimToList()
        {
            Console.Clear();

        }
        private void SeeClaims()
        {
            Claims Claim1 = new Claims("1", ClaimType.Car, "Car Accident on 465", 400.00, "4/25/18", "4/27/18", true);
            Claims Claim2 = new Claims("2", ClaimType.Home, "House fire in Kitchen", 4000.00, "4/11/18", "4/12/18", true);
            Claims Claim3 = new Claims("3", ClaimType.Theft, "Stolen Pancakes", 4.00, "4/27/18", "6/01/18", false);
            _claimsList.AddClaimToList(Claim1);
            _claimsList.AddClaimToList(Claim2);
            _claimsList.AddClaimToList(Claim3);
        }
    }
}
