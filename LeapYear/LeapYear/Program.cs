using System;

namespace LeapYear
{
    public class Program
    {   
        public static void Main(string[] args)
        {
            Program program = new Program();
            string input = Console.ReadLine();
            if (program.validInput(input))
            {
                int year = Int32.Parse(input);
                bool leapYear = program.isLeapYear(year);

                if (leapYear)
                {
                    Console.WriteLine("yay");
                } else 
                {
                    Console.WriteLine("nay");
                }
            } else 
            {
                Console.WriteLine("ERROR. Please enter a valid inputvalue. Your input must be an integer that is higher than 1582.");
            }
        }

        public bool isLeapYear(int year)
        {
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 != 0)
                        {
                            return false;
                        } else 
                        {
                            return true;
                        }
                        
                    } else 
                    {
                        return true;
                    }
                } else 
                {
                    return false;
                }
        }

        public bool validInput(string input) 
        {
            int number;
            bool isNumeric = Int32.TryParse(input, out number);
            if (isNumeric)
            {
                if (number >= 1582) 
                {
                    return true;
                } else 
                {
                    return false;
                }
            } else 
            {
                return false;
            }
        }
    }
}
