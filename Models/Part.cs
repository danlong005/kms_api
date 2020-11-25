using System.ComponentModel.DataAnnotations.Schema;

namespace kms_api.Models
{
    public class Part
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PartID { get; set; }
        public Publisher Publisher { get; set; }
        public Publisher Assistant { get; set; }
        public int Number { get; set; }
    }
}
