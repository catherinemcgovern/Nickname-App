using System;

namespace Nickname
{
    class Program
    {
        static void Main()
        {
            int choice;
            bool validChoice;

            //first we have the user select if they want to create a nickname or quit

            do // inner do...while loop is to keep looping until the user picks a valid menu selection
            {
                Console.Write("-----------------------------------------");
                validChoice = true;
                Console.Write("\nPlease make a selection: ");
                Console.Write("\n Type 1 to make a new nickname ");
                Console.WriteLine("\n Type 2 to quit");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: // User opts to create a nickname and the method is started to begin that process
                            CreateName();
                            break;
                        case 2: // User decides they want to quit
                            QuitName();
                            break;
                        default:
                            validChoice = false;
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    // This try...catch block catches the FormatException that Convert.ToInt32 will throw 
                    // if the user inputs text or something that cannot be converted to an integer.
                    validChoice = false;
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            } while (validChoice == false); // Inner loop ends when validChoice is true
        }



        static void QuitName()
        {
            //This method ends the game
            Console.WriteLine("Quitting...");
        }


        //The random method below creates a new random number object that we can use to select the nickname for the user
        static Random random = new Random();

        static void CreateName() // This is a methhod to create the nickname
        {

            int x = 0;
            int y = 0;


            Console.WriteLine("Please enter a name that needs a nickname");
            string firstName = (Console.ReadLine());

            string[] arrayOfStrings = { "Nice", "Cool", "Brave" };



            Console.WriteLine("How would you describe this person - please enter a number from the list below");

            for (int i = 1; i < arrayOfStrings.Length + 1; i++)
            {
                Console.WriteLine(" Option {0}: {1}", i, arrayOfStrings[i - 1]);
            }


            //the random number will be used to select one of the words within each "adjective set"

            string[,] attributeGroups = new string[3, 6] {
        { "sweet", "kind", "virtuous", "generous", "friendly", "good" },
        { "rad", "super", "suave", "trendy", "neato", "hip" },
        { "daring", "bold", "intrepid" , "impetuous" , "courageous" , "expeditious" }};


            bool enValidChoice;

            do // inner do...while loop is to keep looping until the user picks a valid menu selection
            {
                enValidChoice = true;


                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    switch (x)
                    {
                        case 1: // User wants the nickname to evoke the word "nice"
                            break;
                        case 2: // User wants the nickname to evoke the word "cool"
                            break;
                        case 3: // User wants the nickname to evoke the word "groovy"
                            break;
                        default:
                            enValidChoice = false;
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    // This try...catch block catches the FormatException that Convert.ToInt32 will throw 
                    // if the user inputs text or something that cannot be converted to an integer.
                    enValidChoice = false;
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            } while (enValidChoice == false);




            y = random.Next(0, 6);

            Console.WriteLine("The new nickname is {0} the {1}", firstName, attributeGroups[x - 1, y]);
            Console.WriteLine("Hooray!");
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");


            Main();

        }




    }

}
