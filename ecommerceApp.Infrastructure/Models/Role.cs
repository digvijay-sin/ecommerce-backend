using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerceApp.Infrastructure.Models
{
    public class Role
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string RoleDescription { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
    }
}
