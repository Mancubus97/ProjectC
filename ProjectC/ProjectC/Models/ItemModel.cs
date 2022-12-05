namespace ProjectC.Models
{
	public record Item(Guid id, string name, string description, double price, int amount, double implementCosts
   , double personelSavings, int hoursSavings, int implementHours)
	{ } //A Guid is like an int. Was recommended by a teacher to use for ID's.



}
