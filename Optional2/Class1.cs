using System;


namespace Optional2
{
    internal class Class1
    {
        //Ticket Office Assignment
        public static int GetAge()
        {
            Console.WriteLine("Please enter your age: ");
            string text = Console.ReadLine();
            int age = Convert.ToInt32(text);
            return age;
        }

        public static string GetTicket()
        {
            Console.WriteLine("\nSelect Standing or Seated ticket: ");
            string place = Console.ReadLine();
            if (place != "standing" && place != "seated")
            {
                Console.WriteLine("Invalid input. Please enter 'standing' or 'seated'.");
                return GetTicket();
            }
            return place;
        }
        public static int PriceSetter(int age, string place)
        {
            int price;

            if (age <= 11)
            {
                price = (place == "standing") ? 25 : 50;
            }
            else if (age >= 12 && age <= 64)
            {
                price = (place == "standing") ? 110 : 170;
            }
            else
            {
                price = (place == "standing") ? 60 : 100;
            }

            return price;
        }
        public static decimal TaxCalculator(int price)
        {
            decimal tax = Convert.ToDecimal((1 - 1 / 1.06) * price);
            return Math.Round(tax, 2);
        }

        public static int TicketNumberGenerator()
        {
            var rand = new Random();
            return rand.Next(1, 8000);
        }

        // Optional Assignment 1

        public static bool CheckPlaceAvailability(string placeList, int placeNumber)
        {

            string searchPattern = $",{placeNumber},";
            return !placeList.Contains(searchPattern);
        }

        public static string AddPlace(string placeList, int placeNumber)
        {
            placeList += $"{placeNumber},";
            return placeList;
        }

        // Optional Assignment 2

        public static int GetCustomerAge()
        {
            int Age;
            string input;

            do
            {
                Console.WriteLine("Enter customer's age: ");
                input = Console.ReadLine();

            } while (!IsNumeric(input) || !IsAgeValid(input, out Age));

            return Age;
        }

        static bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!Char.IsDigit(c))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.\n");
                    return false;
                }
            }
            return true;
        }

        static bool IsAgeValid(string input, out int Age)
        {
            if (int.TryParse(input, out Age) && input.Length >= 1 && input.Length <= 3)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid age. Age must be between 1 and 3 characters in length.\n");
                return false;
            }
        }

        public static string GetCustomerPlacePreference()
        {
            string preference;
            bool validInput = false;

            do
            {
                Console.Write("Enter customer's place preference (Seated or Standing): ");
                preference = Console.ReadLine();

                if (preference.Equals("Seated", StringComparison.OrdinalIgnoreCase) ||
                    preference.Equals("Standing", StringComparison.OrdinalIgnoreCase))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter Seated or Standing.");
                }
            } while (!validInput);

            return preference;
        }
    }
}

       