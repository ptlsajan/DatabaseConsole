using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConsole.Models;
using DatabaseConsole.Data;
using Microsoft.EntityFrameworkCore;

namespace DatabaseConsole
{
    public class AllQuery
    {
        public void InsertTranscation(DatabaseContext context)
        {
            Console.WriteLine("Enter Customer name you want to add record");
            var customerName = Console.ReadLine();

            Console.WriteLine("Enter start hour in hh");
            var sh = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter start minute in mm");
            var sm = int.Parse(Console.ReadLine());
            Console.WriteLine("AM or PM");
            var sAmPM = Console.ReadLine();

            Console.WriteLine("Enter end hour");
            var eh = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end minute");
            var em = int.Parse(Console.ReadLine());
            Console.WriteLine("AM or PM");
            var eAmPm = Console.ReadLine();
            string startTime = String.Format("{0}:{1} {2}", sh, sm, sAmPM);
            string endTime = String.Format("{0}:{1} {2}", eh, em, eAmPm);
            TimeSpan totalHours = DateTime.Parse(endTime).Subtract(DateTime.Parse(startTime));
            Console.WriteLine("Enter Crop Name");
            var cropName = Console.ReadLine();
            Console.WriteLine("Enter Field Name");
            var fieldName = Console.ReadLine();


            var getCust = context.Customers.Where(x => x.FirstName == customerName).ToList();
            var getRate = context.Rates.Where(r => r.Price == r.Price).ToList();
            var getField = context.FieldDetails.Where(x => x.Field == fieldName).ToList();
            var getCrop = context.CropDetails.Where(x => x.Crop == cropName).ToList();

            var trans = new Transcation();
            trans = new Transcation()
            {
                StartHour = startTime,
                EndHour = endTime,
                TotalHours = (decimal)totalHours.TotalHours,
                PriceT = (decimal)totalHours.TotalHours * getRate[0].Price,
                PriceP = 0,
                CustomerId = getCust[0].Id,
                CropDetailId = getCrop[0].Id,
                RateId = getRate[0].Id,
                FieldDetailId = getField[0].Id,
                PaidStatuss = new List<PaidStatus>(){
                    new PaidStatus()
                    {
                        Status = "unpaid"
                    }
                },
            };

            var cust = context.Customers.First(x => x.FirstName == customerName);
            cust.TotalAmount += trans.PriceT;

            context.Add(trans);
            context.SaveChanges();
            Console.WriteLine("Transcation saved to database!!");
        }

        public void InsertCustomer(DatabaseContext context)
        {
            Console.WriteLine("Enter FirstName :");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter LastName :");
            var lastName = Console.ReadLine();

            if (firstName != null && lastName !=null)
            {
                var customer = new Customer()
                {
                    FirstName = firstName,
                    LastName = lastName
                };
                context.Add(customer);
                context.SaveChanges();
                Console.WriteLine("Customer added to database");
            }
            else
            {
                Console.WriteLine("Please enter first and last name");
            }
        }

        public void DataForTranscation()
        {
            Console.WriteLine("Enter Customer name you want to add record");
            var customerName = Console.ReadLine();
            Console.WriteLine("Enter Start Hour in format (hh:mm)");
            var startHour = Console.ReadLine();
            Console.WriteLine("Enter End Hour in format (hh:mm)");
            var endTime = Console.ReadLine();
            Console.WriteLine("Enter Crop Name");
            var cropName = Console.ReadLine();
            Console.WriteLine("Enter Field Name");
            var fieldName = Console.ReadLine();
        }

    }
}
