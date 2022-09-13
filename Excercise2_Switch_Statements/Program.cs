namespace Excercise2_Switch_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shows the Game Menu
            Console.WriteLine("**************\n");
            Console.WriteLine("Menu: \n");
            Console.WriteLine("1 - New Game\n");
            Console.WriteLine("2 - Load Game\n");
            Console.WriteLine("3 - Options\n");
            Console.WriteLine("4 - Quit\n");
            Console.WriteLine("**************\n");

            //Asks the user to enter the option
            Console.WriteLine("Option: ");
            int userOption = int.Parse(Console.ReadLine());

            //Shows the correct message depending on the user choice
            switch (userOption) {
                case 1:
                    Console.WriteLine("Starting game ...\n");
                    break;
                case 2:
                    Console.WriteLine("Loading game ...\n");
                    break;
                case 3:
                    Console.WriteLine("Options\n");
                    break;
                case 4:
                    Console.WriteLine("Quitting game ...\n");
                    break;
                default:
                    Console.WriteLine("Not a correct option!\n");
                    break;
            }
            
            //Next line is used to show the result to the user
            Console.ReadLine();
        }
    }
}