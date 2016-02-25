using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string aTime)
        {
            StringBuilder str = new StringBuilder();
            string[] clocktime = aTime.Split(':');
            var val = Convert.ToInt32(aTime);
            int hrstime = Convert.ToInt32(clocktime[0]) / 5; /// No of Red lamps
            for (int i = 1; i <= hrstime; i++)
            {
                str.Append("R");

            }
           // Console.WriteLine(str);
            int RmtoprowHrsRed = Convert.ToInt32(clocktime[0]) % 1;

            for (int i = 0; i <= RmtoprowHrsRed; i++)
            {
                str.Append("R");
            }
           // Console.WriteLine(str);
            int Mintime = Convert.ToInt32(clocktime[1]) / 5; /// No of Yellow and Red(3,6,9) lamps
            int RemTime = Convert.ToInt32(clocktime[1]) % 5;

            for (int i = 1; i <= RemTime; i++)
            {
                str.Append("R");

            }

            for (int i = 1; i <= Mintime; i++)
            {
                if (i % 3 == 0)
                {
                    str.Append("R");

                }
                else
                {
                    str.Append("Y");
                }
            }

           // Console.WriteLine(str);

            int Sectime = Convert.ToInt32(clocktime[2]); /// No of Yellow and Red(3,6,9) lamps
            str.Append("R");
            Console.WriteLine(str);

            return str.ToString();
        }
    }
}
