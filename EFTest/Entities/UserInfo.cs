using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.Entities
{
    public class UserInfo
    {
        [Key]
        public int UserInfoID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
