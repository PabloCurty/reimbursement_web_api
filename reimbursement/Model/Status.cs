using System.ComponentModel.DataAnnotations;

namespace reimbursement.Model
{
    public class Status
    {
        [Key]
        public int status_id { get; set; }

        public string name { get; set; }
    }
}