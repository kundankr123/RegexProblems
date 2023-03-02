namespace RegexPrograms
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Regex Problems Master Branch.");

            Patternmatch pattern = new Patternmatch();

            Console.WriteLine("Enter your password: ");
            string name = Console.ReadLine();
            bool val = pattern.validate(name);

            if (val)
            {
                Console.WriteLine("Valid password.");
            }
            else
            {
                Console.WriteLine("Invalid password.");
            }
        }
    }
}