namespace _2024IntroEmne3b
{
    internal class Program
    {
        // function Main(args)
        static void Main(string[] args) 
        {
            string name = MyConsole.Ask("Hva heter du? ");
            string birthYearStr = MyConsole.Ask("I hvilket år er du født? ");
            int birthYear = Convert.ToInt32(birthYearStr);
            int age = 2024 - birthYear;
            string answer = MyConsole.Ask("Har du hatt bursdag i år (j/n)? ");
            char letter = answer[0];
            if (letter == 'n')
            {
                age--;
            }

            Console.WriteLine($"Hei, {name}!");
            Console.WriteLine($"Du er {age} år gammel.");
        }
    }
}
