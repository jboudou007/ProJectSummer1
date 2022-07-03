namespace ProjectLib
{
    public class Book
    {
        
        public string Title { get; set; } = String.Empty;

        public double Cost { get; set; } = 0;
          
        public double Tax(TaxRate taxrate) //This is the Dependency Relationship from book to tax rate
        {
            return taxrate.Rate * Cost;

        }

        public double CostWithTax(TaxRate taxrate)
        {
            return (taxrate.Rate * Cost) + Cost;    
        }

        public void RemoveBook()  //This Method will be called to remove the books
        {
            Title = String.Empty;
            Cost = 0;
        }




        public Book() 
        {
            
        }
            
                                  
        public Book(string title, double cost)
        {
            this.Title = title;
            this.Cost = cost;
            
        }

        public override string ToString()
        {
            if (Title == String.Empty) { return $"No Book"; }
            return $"{Title}, {Cost.ToString("C")}";
            
        }
    }

    
}