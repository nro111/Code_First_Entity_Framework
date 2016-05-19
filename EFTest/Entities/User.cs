using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public int UserInfoID { get; set; }
        public int UserCredentialID { get; set; }

        [ForeignKey("UserInfoID")]
        public virtual UserInfo UserInfo { get; set; }

        [ForeignKey("UserCredentialID")]
        public virtual UserCredential UserCredential { get; set; }
    }
}
