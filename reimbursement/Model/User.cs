using System.ComponentModel.DataAnnotations;

namespace reimbursement.Model
{
    public class User
    {
        [Key]
        public int user_id { get; set; }

        public string email { get; set; }

        public string encrypted_password { get; set; }

        public string created_at { get; set; }

        public string upsdated_at { get; set; }

        public string frist_name { get; set; }

        public string last_name { get; set; }

        public string login { get; set; }
    }
}