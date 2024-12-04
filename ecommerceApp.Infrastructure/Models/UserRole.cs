using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerceApp.Infrastructure.Models
{
    public class UserRole
    {
        public string Uid { get; set; }
        public User User { get; set; }
        public Guid RoleId{ get; set; }
        public Role Role{ get; set; }
    }
}
