using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QBS_CORE_WEBAPI.Models
{
    public class tbl_service_m
    {
        [Key]
        public int id { get; set; }
        [StringLength(50)]
        public string vc_service_code { get; set; }
        [StringLength(500)]
        public string vc_service_desc { get; set; }
        public decimal nu_service_min_amt { get; set; } = 0;
        public decimal nu_service_max_amt { get; set; } = 0;
        public bool b_active { get; set; } = true;
        public DateTime dt_created_on { get; set; } = DateTime.UtcNow;
        public DateTime? dt_modified_on { get; set; }
        public long dt_created_by { get; set; }
        public long dt_midified_by { get; set; }

    }
}
