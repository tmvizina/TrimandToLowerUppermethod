using System;

namespace StringMethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Trim Method Practice");

            //Trim takes a string and removes all whitespace from the outside of a string, it also automatically determines inside whitespace versus outside whitespace


            // These intializes to showcase whitespace outside and inside of a string as well as and syntax of .Trim()
           

            string message = "           (     The        )         ";

            string trimmedmessage = message.Trim();



            //These print out both the original string and the trimmed string into the console output
            Console.WriteLine("Message is {0}",message);
            Console.WriteLine("Whitespace removed message is {0}",trimmedmessage);
        }


        //This is an unreferenced method showcasing how you would set up and a user input method using the ToLower method
        //This takes user input as a string type and forces alls chars in the string to lowercase
        public static string GetUserInputLower(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToLower();
            return input;
        }



        //This is an unreferenced method showcasing how you would set up and a user input method using the ToUpper method
        //This takes user input as a string type and forces alls chars in the string to uppercase
        public static string GetUserInputUpper(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToUpper();
            return input;
        }

    }
}
