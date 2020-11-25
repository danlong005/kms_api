using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace kms_api.Models
{
    public class Meeting
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MeetingID { get; set; }
        public DateTime MeetingAt { get; set; }
        public List<Part> Parts { get; set; }
    }
}
