using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Time
    {
        int hours, minutes, seconds;

        public Time()
        {
        }

        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public int Hours
        {
            get { return this.hours; }
            set { this.hours = value; }
        }
        public int Minutes
        {
            get { return this.minutes; }
            set { this.minutes = value; }
        }

        public int Seconds
        {
            get { return this.seconds; }
            set { this.seconds = value; }
        }

        public String GetTimesDay()
        {
            String result = "";

            if (((this.hours >= 0) && (this.hours < 6)) || (this.hours == 24))
                result = "Night";
            else
            if ((this.hours >= 6) && (this.hours < 12))
                result = "Morning";
            else
            if ((this.hours >= 12) && (this.hours < 18))
                result = "Day";
            else
            if ((this.hours >= 18) && (this.hours < 24))
                result = "Evening";

            return result;
        }

        public static Time operator +(Time t1, Time t2)
        {
            int summa_seconds = t1.Seconds + t2.Seconds;
            int Count_Minutes = summa_seconds / 60;
            int Normal_seconds = summa_seconds % 60;

            int summa_minutes = t1.Minutes + t2.Minutes + Count_Minutes;
            int Count_Hours = summa_minutes / 60;
            int Normal_minuts = summa_minutes % 60;

            int summa_hours = t1.Hours + t2.Hours + Count_Hours;
            int Normal_hours = summa_hours % 24;

            return new Time(Normal_hours, Normal_minuts, Normal_seconds);
        }

        public static Time operator -(Time t1, Time t2)
        {
            int Normal_seconds = 0;
            int Normal_minutes = 0;
            int Normal_hours = 0;

            int Buf_Minutes_t2 = 0;
            int Buf_Hours_t2 = 0;

            if (t1.Seconds < t2.Seconds)
            {
                Buf_Minutes_t2 = t2.Minutes + 1;
                Normal_seconds = (60 + t1.Seconds) - t2.Seconds;
            }
            else
            {
                Buf_Minutes_t2 = t2.Minutes;
                Normal_seconds = t1.Seconds - t2.Seconds;
            }

            if (t1.Minutes < Buf_Minutes_t2)
            {
                Buf_Hours_t2 = t2.Hours + 1;
                Normal_minutes = (60 + t1.Minutes) - Buf_Minutes_t2;
            }
            else
            {
                Buf_Hours_t2 = t2.Hours;
                Normal_minutes = t1.Minutes - Buf_Minutes_t2;
            }

            if (t1.Hours < Buf_Hours_t2)
                Normal_hours = (24 + t1.Hours) - Buf_Hours_t2;
            else
                Normal_hours = t1.Hours - Buf_Hours_t2;

            return new Time(Normal_hours, Normal_minutes, Normal_seconds);
        }

        public static bool operator >(Time t1, Time t2)
        {
            if (t1.Hours > t2.Hours)
                return true;
            else
            if (t1.Hours < t2.Hours)
                return false;

            if (t1.Minutes > t2.Minutes)
                return true;
            else
            if (t1.Minutes < t2.Minutes)
                return false;

            if (t1.Seconds > t2.Seconds)
                return true;
            else
            if (t1.Seconds < t2.Seconds)
                return false;

            return false;
        }

        public static bool operator <(Time t1, Time t2)
        {
            if (t1.Hours < t2.Hours)
                return true;
            else
            if (t1.Hours > t2.Hours)
                return false;

            if (t1.Minutes < t2.Minutes)
                return true;
            else
            if (t1.Minutes > t2.Minutes)
                return false;

            if (t1.Seconds < t2.Seconds)
                return true;
            else
            if (t1.Seconds > t2.Seconds)
                return false;

            return false;
        }

        public override String ToString()
        {
            return (this.GetTimesDay() + " ( " +this.hours.ToString() +" hours " + this.minutes.ToString() + "minutes " + this.seconds.ToString() + " seconds" + " )" + Environment.NewLine);      
        }

    }
}
