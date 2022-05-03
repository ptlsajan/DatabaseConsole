using DatabaseConsole.Models;
using DatabaseConsole.Data;
using Microsoft.EntityFrameworkCore;


Console.WriteLine("Connecting to database!!");
using DatabaseContext context = new DatabaseContext();

//var trans = context.Customers.Include(t => t.Transcations);

/*

//--------------------------------------------------------------------------------------

// get the transcation and customer as foreign key

var c = context.Customers.Include("Transcations").Where(c => c.CustomerId == 4).ToList();

foreach (var item in c)
{
    foreach (var t in item.Transcations)
    {
        Console.WriteLine($"" 
            + $"\nCustomer id : {item.CustomerId}"
            + $"\nForegin keyid : {t.CustomerId}"
            + $"\nCustomer name : {item.Name}" 
            + $"\nCrop : {t.Crop}" 
            + $"\nField : {t.Field}" 
            + $"\nStart time : {t.StartTime}"
            + $"\nEnd time: {t.EndTime}"
            + $"\nTotal hours: {t.TotalHours}");
        Console.WriteLine("------------------------------------------");
    }
}

//---------------------------------------------------------------------------------------

*/

var getCust = context.Customers.Where(x => x.Id == 1).ToList();
var getRate = context.Rates.Where(r => r.Price == r.Price).ToList();
var getField = context.FieldDetails.Where(x => x.Field == "Charo").ToList();
var getCrop = context.CropDetails.Where(x => x.Crop == "Rice").ToList();
decimal totalHour = 2;


//---------------------------------------------------------------------------------------

// insert into transcation using customer foreign key

var trans = new Transcation();

trans = new Transcation()
{
    StartHour = "12:30",
    EndHour = "14:30",
    TotalHours = 2,
    PriceT = totalHour * getRate[0].Price,
    PriceP = 0,
    CustomerId = getCust[0].Id,
    CropDetailId = getCust[0].Id,
    RateId = getRate[0].Id,
    FieldDetailId = getField[0].Id,
    PaidStatuss = new List<PaidStatus>(){
        new PaidStatus()
        {
            Status = "unpaid"
        }
    },
    
};



var cust = context.Customers.First(x => x.Id == 1);
cust.TotalAmount += trans.PriceT;


context.Add(trans);
context.SaveChanges();
Console.WriteLine("Saved to database!!");

//---------------------------------------------------------------------------------------





//---------------------------------------------------------------------------------------
// update query for the transcation


/*


*/

//---------------------------------------------------------------------------------------



/*
 
//---------------------------------------------------------------------------------------
// insert into customer

Customer customer = new Customer()
{
    Name = "Sajan",
};

Customer customer1 = new Customer()
{
    Name = "Meshva",
};

Customer customer2 = new Customer()
{
    Name = "Rushil",
};

Customer customer3 = new Customer()
{
    Name = "Prit",
};

context.Add(customer);
context.Add(customer1);
context.Add(customer2);
context.Add(customer3);
context.SaveChanges();
Console.WriteLine("Saved to database!!");

//---------------------------------------------------------------------------------------

*/