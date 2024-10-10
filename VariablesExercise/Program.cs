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

        static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static int Subtract(params int[] numbers)
        {
            int diff = 0;
            foreach (int number in numbers)
            {
                diff -= number;
            }
            return diff;
        }

        static int Multiply(params int[] numbers)
        {
            int product = 0;
            foreach (int number in numbers)
            {
                product *= number;
            }
            return product;
        }

        static int Divide(params int[] numbers)
        {
            int divisionResult = 0;
            foreach (int number in numbers)
            {
                divisionResult /= number;
            }
            return divisionResult;
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

            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine();

            // Split the input and convert to an array of integers
            int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);

            int sumResult = Add(numbers);
            Console.WriteLine("Sum: " + sumResult);

            int diffResult = Subtract(numbers);
            Console.WriteLine("Difference: " + diffResult);

            int productResult = Multiply(numbers);
            Console.WriteLine("Product: " + productResult);

            int divisionResult = Divide(numbers);
            Console.WriteLine("Division: " + divisionResult);
        }
    }
}

//I would appreciate some advise on my mulpitly and divide methods. I think I have the right idea, the problem is that the initial value cannot be 0.
