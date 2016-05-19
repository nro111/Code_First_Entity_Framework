using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.Entities
{
    public class UserCredential
    {
        [Key]
        public int UserCredentialID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
