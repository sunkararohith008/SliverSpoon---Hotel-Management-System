using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SliverSpoon.Models
{
    public class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            Reservations = new HashSet<Reservation>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomID { get; set; }

        [Required]
        [StringLength(50)]
        public string RoomType { get; set; }

        public int Price { get; set; }

        [Required]
        [StringLength(100)]
        public string RoomDescription { get; set; }

        [Required]
        [StringLength(30)]
        public string RoomStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
