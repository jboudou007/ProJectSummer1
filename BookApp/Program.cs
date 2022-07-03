/* Jean Bilong */







//This is the Main Menu. It repeats the code when user press wrong input

using ProjectLib;

Book Book1 = new(); //Initiating the default taxrate and the 3 Books then passing it into the Main Menu
Book Book2 = new();
Book Book3 = new(); 
TaxRate DefaultRate = new(); 
MainMenu(DefaultRate, Book1, Book2, Book3);




    bool showMenu = true;
    while (showMenu)
    {
        showMenu = MainMenu(DefaultRate, Book1, Book2, Book3);
    }




static bool MainMenu(TaxRate defaultRate, Book Book1, Book Book2, Book Book3)
{
    Console.WriteLine($"1 - Enter the details about book 1");
    Console.WriteLine($"2 - Enter the details about book 2");
    Console.WriteLine($"3 - Enter the details about book 3");
    Console.WriteLine($"4 - Remove book 1 details");
    Console.WriteLine($"5 - Remove book 2 details");
    Console.WriteLine($"6 - Remove book 3 details");
    Console.WriteLine($"7 - Show all books");
    Console.WriteLine($"8 - Set the tax rate (current: {defaultRate.Rate.ToString("0.00%")} )"); //while Calling the default Tax Rate
    Console.WriteLine($"9 - Exit");
    Console.WriteLine($"Please make a choice:");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine($"Please Enter Title about Book 1");
            string? TitleBook1 = Convert.ToString(Console.ReadLine());
            if (TitleBook1 == null || TitleBook1 == string.Empty)
            {
                Console.WriteLine($"Title cannot be blank!");
                Thread.Sleep(3000);                         //Will pause the code for 3 seconds before kicking the user back to step one
                goto case "1";
            }
            
            Console.WriteLine($"Please Enter the Price of Book 1");
            double Cost1 = Convert.ToDouble(Console.ReadLine());
            while (Cost1 <= 0 || Cost1 >= 9999)
            {
                Console.WriteLine($"The cost must be between 0 and 9999!");
                Thread.Sleep(3000);                         //Will pause the code for 3 seconds before forcing the user to re-enter the cost
                Console.WriteLine($"Please enter the cost once again");

                Cost1 = Convert.ToDouble(Console.ReadLine());


            }

            Book1.Title = TitleBook1;
            Book1.Cost = Cost1;

            return true;

            
        
        case "2":
            Console.WriteLine($"Please Enter Title about Book 2");
            string? TitleBook2 = Convert.ToString(Console.ReadLine());
            if (TitleBook2 == null || TitleBook2 == string.Empty)
            {
                Console.WriteLine($"Title cannot be blank!");
                Thread.Sleep(3000);                         //Will pause the code for 3 seconds before kicking the user back to step one of case 2
                goto case "2";
            }

            Console.WriteLine($"Please Enter the Price of Book 2");
            double Cost2 = Convert.ToDouble(Console.ReadLine());
            while (Cost2 <= 0 || Cost2 >= 9999)
            {
                Console.WriteLine($"The cost must be between 0 and 9999!");
                Thread.Sleep(3000);                         //Will pause the code for 3 seconds before forcing the user to re-enter the cost
                Console.WriteLine($"Please enter the cost once again");

                Cost2 = Convert.ToDouble(Console.ReadLine());


            }

            Book2.Title = TitleBook2;
            Book2.Cost = Cost2;

            return true;

       
         case "3":
            Console.WriteLine($"Please Enter Title about Book 3");
            string? TitleBook3 = Convert.ToString(Console.ReadLine());
            if (TitleBook3 == null || TitleBook3 == string.Empty)
            {
                Console.WriteLine($"Title cannot be blank!");
                Thread.Sleep(3000);                         //Will pause the code for 3 seconds before kicking the user back to step one of case 3
                goto case "3";
            }

            Console.WriteLine($"Please Enter the Price of Book 3");
            double Cost3 = Convert.ToDouble(Console.ReadLine());
            while (Cost3 <= 0 || Cost3 >= 9999)
            {
                Console.WriteLine($"The cost must be between 0 and 9999!");
                Thread.Sleep(3000);                         //Will pause the code for 3 seconds before forcing the user to re-enter the cost
                Console.WriteLine($"Please enter the cost once again");

                Cost3 = Convert.ToDouble(Console.ReadLine());


            }

            Book3.Title = TitleBook3;
            Book3.Cost = Cost3;

            return true;

        case "4":
            Console.WriteLine($"You are removing '{Book1.Title}'");
            Console.WriteLine($"Press 'Y' to remove or 'N' to not remove");
            string? answer = Convert.ToString(Console.ReadLine());
            if (answer == "n" || answer == "N") 
            {
                Console.WriteLine($"The Book was not removed");
                Thread.Sleep(3000);
                return true;
            }
            if (answer == "y" || answer == "Y") 
            {
                Book1.RemoveBook();
                Console.WriteLine($"The Book was removed");
                return true;
            }
            else
            {
                Console.WriteLine($"Please enter y or n");
                goto case "4";
            }

        case "5":
            Console.WriteLine($"You are removing '{Book2.Title}'");
            Console.WriteLine($"Press 'Y' to remove or 'N' to not remove");
            string? answer2 = Convert.ToString(Console.ReadLine());
            if (answer2 == "n" || answer2 == "N")
            {
                Console.WriteLine($"The Book was not removed");
                Thread.Sleep(3000);
                return true;
            }
            if (answer2 == "y" || answer2 == "Y")
            {
                Book2.RemoveBook();
                Console.WriteLine($"The Book was removed");
                return true;
            }
            else
            {
                Console.WriteLine($"Please enter y or n");
                goto case "5";
            }

        case "6":
            Console.WriteLine($"You are removing '{Book3.Title}'");
            Console.WriteLine($"Press 'Y' to remove or 'N' to not remove");
            string? answer3 = Convert.ToString(Console.ReadLine());
            if (answer3 == "n" || answer3 == "N")
            {
                Console.WriteLine($"The Book was not removed");
                Thread.Sleep(3000);
                return true;
            }
            if (answer3 == "y" || answer3 == "Y")
            {
                Book3.RemoveBook();
                Console.WriteLine($"The Book was removed");
                return true;
            }
            else
            {
                Console.WriteLine($"Please enter y or n");
                goto case "6";
            }



        case "7":
            if (Book1.Title == string.Empty && Book2.Title == string.Empty && Book3.Title == string.Empty)
            {
                Console.WriteLine($"There is no Book");
                Thread.Sleep(2000);
            }
            else
            Console.WriteLine();
            Console.WriteLine($"Book1: {Book1}");
            Console.WriteLine($"Book2: {Book2}");
            Console.WriteLine($"Book3: {Book3}");   

            double TotalTax = Book1.Tax(defaultRate) + Book2.Tax(defaultRate) + Book3.Tax(defaultRate);  //Total Tax
            double TotalCostOFBook = Book1.Cost + Book2.Cost + Book3.Cost;                               //Total cost without tax
            double TotalCostPlusTax = TotalCostOFBook + TotalTax;                                        //Total cost with tax

            Console.WriteLine($"Total Cost:       {TotalCostOFBook.ToString("C")} ");
            Console.WriteLine($"Total tax:        {TotalTax.ToString("C")}");
            Console.WriteLine($"Total Cost + Tax: {TotalCostPlusTax.ToString("C")}");
            Console.WriteLine();
            Console.WriteLine($"Press enter to go back to main menu");
            string? MainMenuKey = Convert.ToString(Console.ReadLine());       // Any key will let the user back to the main menu
            
            
            
            return true ;


        case "8":
            Console.WriteLine($"Current Tax rate: {new TaxRate().Rate.ToString("0.00%")}");
            Console.WriteLine($"Enter the new tax rate");
            double NewTaxRate = Convert.ToDouble(Console.ReadLine());
            while(NewTaxRate <= 0 || NewTaxRate >= 1)
            {
                Console.WriteLine("Please enter a value from 0 to 1 inclusive");
                Thread.Sleep(3000);
                goto case "8";
            }
            defaultRate.UpdateRate(NewTaxRate); // Calling the updateRate method 
            Console.WriteLine($"The tax rate was changed.");

            return true;
            






        case "9":
            Console.WriteLine($"Do you want to exit? Press Enter");
            return false;

        

        default:
            Console.WriteLine($"Only choice from 1 to 9 are available");   //Default case for invalid choice
            return true;
    }
}

    






