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
            double money, avg;
            string lastName;
            int grade;
            Double ID;




            Console.WriteLine(" Hello! What is your name");
            name = Console.ReadLine();
            Console.WriteLine(" Your name is " + name);

            Console.WriteLine(" Hi " + name + (" how old are you?"));
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));
            Console.WriteLine(" So you're " + age + (" years old huh "));
            Console.WriteLine(" So how much money do you make " + name + (" who's ") + age + (" years old "));
            Console.WriteLine(double.TryParse(Console.ReadLine(),out money));
            Console.WriteLine(" so you make " + money.ToString("C"));
            Console.WriteLine(" hope thats every hour XD");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();


            
            Console.WriteLine(" please enter the following so I can sell in online ");
            Console.WriteLine();
            Console.Clear();
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




        }
    }
}
