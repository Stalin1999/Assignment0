using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
        
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
