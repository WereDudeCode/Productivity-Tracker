
double ProductiveHours = 0;
double UnproductiveHours = 0;

        //Title
        Console.WriteLine("Welcome to the productivity tracker");
    
    while (true)
    {
        //Enter time type
        Console.WriteLine("Please enter your time type");
        Console.WriteLine(" 1. Productive");
        Console.WriteLine(" 2. Unproductive");
        Console.WriteLine(" 3. Show hours");
        Console.WriteLine(" 4. Exit");
        int TypeEntry = int.Parse(Console.ReadLine());

    
    
        //Switch statement with entry options
        switch(TypeEntry)
        {
            case 1:
                Console.WriteLine("Please enter your productive time");
                var ProductiveTime = Convert.ToDouble(Console.ReadLine());
                ProductiveHours += ProductiveTime;
                Console.WriteLine("Your productive hours accrued are: " + ProductiveHours);
                break;
            
            case 2:
                Console.WriteLine("Please enter your unproductive time. You lazy bum");
                var UnproductiveTime = Convert.ToDouble(Console.ReadLine());
                UnproductiveHours += UnproductiveTime;
                Console.WriteLine("Your unproductive hours accrued are: " + UnproductiveHours);
                break;
            
            case 3:
                Console.WriteLine("Productive hours accrued: " + ProductiveHours);
                Console.WriteLine("Unproductive hours accrued: " + UnproductiveHours);
                break;

            case 4:
            if (ProductiveHours > UnproductiveHours)
            {
                Console.WriteLine("You had a productive day!");
            }
            else
            {
                Console.WriteLine("You did not have a productive day...");
            }
                
                return;
                

            default:
                Console.WriteLine("Please enter a valid number");
                break;
        }
        
    }







