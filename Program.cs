namespace RegexPrograms
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Regex Problems Master Branch.");

            Patternmatch pattern = new Patternmatch();

            Console.WriteLine("Enter your Last Name: ");
            string name = Console.ReadLine();
            bool val = pattern.validate(name);

            if (val)
            {
                Console.WriteLine("Valid last name");
            }
            else
            {
                Console.WriteLine("Invalid last name!");
            }
        }
    }
}