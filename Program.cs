namespace RegexPrograms
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Regex Problems Master Branch.");

            Patternmatch pattern = new Patternmatch();

            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();
            bool val = pattern.validate(name);

            if (val)
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name!");
            }
        }
    }
}