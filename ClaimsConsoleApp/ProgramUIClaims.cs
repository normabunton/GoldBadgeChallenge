using ClaimsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsConsoleApp
{
    class ProgramUIClaims
    {
        private ClaimsRepo _claimsList = new ClaimsRepo();
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
                public void GetClaims()
                {
                    Console.Clear();
                     Queue<Claims> claims = _claimsList.GetClaims();

                    foreach (Claims claim in claims)
                    {
                        Console.WriteLine($"Claims Id:{claim.ClaimId}\n" +
                                          $"Type Of Claim:{claim.TypeOfClaim}\n" +
                                          $"Description:{claim.Description}\n" +
                                          $"Claim Amout:{claim.ClaimAmount}\n " +
                                          $"Date of Incident:{claim.DateOfIncident}\n" +
                                          $"Date of Claim:{claim.DateOfClaim}\n" +
                                          $"Is Claim Valid:{claim.IsValid}");
                    }
                }
                public void UpdateClaim ()
                {
                    //Console.Clear();
                    //Claims updateClaim = new Claims();
                    //Console.WriteLine("Review the next item in the Queue: {0}",
                    ////updateClaim.Peek());
                    ////Console.WriteLine("Do you want to deal with this Claim Now? (y/n)");
                    ////if true (){ Console.WriteLine("Claim at the top of the Queue is: {0}", queue.Peek());  }display claim at top of queue
                    ////else if {}return to _claimsList
                    ///
                    //string updateClaim = Console.ReadLine();
                    //Console.WriteLine($"Claims Id:{updateClaim.ClaimId}\n" +
                    //              $"Type Of Claim:{updateClaim.TypeOfClaim}\n" +
                    //              $"Description:{updateClaim.Description}\n" +
                    //              $"Claim Amout:{updateClaim.ClaimAmount}\n +" +
                    //              $"Date of Incident:{updateClaim.DateOfIncident}\n" +
                    //              $"Date of Claim:{updateClaim.DateOfClaim}\n" +
                    //              $"Is Claim Valid:{updateClaim.IsValid}");

                    //Console.WriteLine("You have updated this Claim");
                    ////updateClaim.Dequeue();
        }
                private void AddClaimToList()
                {
                    Console.Clear();
                    Claims newClaim = new Claims();             
                    Console.WriteLine("Enter the Claim Id:");
                    newClaim.ClaimId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Claim Type Number:\n" +
                                        "1.Auto\n" +
                                        "2.Home\n" +
                                        "3.Theft");
                    string claimTypeAsString = Console.ReadLine();
                    int claimAsInt = int.Parse(claimTypeAsString);
                    newClaim.TypeOfClaim = (ClaimType)claimAsInt;
                    Console.WriteLine("Enter the Claim Description:");
                    newClaim.Description = Console.ReadLine();
                    Console.WriteLine("Amount of Damage");
                    string amountAsString = Console.ReadLine();
                    newClaim.ClaimAmount = double.Parse(amountAsString);
                    Console.WriteLine("Date of Incident");
                    newClaim.DateOfIncident = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Date of Claim");
                    newClaim.DateOfClaim = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Is this claim valid (y/n)\n");
                    Console.ReadKey();
                    _claimsList.AddClaimToList(newClaim);
                    Console.WriteLine("You have added a new Claim to the Queue");
                    Console.ReadLine();
                }
                private void SeeClaims()
                {
                    Claims Claim1 = new Claims(1, ClaimType.Car, "Car Accident on 465", 400.00, new DateTime(2018,4, 25), new DateTime(2018, 4, 27));
                    Claims Claim2 = new Claims(2, ClaimType.Home, "House fire in Kitchen", 4000.00, new DateTime(2018,4,11), new DateTime(2018,4,12));
                    Claims Claim3 = new Claims(3, ClaimType.Theft, "Stolen Pancakes", 4.00, new DateTime(2018,4,27),new DateTime(2018,6,1));
                    _claimsList.AddClaimToList(Claim1);
                    _claimsList.AddClaimToList(Claim2);
                    _claimsList.AddClaimToList(Claim3);
                }
    }
}
