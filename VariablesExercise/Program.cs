namespace VariablesExercise
{
    public class Program
    {
        static void StoryCreation(){

            string characterName, favoriteMovie, favoritePower, decision;

            Console.WriteLine("Want to create a story with me?");
            decision = Console.ReadLine();

            if (decision.ToLower() == "yes" || decision.ToLower() == "y")
            {
                Console.WriteLine("Alright, let's begin.");
            } else {
                Console.WriteLine("It's okay, I'll make it painless, let's start.");
            }

            Console.WriteLine("Let's begin with a simple one. What is the name of your favorite Character?");
            characterName = Console.ReadLine();

            Console.WriteLine("Nice! Now, what is your favorite movie?");
            favoriteMovie = Console.ReadLine();

            Console.WriteLine("Nice! Almost Done! What is your favorite super power?");
            favoritePower = Console.ReadLine();

            Console.WriteLine($"Perfect! This is how I imagine you. As {characterName}, the hero of {favoriteMovie} saving everyone with your amazing {favoritePower} power");
        }
        static void Main(string[] args)
        {
             string exampleString = "Example";
             int exampleInt = 123;
             char exampleChar = 'C';
             bool exampleBool = true;
             double exampleDouble = 1234234234.09;
             decimal exampleDecimal = 3.34m;

             Console.WriteLine($"These are examples of declaration and initialization of variables: {exampleString} and {exampleInt}");
             StoryCreation();
        }
    }
}
