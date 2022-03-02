using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalendarMVC.Models
{
    public class WeekOfMonth
    {
        public WeekOfMonth()
        {
            Week1 = Week2 = Week3 = Week4 = Week5 = Week6 = new List<Day>();
        }

        public List<Day> Week1 { get; set; }
        public List<Day> Week2 { get; set; }
        public List<Day> Week3 { get; set; }
        public List<Day> Week4 { get; set; }
        public List<Day> Week5 { get; set; }
        public List<Day> Week6 { get; set; }

        public string CurrentYear { get; set; }
        public string CurrentMonth { get; set; }
        public string NextMonth { get; set; }
        public string PrevMonth { get; set; }
    }
}