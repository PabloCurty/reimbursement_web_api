using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace reimbursement.Model
{
    public class Report
    {
        [Key]
        public int report_id { get; set; }
        
        [ForeignKey("User")]
        public int user_id { get; set; }

        public string date { get; set;} 

        public string created_at { get; set; }

        public string updated_at { get; set; }
        
        [ForeignKey("Status")]
        public int status_id { get; set; }
    }
}
