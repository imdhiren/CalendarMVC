using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalendarMVC.Models
{
    public class Calendar
    {
        public static string DateFormat { get; set; } = "MM/dd/yyyy";

        public static WeekOfMonth Gets(int month, int year)
        {

            WeekOfMonth weeks = new WeekOfMonth();
            weeks.Week1 = new List<Day>();
            weeks.Week2 = new List<Day>();
            weeks.Week3 = new List<Day>();
            weeks.Week4 = new List<Day>();
            weeks.Week5 = new List<Day>();
            weeks.Week6 = new List<Day>();

            List<DateTime> dt = new List<DateTime>();
            dt = GetDates(year, month);

            foreach (DateTime day in dt)
            {
                switch (GetWeekOfMonth(day))
                {
                    case 1:
                        Day dy1 = new Day();

                        dy1.Date = day;
                        dy1.DateStr = day.ToString(DateFormat);
                        dy1.DateDay = day.Day;
                        dy1.DayOrder = GetDateInfo(dy1.Date);
                        weeks.Week1.Add(dy1);
                        break;
                    case 2:
                        Day dy2 = new Day();
                        dy2.Date = day;
                        dy2.DateStr = day.ToString(DateFormat);
                        dy2.DateDay = day.Day;
                        dy2.DayOrder = GetDateInfo(dy2.Date);
                        weeks.Week2.Add(dy2);
                        break;
                    case 3:
                        Day dy3 = new Day();
                        dy3.Date = day;
                        dy3.DateStr = day.ToString(DateFormat);
                        dy3.DateDay = day.Day;
                        dy3.DayOrder = GetDateInfo(dy3.Date);
                        weeks.Week3.Add(dy3);
                        break;
                    case 4:
                        Day dy4 = new Day();
                        dy4.Date = day;
                        dy4.DateStr = day.ToString(DateFormat);
                        dy4.DateDay = day.Day;
                        dy4.DayOrder = GetDateInfo(dy4.Date);
                        weeks.Week4.Add(dy4);
                        break;
                    case 5:
                        Day dy5 = new Day();
                        dy5.Date = day;
                        dy5.DateStr = day.ToString(DateFormat);
                        dy5.DateDay = day.Day;
                        dy5.DayOrder = GetDateInfo(dy5.Date);
                        weeks.Week5.Add(dy5);
                        break;
                    case 6:
                        Day dy6 = new Day();
                        dy6.Date = day;
                        dy6.DateStr = day.ToString(DateFormat);
                        dy6.DateDay = day.Day;
                        dy6.DayOrder = GetDateInfo(dy6.Date);
                        weeks.Week6.Add(dy6);
                        break;
                };
            }

            while (weeks.Week1.Count < 7)
            {
                Day dy = null;
                weeks.Week1.Insert(0, dy);
            }

            if (month == 12)
            {
                weeks.NextMonth = (01).ToString() + "/" + (year + 1).ToString();
                weeks.PrevMonth = (month - 1).ToString() + "/" + (year).ToString();
            }
            else if (month == 1)
            {
                weeks.NextMonth = (month + 1).ToString() + "/" + (year).ToString();
                weeks.PrevMonth = (12).ToString() + "/" + (year - 1).ToString();
            }
            else
            {
                weeks.NextMonth = (month + 1).ToString() + "/" + (year).ToString();
                weeks.PrevMonth = (month - 1).ToString() + "/" + (year).ToString();
            }

            weeks.CurrentMonth = GetMonth(month);
            weeks.CurrentYear = year.ToString();
            return weeks;
        }

        public static List<DateTime> GetDates(int year, int month)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))  // Days: 1, 2 ... 31 etc.
            .Select(day => new DateTime(year, month, day)) // Map each day to a date
            .ToList();
        }

        public static int GetWeekOfMonth(DateTime date)
        {
            DateTime beginningOfMonth = new DateTime(date.Year, date.Month, 1);
            while (date.Date.AddDays(1).DayOfWeek != DayOfWeek.Monday)
                date = date.AddDays(1);
            return (int)Math.Truncate((double)date.Subtract(beginningOfMonth).TotalDays / 7f) + 1;
        }

        public static int GetDateInfo(DateTime now)
        {
            int dayNumber = 0;
            DateTime dt = now.Date;
            string dayStr = Convert.ToString(dt.DayOfWeek);

            if (dayStr.ToLower() == "monday")
            {
                dayNumber = 0;
            }
            else if (dayStr.ToLower() == "tuesday")
            {
                dayNumber = 1;
            }
            else if (dayStr.ToLower() == "wednesday")
            {
                dayNumber = 2;
            }
            else if (dayStr.ToLower() == "thursday")
            {
                dayNumber = 3;
            }
            else if (dayStr.ToLower() == "friday")
            {
                dayNumber = 4;
            }
            else if (dayStr.ToLower() == "saturday")
            {
                dayNumber = 5;
            }
            else if (dayStr.ToLower() == "sunday")
            {
                dayNumber = 6;
            }

            return dayNumber;
        }

        public static string GetMonth(int month)
        {
            string monthStr = string.Empty;
            switch (month)
            {
                case 1:
                    monthStr = "Jan";
                    break;
                case 2:
                    monthStr = "Feb";
                    break;
                case 3:
                    monthStr = "Mar";
                    break;
                case 4:
                    monthStr = "Apr";
                    break;
                case 5:
                    monthStr = "May";
                    break;
                case 6:
                    monthStr = "Jun";
                    break;
                case 7:
                    monthStr = "Jul";
                    break;
                case 8:
                    monthStr = "Aug";
                    break;
                case 9:
                    monthStr = "Sep";
                    break;
                case 10:
                    monthStr = "Oct";
                    break;
                case 11:
                    monthStr = "Nov";
                    break;
                case 12:
                    monthStr = "Dec";
                    break;
                default:
                    monthStr = "non";
                    break;
            }
            return monthStr;
        }

    }
}