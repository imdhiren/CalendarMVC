using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalendarMVC.Models
{
    public class Day
    {
        public DateTime Date { get; set; }
        public string DateStr { get; set; }
        public int DateDay { get; set; }
        public int? DayOrder { get; set; }
    }
}