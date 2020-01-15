using System;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            // string firstName, lastName, age, month, color, years, balance = "";
            string firstName = "";
            string lastName = "";
            string age = "";
            int ageValue = 0;
            string month = "";
            int monthValue = 0;
            string color = "";
            string years = "";
            string siblings = "";
            int siblingsValue = 0;

            string balance = "";

            bool spellEffect = true;
            do {
                if (firstName == "Quit" || lastName == "Quit" || age == "Quit" || month == "Quit" || color == "Quit") {
                    Console.WriteLine("Nobody likes a quitter...");
                    return;
                }
                Console.WriteLine("What is your first name?");
                firstName = Console.ReadLine();
                Console.WriteLine("What is your last name?");
                lastName = Console.ReadLine();
                Console.WriteLine("How old are you?");
                age = Console.ReadLine();
                ageValue = Convert.ToInt32(age);
                Console.WriteLine("What is your month of birth (as a number)?");
                month = Console.ReadLine();
                monthValue = Convert.ToInt32(month);
                bool colorCheck = false;
                do
                {
                    Console.WriteLine("What is your favorite ROYGBIV color? (Enter 'Help' for a list of ROYGBIV colors.)");
                    color = Console.ReadLine();
                    if (color == "Help")
                    { // implement case sensitivity possibly maybe???
                        Console.WriteLine("R = red, O = orange, Y = yellow, G = green, B = blue, I = indigo, V = violet.");
                    }
                    else colorCheck = true;
                } while (colorCheck == false);

                // char color = Console.ReadKey().KeyChar;
                string vehicle = "";
                Console.WriteLine("How many siblings do you have?");
                siblings = Console.ReadLine();
                siblingsValue = Convert.ToInt32(siblings);

                string location = "";

                // Years until retirement
                if (ageValue % 2 == 0)
                {
                    years = "12";
                }
                else years = "14";

                // Vacation home location
                if (siblingsValue == 0)
                {
                    location = "Boca Raton, FL";
                }
                else if (siblingsValue == 1)
                {
                    location = "Nassau, Bahamas";
                }
                else if (siblingsValue == 2)
                {
                    location = "Ponte Negra, Brazil";
                }
                else if (siblingsValue == 3)
                {
                    location = "Portland, OR";
                }
                else if (siblingsValue > 3)
                {
                    location = "Baton Rouge, LA";
                }
                else if (siblingsValue < 0)
                {
                    location = "Chernobyl, Ukraine";
                }

                // Mode of transportation
                if (color == "red")
                {
                    vehicle = "Maserati";
                }
                if (color == "orange")
                {
                    vehicle = "stallion";
                }
                if (color == "yellow")
                {
                    vehicle = "chariot";
                }
                if (color == "green")
                {
                    vehicle = "taxi";
                }
                if (color == "blue")
                {
                    vehicle = "rickshaw";
                }
                if (color == "indigo")
                {
                    vehicle = "motor scooter";
                }
                if (color == "red")
                {
                    vehicle = "flying saucer";
                }

                // Bank balance
                if (monthValue >= 1 && monthValue <= 12)
                {
                    if (monthValue >= 1 && monthValue <= 4)
                    {
                        balance = "$256,000.76";
                    }
                    if (monthValue >= 5 && monthValue <= 8)
                    {
                        balance = "$3,687,105.42";
                    }
                    if (monthValue >= 9 && monthValue <= 12)
                    {
                        balance = "$86.23";
                    }
                }
                else balance = "$0";
                Console.WriteLine($"{firstName} {lastName} will retire in {years} years with {balance} balance in the bank, a vacation home in {location}, and travel by {vehicle}.");
                spellEffect = false;
            } while (spellEffect == true);
        }
    }
}
