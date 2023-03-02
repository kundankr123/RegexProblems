namespace RegexPrograms
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Regex Problems Master Branch.");

            Patternmatch pattern = new Patternmatch();

            Console.WriteLine("Enter your email id: ");
            string name = Console.ReadLine();
            bool val = pattern.validate(name);

            if (val)
            {
                Console.WriteLine("Valid email id.");
            }
            else
            {
                Console.WriteLine("Invalid email id.");
            }
        }
    }
}