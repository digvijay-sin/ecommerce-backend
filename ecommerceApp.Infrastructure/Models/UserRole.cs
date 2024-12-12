//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ecommerceApp.Infrastructure.Models
//{
//    public class UserRole
//    {
//        [Key]
//        public int URid { get; set; }
//        public string Uid { get; set; }
//        [ForeignKey("Uid")]
//        public User User { get; set; }
//        public Guid Rid{ get; set; }
//        [ForeignKey("Rid")]
//        public Role Role{ get; set; }
//    }
//}
