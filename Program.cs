using System;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            /*do {

            }*/
            
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            string years = "";
            Console.WriteLine("What is your month of birth (as a number)?");
            int month = int.Parse(Console.ReadLine());
            string balance = "";
            bool colorCheck = false;
            string color;
            do {
                Console.WriteLine("What is your favorite ROYGBIV color? (Enter 'Help' for a list of ROYGBIV colors.)");
                color = Console.ReadLine();
                if (color == "Help") { // implement case sensitivity possibly maybe???
                    Console.WriteLine("R = red, O = orange, Y = yellow, G = green, B = blue, I = indigo, V = violet.");
                }
                else colorCheck = true;
            } while (colorCheck == false);
            
            // char color = Console.ReadKey().KeyChar;
            string vehicle = "";
            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());
            string location = "";

            // Years until retirement
            if (age % 2 == 0) {
                years = "12";
            }
            else years = "14";

            // Vacation home location
            if (siblings == 0) {
                location = "Boca Raton, FL";
            }
            else if (siblings == 1) {
                location = "Nassau, Bahamas";
            }
            else if (siblings == 2) {
                location = "Ponte Negra, Brazil";
            }
            else if (siblings == 3) {
                location = "Portland, OR";
            }
            else if (siblings > 3) {
                location = "Baton Rouge, LA";
            }
            else if (siblings < 0) {
                location = "Chernobyl, Ukraine";
            }

            // Mode of transportation
            if (color == "red") {
                vehicle = "Maserati";
            }
            if (color == "orange") {
                vehicle = "stallion";
            }
            if (color == "yellow") {
                vehicle = "chariot";
            }
            if (color == "green") {
                vehicle = "taxi";
            }
            if (color == "blue") {
                vehicle = "rickshaw";
            }
            if (color == "indigo") {
                vehicle = "motor scooter";
            }
            if (color == "red") {
                vehicle = "flying saucer";
            }

            // Bank balance
            if (month >= 1 && month <= 12) {
                if (month >= 1 && month <= 4) {
                    balance = "$256,000.76";
                }
                if (month >= 5 && month <= 8) {
                    balance = "$3,687,105.42";
                }
                if (month >= 9 && month <= 12) {
                    balance = "$86.23";
                }
            }
            else balance = "$0";
            Console.WriteLine($"{firstName} {lastName} will retire in {years} years with {balance} balance in the bank, a vacation home in {location}, and travel by {vehicle}.");
        }
    }
}
