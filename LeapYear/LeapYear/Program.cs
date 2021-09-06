using System;

namespace LeapYear
{
    public class Program
    {   
        public static void Main(string[] args)
        {
            Program program = new Program();
            string input = Console.ReadLine();
            int year = Int32.Parse(input);
            bool leapYear = program.isLeapYear(year);

            if (leapYear)
            {
                Console.WriteLine("yay");
            } else 
            {
                Console.WriteLine("nay");
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
    }
}
