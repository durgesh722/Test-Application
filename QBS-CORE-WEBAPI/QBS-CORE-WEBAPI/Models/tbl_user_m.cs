using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QBS_CORE_WEBAPI.Models
{
    public partial class tbl_user_m
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }
        [Key]
        [StringLength(50)]
        [Column(Order = 2)]
        public string LoginId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Email { get; set; }       

        [StringLength(10)]
        public DateTime DateOfBirth { get; set; }

        [StringLength(10)]
        public string Mobile { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }
        
        public string Address { get; set; }

        public string PinCode { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
      
    }
}
