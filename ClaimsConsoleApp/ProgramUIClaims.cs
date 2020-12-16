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
         ClaimsRepo _claimsRepo = new ClaimsRepo();
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
                                    "2.Update Claim:\n" +
                                    "3.Enter a new Claim:\n" +
                                    "4.View next Claim In the Queue:\n" +
                                    "5.Exit:");
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
                        ViewNextClaimInTheQueue();
                        break;
                    case "5":
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
        public void DisplayClaims(Claims content)
        {
            Console.WriteLine($"{content.ClaimId,-15} {content.ClaimAmount,-10} {content.Description,-30}{content.ClaimAmount,-10} {content.DateOfIncident.ToShortDateString(),-15} {content.DateOfClaim.ToShortDateString(),-28} {content.IsValid}");

        }
        public void ViewNextClaimInTheQueue()
        {
            Console.WriteLine("ClaimId\t\t Type\t\t Description\t\t Amount\t\t DateOfAccident\t\t DateOfClaim\t\t IsValid\t\t");
            DisplayClaims(_claimsRepo.ClaimFromTopOfQueue());
            Console.WriteLine("Do you want to Deal with the Next Claim in the Queue?(y/n)");
            string input = Console.ReadLine();
            while(true)
            {
                switch (input.ToLower())
                {
                    case "y":
                        _claimsRepo.RemoveClaimFromQueue();
                        break;
                    case "n":
                        return;
                        
                }
            }
        }
        public void GetClaims()
        {
            Console.Clear();
            Console.WriteLine("ClaimId\t\t Type\t\t Description\t\t Amount\t\t DateOfAccident\t\t DateOfClaim\t\t IsValid\t\t");

            Queue<Claims> claims = _claimsRepo.GetClaims();
            {
                foreach (Claims claim in claims)
                {
                    DisplayClaims(claim);
                }
            }
        }
        ///trying to make rows and columns
        //if (_claimsList.Count == 1000)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable.Columns.Add("Log");
        //    foreach (var log in _claimsList)
        //    {
        //        DataRow dr = dataTable.NewRow();
        //        dr["Log"] = log;
        //        dataTable.Rows.Add(dr);
        //    }
        //    _claimsList.Clear();
        //    SendBulkData(dataTable);
        //}

        private ClaimType GetClaimType()
        {
            Console.WriteLine("Enter the Claim Type: \n" +
                "1. Car \n" +
                "2. Home \n" +
                "3. Theft ");

            while (true)
            {
                int claimString = int.Parse(Console.ReadLine());

                if (claimString >= 1 && claimString <= 3)
                {
                    ClaimType claimType = (ClaimType)claimString;
                    return claimType;
                }

                Console.WriteLine("Invalid selection. Please try again.");
            }
        }


        public void UpdateClaim()
        {
            
            
            Console.WriteLine("Enter the Claim Id:");
            int claimId = int.Parse(Console.ReadLine());
            ClaimType claimType = GetClaimType();
            Console.WriteLine("Enter the Claim Description:");
            string description = Console.ReadLine();
            Console.WriteLine("Amount of Damage");
            string amountAsString = Console.ReadLine();
            double claimAmount = double.Parse(amountAsString);
            Console.WriteLine("Date of Incident:(yyyy/mm/dd)");
            DateTime dateOfIncident = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Date of Claim:(yyyy/mm/dd)");
            DateTime dateOfClaim = DateTime.Parse(Console.ReadLine());
            Claims updatedClaim = new Claims(claimId, claimType, description, claimAmount, dateOfIncident, dateOfClaim);

            _claimsRepo.UpdateClaim(updatedClaim.ClaimId, updatedClaim);

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
            Console.WriteLine("Date of Incident(yyyy/mm/dd)");
            newClaim.DateOfIncident = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Date of Claim(yyyy/mm/dd)");
            newClaim.DateOfClaim = DateTime.Parse(Console.ReadLine());
            Console.ReadKey();
            _claimsRepo.AddClaimToList(newClaim);
            Console.WriteLine("You have added a new Claim to the Queue");
            Console.ReadLine();
        }
        private void SeeClaims()
        {
            Claims Claim1 = new Claims(1, ClaimType.Car, "Car Accident on 465", 400.00, new DateTime(2018, 4, 25), new DateTime(2018, 4, 27));
            Claims Claim2 = new Claims(2, ClaimType.Home, "House fire in Kitchen", 4000.00, new DateTime(2018, 4, 11), new DateTime(2018, 4, 12));
            Claims Claim3 = new Claims(3, ClaimType.Theft, "Stolen Pancakes", 4.00, new DateTime(2018, 4, 27), new DateTime(2018, 6, 1));
            _claimsRepo.AddClaimToList(Claim1);
            _claimsRepo.AddClaimToList(Claim2);
            _claimsRepo.AddClaimToList(Claim3);
        }
    }
}
