using InterviewQuestions;

internal class Program
{
    private static void Main(string[] args)
    {
        InterviewGame game = new InterviewGame();

        bool keepRunning = true;
        while (keepRunning)
        {
            string randomQuestion = game.GetRandomQuestion();

            Console.WriteLine(randomQuestion);
            Console.WriteLine();
            Console.WriteLine("Press any key to see the answer. ");
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.Q)
            {
                keepRunning = false;
            }
            else
            {
                Console.Clear();
                string answer = game.GetAnswer(randomQuestion);
                Console.WriteLine(answer);
                Console.WriteLine();
                Console.WriteLine("Press any key for another question. Otherwise press Q to quit");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Q)
                {
                    keepRunning = false;
                }
                Console.Clear();
            }
        }
    }
}