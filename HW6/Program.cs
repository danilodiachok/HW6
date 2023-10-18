namespace HW6
{
    internal class Program
    {

        static int ReadNumber(int start, int end)
        {
            Console.Write($"Enter a number between {start} and {end}: ");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number >= start && number <= end)
                {
                    return number;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Number is not within the specified range.");
                }
            }
            else
            {
                throw new FormatException("Invalid input. Please enter a valid integer.");
            }
        }



        static void Main(string[] args)
        {
            
            int start = 1;
            int end = 100;
            int previousNumber = start - 1;
            int[] numbers = new int[10];

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Enter a number (a{i}): ");
                
                try
                {
                    int number = ReadNumber(previousNumber + 1, end);
                    previousNumber = number;
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                    i--; 
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                    i--; 
                }

                
            }
            
            Console.WriteLine("Valid numbers entered successfully.");



          
        }
    
    }
}