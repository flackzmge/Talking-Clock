
using System;
using System.Xml.Linq;

namespace Talking_Clock
{
    public class Program
    {
        static void Main(string[] args)
        {

          
         
            if (args.Length == 0)
            {
                Console.WriteLine(GetTalkingTimeNow());
                // if there are 0 arguments then get current time
            }
            else if (args.Length == 1)
            {
                Console.WriteLine(GetTalkingTime(args[0]));
                // if there is 1 argument then get time for that argument 
            }
            else
            {
                Console.WriteLine("Invalid Number of Parameters");
            }

        }



        public static string MinsToText(int min)
        {
            string[] mins = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Nineteen", "Twenty","Twenty One","Twenty Two", "Twenty Three", "Twenty Four", "Twenty Five", "Twenty Six", "Twenty Seven", "Twenty Eight", "Twenty Nine" };
            // minutes from 1-29 
            if (min.ToString().Length > 2)
            {
                Console.WriteLine("Invalid Time Make Sure You Display Answer in the format mm:hh");
                // if length of minute charcters is greater then 2 then display this message
            }

            if (min == 30)
            {
                return ("Half past");
                
            }
            else if(min > 0 && min < 30)
            {
                return mins[min-1] + " " + "past";
                // if minutes is 1-29 return one-twenty-nine past
            }
            else if  (min > 30 && min <60)
            {
                return mins[59-min] + " " + "to";
                // if minutes is 31-59 return twenty-nine - one to
            }
            else if (min == 0)
            {
                return "o'clock";
            }
            else
            {
                return ("Invalid min");
            }
        }

        public static string HourToText(int hour,bool isPast30 = false)
        {
            string[] hours = { "Twelve", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve" };


            if (isPast30 && hour == 23)
            {
                hour = 0;
                // if the hour is Eleven and the minute is greater than 30 then reset the hour
            }
            else if (isPast30)
            {
                hour++;
                // if time is greater than 30 then increase the hour time by one 
            }

            if (hour.ToString().Length > 2)
            {
                Console.WriteLine("Invalid Time Make Sure You Display Answer in the format mm:hh");
                // if length of hour charcters is greater then 2 then display this message

            }



            if (hour >= 0 && hour < 24)
            {
                return hours[hour % 12 ];
                // if hour is 0-23 pass in the modulus of the hour result e.g 29 % 12 = 7
            }
            else
            {
                return "Invalid hour";
            }

        }

        public static string GetTalkingTimeNow()
        {
            int currentHour = DateTime.Now.Hour;
            int currentMinutes = DateTime.Now.Minute;
            // set current hour and current minute to current time
            

            return OutputTalkingTime(currentHour, currentMinutes);
        }


        public static string GetTalkingTime(string time)
        {

            int currentHour = 0;
            int currentMinutes = 0;
            var timesParts = time.Split(':');
            // string split the time or anything that has a colon inside it 

            if (timesParts.Length != 2)
            {
                return "Invalid Time Make Sure You Display Answer in the format mm:hh";
                // if time parts does not have two elements in it's array then it is wrong 
            }
            else if (timesParts[0].Length > 2 || timesParts[1].Length > 2)
            {
                return "Invalid Time Make Sure You Display Answer in the format mm:hh";
                // if the amount of characters in element 1 and element 2 of timeparts is greater than 2 then its wrong
            }

            if (int.TryParse(timesParts[0], out currentHour) && int.TryParse(timesParts[1], out currentMinutes))
            {
                if (currentHour < 24)
                {
                    return OutputTalkingTime(currentHour, currentMinutes);
                }  
                else
                {
                    return "Invalid hour";
                }
            
                
            }
            else
            {
                return "Invalid Time, ensure your input time includes numbers";
            }

            

        }

        public static string OutputTalkingTime(int hour, int minutes)
        {

            bool isPast30 = minutes > 30 ? true : false;
            // check if minitues is past 30 and return either true or false


            if (minutes.ToString().Length > 2 || hour.ToString().Length > 2)
            {
                return "Invalid Time Make Sure You Display Answer in the format mm:hh";
                // if the amount of characters in minutes and hours  is greater than 2 then its wrong
            }

            string hourText = HourToText(hour,isPast30);

            string minuteText = MinsToText(minutes);


            if (hourText.Contains("Invalid"))
            {
                return hourText;
            }
                

            if (minuteText.Contains("Invalid"))
            {
                return minuteText;
            }
                

            if (minutes == 0)
            {
                return hourText + " " + minuteText;
            }
            else if (minutes > 30)
            {
                return minuteText + " " + hourText;
            }
            else
            {
                return minuteText + " " + hourText;
            }
        }


    }
}

