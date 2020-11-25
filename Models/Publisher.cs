using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace kms_api.Models
{
    public class Publisher
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PublisherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Elder { get; set; }
        public int Servant { get; set; }
        public int Pioneer { get; set; }
        public DateTime BaptizedAt { get; set; }
        public int CongregationID { get; set; }
    }
}
