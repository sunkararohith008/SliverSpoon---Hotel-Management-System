using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SliverSpoon.Models
{
    public class Staff
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StaffID { get; set; }

        [Required]
        [StringLength(30)]
        public string StaffName { get; set; }

        [Required]
        [StringLength(30)]
        public string StaffPosition { get; set; }

        [Required]
        [StringLength(10)]
        public string StaffContactNumber { get; set; }

        [Required]
        [StringLength(30)]
        public string JobType { get; set; }
    }
}
