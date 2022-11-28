using ProjectC.Models;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();

}



/*public record Innovation(Guid id, string name, string description, double price, int amount, double implementCosts
	   , double personelSavings, int hoursSavings, int implementHours)
{ } //A Guid is like an int. Was recommended by a teacher to use for ID's.

*/



//do data things
var dbContext = new MyDbContext();
//create data
//dbContext.accounts.Add(new Account(Guid.NewGuid(),"superadmin", "Admin321!"));
//dbContext.innovations.Add(new Innovation(Guid.NewGuid(), "incontinentiemateriaal", "incontinentiemateriaal is leuk", 20.50, 10, 10.50, 100.10, 30, 30));
//dbContext.innovations.Add(new Innovation(Guid.NewGdontuid(), "Heupairbag"));
//dbContext.innovations.Add(new Innovation(Guid.NewGuid(), "Zorgrobot"));
//dbContext.innovations.Add(new Innovation(Guid.NewGuid(), "Dwaaldetectie"));
//dbContext.SaveChanges();

//print data
//var allInnovations = from inov in dbContext.innovations
//                     where inov.name.Contains("pair")
//                     select inov;
//var allInnovations = dbContext.innovations.Where(p => p.name.Contains("pai")); //similar to LIKE
//var allInnovations = dbContext.innovations.Where(p => p.name.StartsWith("Heup")); //similar to LIKE
//var allInnovationsTolist = allInnovations.ToList();
//foreach (var inov in allInnovationsTolist)
//{
//    Console.WriteLine(inov.name);
//}




//start the application
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    //pattern: "{controller=Home}/{action=Index}/{id?}");
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();


