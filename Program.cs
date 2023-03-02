namespace RegexPrograms
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Regex Problems Master Branch.");

            Patternmatch pattern = new Patternmatch();

            Console.WriteLine("Enter your phone number: ");
            string name = Console.ReadLine();
            bool val = pattern.validate(name);

            if (val)
            {
                Console.WriteLine("Valid phone number.");
            }
            else
            {
                Console.WriteLine("Invalid phone number.");
            }
        }
    }
}