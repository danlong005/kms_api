using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace kms_api.Models
{
    public class Congregation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CongregationID { get; set; }
        public string Name { get; set; }

        public List<Publisher> Publishers { get; set; } 
        public List<Meeting> Meetings { get; set; }
        public TimeSpan MidweekMeetingStartsAt { get; set; }
        public int MidweekMeetingDay { get; set; }
        public TimeSpan WeekendMeetingStartsAt { get; set; }
        public int WeekendMeetingDay { get; set; }
    }
}
