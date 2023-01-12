namespace ProjectC.Models
{

	public class Innovation
	{
		public Guid id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public double price { get; set; }
		public int amount { get; set; }
		public double implementCosts { get; set; }
		public double personelSavings { get; set; }
		public int hoursSavings { get; set; }
		public int implementHours { get; set; }
		public double sroi { get; set; }


		public Innovation()
		{
		}
			public Innovation(Guid id, string name, string description, double price, int amount, double implementCosts
	   , double personelSavings, int hoursSavings, int implementHours, double sroi)
		{ 
			this.id = id;
			this.name = name;
			this.description = description;
			this.price = price;
			this.amount = amount;
			this.implementCosts= implementCosts;
			this.personelSavings = personelSavings;
			this.hoursSavings = hoursSavings;
			this.implementHours = implementHours;
			this.sroi = sroi;
		
		} 
	}

		

    
}
