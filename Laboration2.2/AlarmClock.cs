using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2._2
{
    class AlarmClock
    {

        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;

        //properties
        public int AlarmHour
        {
            get
            {
                return _alarmHour;
            }
            set
            {
                if(value < 0 || value > 23)
                {
                    throw new ArgumentException("Alarmtimmen är inte i intervallet 0-23");
                }
                else
                {
                    _alarmHour = value;
                }
            }
        }

        public int AlarmMinute
        {
            get
            {
                return _alarmMinute;
            }
            set
            {
                if(value < 0 || value > 59)
                {
                    throw new ArgumentException("Alarmminuten är inte i intervallet 0-59");
                }
                else
                {
                    _alarmMinute = value;
                }
            }
        }

        public int Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Timmen är inte i intervallet 0-23");
                }
                else
                {
                    _hour = value;
                }
            }
        }

        public int Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Minuten är inte i intervallet 0-59");
                }
                else
                {
                    _minute = value;
                }
            }
        }

        //constructors
        public AlarmClock()
            :this(0, 0)
        {
        }

        public AlarmClock(int hour, int minute)
            :this(hour, minute, 0, 0)
        {
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {                                                                                                                                                               
                Hour = hour;
                Minute = minute;
                AlarmHour = alarmHour;
                AlarmMinute = alarmMinute;
        }

        public bool TickTock()
        {
            if (Minute >= 59)
            {
                if (Hour >= 23)
                {
                    Hour = 0;
                }
                else
                {
                    Hour++;
                }

                Minute = 0;
            }
            else
            {
                Minute++;
            }

            if (Hour == AlarmHour && Minute == AlarmMinute)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ToString()
        {
            if (Minute < 10)
            {
                if(AlarmMinute < 10)
                {
                    return string.Format("{0}:0{1} <{2}:0{3}>", Hour, Minute, AlarmHour, AlarmMinute);
                }

                return string.Format("{0}:0{1} <{2}:{3}>", Hour, Minute, AlarmHour, AlarmMinute);
            }
            else
            {
                if(AlarmMinute < 10)
                {
                    return string.Format("{0}:{1} <{2}:0{3}>", Hour, Minute, AlarmHour, AlarmMinute);
                }
                return string.Format("{0}:{1} <{2}:{3}>", Hour, Minute, AlarmHour, AlarmMinute);
            }
        }

    }
}
