using System.Reflection.Metadata;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Guess my favorite number, from 1-1000"!);
            int guess = int.Parse(Console.ReadLine());

            if (guess < favNumber)
            {
                Console.WriteLine("too low");
            }         
            else if (guess > favNumber)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("You guessed it!!!");
            }

            //Exercise 2

            Console.WriteLine("What was your favorite school subject ?");
            string favSubject = Console.ReadLine(); 

            switch (favSubject.ToLower())
            {
                case "english":
                    Console.WriteLine("I loved english!");
                    break;
                case "history":
                    Console.WriteLine("I didn't mind history.");
                    break;
                case "math":
                    Console.WriteLine("Yea, I also enjoyed math");
                    break;
                case "science":
                    Console.WriteLine("Science really annoyed me");
                    break;
                case "art":
                    Console.WriteLine("Yea art was really fun!");
                    break;
                default:
                    Console.WriteLine("I didn't take that subject");
                    break;
            }

                






        }
    }
}
