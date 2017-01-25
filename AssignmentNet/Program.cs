using System;

namespace Assignment
{
    class TimeConversion
    {
        static void Main(string[] args)
        {
            string strTime = Console.ReadLine();
            Console.WriteLine(Converter(strTime));
            Console.ReadKey(true);
        }

        public static string Converter(string strTime)
        {
            string[] timeArr = strTime.Split(':');
            string AMPM = timeArr[2].Substring(2);
            string hh = string.Empty;
            if (AMPM.Contains("PM"))
            {
                if (timeArr[0] == "12")
                {
                    hh = timeArr[0];
                }

                else
                {
                    hh = (Convert.ToInt64(timeArr[0]) + 12).ToString();
                }
            }
            else if (AMPM.Contains("AM"))
            {
                if (timeArr[0] == "12")
                {
                    hh = "00";
                }
                else
                {
                    hh = timeArr[0];
                }

            }

            return string.Concat(hh, ':', timeArr[1], ':', timeArr[2].Substring(0, 2));
        }
    }
}

