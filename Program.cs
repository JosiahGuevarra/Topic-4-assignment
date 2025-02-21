namespace Topic_4_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();

            string name, login;
            int age;
            double money, avg, num1, num2, num3, price1, price2, discount, finalDiscount, tax, tax2;
            string lastName,item1, item2;
            int grade;
            Double ID;

            discount = .20;
            tax = 1.13;
            tax2 = .13;


            Console.WriteLine(" Hello! What is your name");
            name = Console.ReadLine();
            Console.WriteLine(" Your name is " + name);

            Console.WriteLine(" Hi " + name + (" how old are you?"));
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));
            Console.WriteLine(" So you're " + age + (" years old huh "));
            Console.WriteLine(" So how much money do you make " + name + (" who's ") + age + (" years old "));
            Console.WriteLine(double.TryParse(Console.ReadLine(), out money));
            Console.WriteLine(" so you make " + money.ToString("C"));
            Console.WriteLine(" hope thats every hour XD");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();



            Console.WriteLine(" please enter the following so I can sell in online ");
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("(Part 2)");
            Console.WriteLine(" please enter the following so I can sell in online ");
            Console.WriteLine();


            Console.WriteLine(" please enter your first  name ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(" please enter your last name ");

            lastName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(" What Grade are you in? ");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out grade));
            Console.WriteLine();
            Console.WriteLine(" what is your student ID? ");
            Console.WriteLine(Double.TryParse(Console.ReadLine(), out ID));
            Console.WriteLine();
            Console.WriteLine(" please enter your login ");
            login = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(" please enter your grade avarage ");
            Console.WriteLine(Double.TryParse(Console.ReadLine(), out avg));
            Console.WriteLine(" WOW! its really that low ");



            Console.WriteLine(" your information is: ");
            Console.WriteLine("Login: \t\t" + login);
            Console.WriteLine("ID: \t\t" + ID);
            Console.WriteLine("Name: \t\t" + name);
            Console.WriteLine("Avarage:\t" + avg);
            Console.WriteLine("Grade: \t\t" + grade);
            Console.WriteLine("say goodbye to this, its going to China ");




            Console.WriteLine();
            Console.WriteLine("(Part 3)");
            Console.WriteLine("Sorry for asking so many times, but what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi " + name + ("!") + (" How old are you?"));
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));
            Console.WriteLine("Wow, did you know in 5 years you will be " + (age + 5) + ("!"));
            Console.WriteLine(" and 5 years ago you were " + (age - 5) + ("!"));


            Console.WriteLine(" (Part 4)");
            Console.WriteLine("I going to add any three numbers you give me");
            Console.WriteLine();
            Console.WriteLine("Give me number 1");
            Console.WriteLine(Double.TryParse(Console.ReadLine(), out num1));
            Console.WriteLine();
            Console.WriteLine(" Okay, give me number 2");
            Console.WriteLine(Double.TryParse(Console.ReadLine(), out num2));
            Console.WriteLine();
            Console.WriteLine("Okay, give me the final number");
            Console.WriteLine(Double.TryParse(Console.ReadLine(), out num3));
            Console.WriteLine();
            Console.WriteLine("Okay, the sum total of those numbers is " + (num1 + num2 + num3));


            Console.WriteLine("(Part 5)");
            Console.WriteLine();
            Console.WriteLine("Hello, What is item1 ");
            item1 = Console.ReadLine();
            Console.WriteLine(" how much did item one cost?");
            Double.TryParse(Console.ReadLine(), out price1);
            Console.WriteLine(" what is item 2?");

            item2 = Console.ReadLine();
            Console.WriteLine("How much did item 2 cost?");
            Double.TryParse(Console.ReadLine(), out price2);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Sales Receipt ");
            Console.WriteLine();
            Console.WriteLine(" Item 1: \t" + (item1));
            Console.WriteLine(" Price: \t" + price1);
            Console.WriteLine(" Item 2: \t" + (item2));
            Console.WriteLine(" price: \t" + price2);
            Console.WriteLine("-------------------------");
            Console.WriteLine(" Total: \t" + (price1 + price2));
            Console.WriteLine(" Discount: (20%):" + (price1 + price2) * discount);
            finalDiscount = (price1 + price2) - (price1 + price2) * discount;
            Console.WriteLine(" Subtotal: \t" +  finalDiscount);
            Console.WriteLine(" tax  (.13): \t" + (price1 + price2) * tax2);
            Console.WriteLine("----------------------------");
            Console.WriteLine(" Total owed: \t" + finalDiscount * tax);
            
            
            


            
                      
            
            
            
            
          
            
            



            

        }
    }
}
