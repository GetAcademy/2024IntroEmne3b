namespace _2024IntroEmne3b
{
    internal class MyConsole
    {
        public static string Ask(string question)
        {
            Console.Write(question);
            string answer = Console.ReadLine();
            return answer;
        }
    }
}
