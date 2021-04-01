using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SliverSpoon.Models
{
    public class Reservation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReservationID { get; set; }

        public int RoomID { get; set; }

        public int CustomerID { get; set; }

        public short NumberOfPersons { get; set; }

        public DateTime DateOfBooking { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Room Room { get; set; }
    }
}
