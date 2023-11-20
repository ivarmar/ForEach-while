namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string userInput = Console.ReadLine();
            
            Console.Write("Reversed string: ");
            for (int i = userInput.Length -1; i >= 0; i--) 
            {
                Console.Write(userInput[i]);
            }



            //
            
            
            int rundenummer = 0;

            while (rundenummer < 11)
            {
                Console.WriteLine($"Runde nummer: {rundenummer}/10 ");
                rundenummer++;
            }

            


        }
    }
}